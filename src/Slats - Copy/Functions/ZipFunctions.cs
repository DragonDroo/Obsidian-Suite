﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Core;

namespace Slats.Functions
{
    public static class ZipFunctions
    {
        //    Use example
        //          If the file doesn't have password
        //          ExtractZipContent(
        //          @"C:\Users\user\Desktop\SomeFolder\TheFileToDecompress.zip",
        //          null,
        //          @"C:\Users\user\Desktop\outputfolder"
        //          );

        //          // If the file has password
        //          ExtractZipContent(
        //          @"C:\Users\user\Desktop\SomeFolder\TheFileToDecompress.zip",
        //          "password123",
        //          @"C:\Users\user\Desktop\outputfolder"
        //          );

        /// <summary>
        /// Extracts the content from a .zip file inside an specific folder.
        /// </summary>
        /// <param name="FileZipPath"></param>
        /// <param name="password"></param>
        /// <param name="OutputFolder"></param>
        public static void ExtractZipContent(string FileZipPath, string password, string OutputFolder)
        {
            ZipFile file = null;
            try
            {
                FileStream fs = File.OpenRead(FileZipPath);
                file = new ZipFile(fs);

                if (!String.IsNullOrEmpty(password))
                {
                    // AES encrypted entries are handled automatically
                    file.Password = password;
                }

                foreach (ZipEntry zipEntry in file)
                {
                    if (!zipEntry.IsFile)
                    {
                        // Ignore directories
                        continue;
                    }

                    String entryFileName = zipEntry.Name;
                    // to remove the folder from the entry:- entryFileName = Path.GetFileName(entryFileName);
                    // Optionally match entrynames against a selection list here to skip as desired.
                    // The unpacked length is available in the zipEntry.Size property.

                    // 4K is optimum
                    byte[] buffer = new byte[4096];
                    Stream zipStream = file.GetInputStream(zipEntry);

                    // Manipulate the output filename here as desired.
                    String fullZipToPath = Path.Combine(OutputFolder, entryFileName);
                    string directoryName = Path.GetDirectoryName(fullZipToPath);

                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(directoryName);
                    }

                    // Unzip file in buffered chunks. This is just as fast as unpacking to a buffer the full size
                    // of the file, but does not waste memory.
                    // The "using" will close the stream even if an exception occurs.
                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipStream, streamWriter, buffer);
                    }
                }
            }
            finally
            {
                if (file != null)
                {
                    file.IsStreamOwner = true; // Makes close also shut the underlying stream
                    file.Close(); // Ensure we release resources
                }
            }
        }


        /// <summary>
        /// Method that compress all the files inside a folder (non-recursive) into a zip file.
        /// </summary>
        /// <param name="DirectoryPath"></param>
        /// <param name="OutputFilePath"></param>
        /// <param name="CompressionLevel"></param>
        public static void compressDirectoryWithPassword(string DirectoryPath, string OutputFilePath, string Password = null, int CompressionLevel = 9)
        {
            // Usage Example 

            // Or to use without password:
            // string PasswordForZipFile = null;
            // string PasswordForZipFile = "ourcodeworld123";

            //compressDirectoryWithPassword(
            //    @"C:\Users\user\Desktop\Folders",
            //    @"C:\Users\user\Desktop\Folders\DestinationFile.zip",
            //    PasswordForZipFile,
            //    9
            //);
            try
            {
                // Depending on the directory this could be very large and would require more attention
                // in a commercial package.
                string[] filenames = Directory.GetFiles(DirectoryPath);

                // 'using' statements guarantee the stream is closed properly which is a big source
                // of problems otherwise.  Its exception safe as well which is great.
                using (ZipOutputStream OutputStream = new ZipOutputStream(File.Create(OutputFilePath)))
                {
                    // Define a password for the file (if providen)
                    // set its value to null or don't declare it to leave the file
                    // without password protection
                    OutputStream.Password = Password;

                    // Define the compression level
                    // 0 - store only to 9 - means best compression
                    OutputStream.SetLevel(CompressionLevel);

                    byte[] buffer = new byte[4096];

                    foreach (string file in filenames)
                    {

                        // Using GetFileName makes the result compatible with XP
                        // as the resulting path is not absolute.
                        ZipEntry entry = new ZipEntry(Path.GetFileName(file));

                        // Setup the entry data as required.

                        // Crc and size are handled by the library for seakable streams
                        // so no need to do them here.

                        // Could also use the last write time or similar for the file.
                        entry.DateTime = DateTime.Now;
                        OutputStream.PutNextEntry(entry);

                        using (FileStream fs = File.OpenRead(file))
                        {

                            // Using a fixed size buffer here makes no noticeable difference for output
                            // but keeps a lid on memory usage.
                            int sourceBytes;

                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                OutputStream.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }
                    }

                    // Finish/Close arent needed strictly as the using statement does this automatically

                    // Finish is important to ensure trailing information for a Zip file is appended.  Without this
                    // the created file would be invalid.
                    OutputStream.Finish();

                    // Close is important to wrap things up and unlock the file.
                    OutputStream.Close();

                    Console.WriteLine("Files successfully compressed");
                }
            }
            catch (Exception ex)
            {
                // No need to rethrow the exception as for our purposes its handled.
                Console.WriteLine("Exception during processing {0}", ex);
            }
        }


        /// <summary>
        /// Method that compress all the files inside a folder (non-recursive) into a zip file.
        /// </summary>
        /// <param name="DirectoryPath"></param>
        /// <param name="OutputFilePath"></param>
        /// <param name="CompressionLevel"></param>
        public static void compressDirectory(string DirectoryPath, string OutputFilePath, int CompressionLevel = 9)
        {
            //  Usage example
            //compressDirectory(
            //   @"C:\Users\user\Desktop\SomeFolder",
            //   @"C:\Users\user\Desktop\SomeFolder\MyOutputFile.zip",
            //   9
            //   );
            try
            {
                // Depending on the directory this could be very large and would require more attention
                // in a commercial package.
                string[] filenames = Directory.GetFiles(DirectoryPath);

                // 'using' statements guarantee the stream is closed properly which is a big source
                // of problems otherwise.  Its exception safe as well which is great.
                using (ZipOutputStream OutputStream = new ZipOutputStream(File.Create(OutputFilePath)))
                {

                    // Define the compression level
                    // 0 - store only to 9 - means best compression
                    OutputStream.SetLevel(CompressionLevel);

                    byte[] buffer = new byte[4096];

                    foreach (string file in filenames)
                    {

                        // Using GetFileName makes the result compatible with XP
                        // as the resulting path is not absolute.
                        ZipEntry entry = new ZipEntry(Path.GetFileName(file));

                        // Setup the entry data as required.

                        // Crc and size are handled by the library for seakable streams
                        // so no need to do them here.

                        // Could also use the last write time or similar for the file.
                        entry.DateTime = DateTime.Now;
                        OutputStream.PutNextEntry(entry);

                        using (FileStream fs = File.OpenRead(file))
                        {

                            // Using a fixed size buffer here makes no noticeable difference for output
                            // but keeps a lid on memory usage.
                            int sourceBytes;

                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                OutputStream.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }
                    }

                    // Finish/Close arent needed strictly as the using statement does this automatically

                    // Finish is important to ensure trailing information for a Zip file is appended.  Without this
                    // the created file would be invalid.
                    OutputStream.Finish();

                    // Close is important to wrap things up and unlock the file.
                    OutputStream.Close();

                    Console.WriteLine("Files successfully compressed");
                }
            }
            catch (Exception ex)
            {
                // No need to rethrow the exception as for our purposes its handled.
                Console.WriteLine("Exception during processing {0}", ex);
            }
        }
    }
}
