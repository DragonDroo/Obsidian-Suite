using System;
using System.IO;
using System.Collections.Generic;

namespace Slats.Functions
{
    public class FileSystem
    {
        public List<String> ListFiles(string path)
        {
            List<String> listFiles = new List<string>();

            if (DirectoryExists(path) == true)
            {
                DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
                foreach (FileInfo file in Files)
                {
                    listFiles.Add(file.Name);
                }
                return listFiles;
            }
            else
            {
                return null;
            }
        }

        public bool DirectoryExists(string path)
        {
            return Directory.Exists(path);
        }

        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void DeleteDirectory(string path, bool recursive = true)
        {
            Directory.Delete(path, recursive);
        }

        public void MoveDirectory(string srcPath, string destPath)
        {
            Directory.Move(srcPath, destPath);
        }

        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        public char DirectorySeparatorChar
        {
            get { return Path.DirectorySeparatorChar; }
        }

        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public void WriteAllText(string path, string text)
        {
            File.WriteAllText(path, text);
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public void WriteAllLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public void CopyFile(string srcPath, string destPath)
        {
            File.Copy(srcPath, destPath);
        }

        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        public void MoveFile(string srcFile, string destFile)
        {
            File.Move(srcFile, destFile);
        }




        public void createPwdExcel(string Filename)
        {
            //private Excel.Application oexcel;
            //private Excel.Workbook obook;
            //private Excel.Worksheet osheet;
            //{
            //    // File name and path, here i used abc file to be 
            //    // stored in Bin directory in the sloution directory
            //    //Filename = (AppDomain.CurrentDomain.BaseDirectory + "abc.xls");
            //    if (File.Exists(Filename))
            //    {
            //        File.Delete(Filename);
            //    }

            //    if (!File.Exists(Filename))
            //    {
            //        // create new excel application
            //        Excel.Application oexcel = new Excel.Application();
            //        oexcel.Application.DisplayAlerts = false;
            //        obook = oexcel.Application.Workbooks.Add(Type.Missing);
            //        oexcel.Visible = true;
            //        Console.WriteLine("Generating Auto Report");
            //        osheet = (Excel.Worksheet)obook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //        osheet.Name = "Test Sheet";
            //        osheet.get_Range("A1:G1").Merge();
            //        osheet.get_Range("A1").Value = @"Implementing Password Security on Excel Workbook Using Studio.Net";

            //        osheet.get_Range("A1").Interior.ColorIndex = 5;
            //        osheet.get_Range("A1").Font.Bold = true;
            //        string password = "abc";
            //        obook.WritePassword = password;
            //        obook.SaveAs("Chandra.xlsx");
            //        // otherwise use the folowing one
            //        // TODO: Labeled Arguments not supported. Argument: 2 := 'password'
            //        // end application object and session
            //        osheet = null;
            //        obook.Close();
            //        obook = null;
            //        oexcel.Quit();
            //        oexcel = null;
            //    }

            //}
            //catch (Exception ex)
            //{

            //}

        }

    }
}
