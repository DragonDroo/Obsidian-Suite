 using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Slats.Models;
using Slats.ViewModels;
using System.IO;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for FileManager.xaml
    /// </summary>
    public partial class FileManager : Page
    {

        public FileManager(FileManagerVM viewmodel)
        {
            InitializeComponent();
            //var itemProvider = new ItemProvider();
            //var items = itemProvider.GetItems("S:\\11M - ACOS (MH&BS)\\02_Supervisors\\TMS Data");
            //DataContext = items;
            DataContext = viewmodel;

            //DataContext = viewmodel;
            
            //string rootdir = @"C:\Users\Aditya Goel\Desktop\C#";

            //string[] files = Directory.GetFileSystemEntries(rootdir, "*", SearchOption.AllDirectories);
            //foreach (string f in files)
            //{
            //    FileTree
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var itemProvider = new ItemProvider();
            //var items = itemProvider.GetItems("S:\\11M - ACOS (MH&BS)\\02_Supervisors\\PDs_&_FSs");
            //DataContext = items;
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //var itemProvider = new ItemProvider();
            //var items = itemProvider.GetItems("S:\\11M - ACOS (MH&BS)\\02_Supervisors\\TMS Data");
            //DataContext = items;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //var itemProvider = new ItemProvider();
            //var items = itemProvider.GetItems("S:\\11M - ACOS (MH&BS)\\02_Supervisors\\TMS Data");
            //DataContext = items;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //var itemProvider = new ItemProvider();
            //var items = itemProvider.GetItems("S:\\11M - ACOS (MH&BS)\\02_Supervisors\\TMS Data");
            //DataContext = items;
        }
        private void EhDragOver(object sender, DragEventArgs args)
        {
            // As an arbitrary design decision, we only want to deal with a single file.
            args.Effects = IsSingleFile(args) != null ? DragDropEffects.Copy : DragDropEffects.None;

            // Mark the event as handled, so TextBox's native DragOver handler is not called.
            args.Handled = true;
        }

        private void EhDrop(object sender, DragEventArgs args)
        {
            // Mark the event as handled, so TextBox's native Drop handler is not called.
            args.Handled = true;

            var fileName = IsSingleFile(args);
            if (fileName == null) return;

            var fileToLoad = new StreamReader(fileName);
            tbDisplayFileContents.Text = fileToLoad.ReadToEnd();
            fileToLoad.Close();

            // Set the window title to the loaded file.
            Title = "File Loaded: " + fileName;
        }

        // If the data object in args is a single file, this method will return the filename.
        // Otherwise, it returns null.
        private string IsSingleFile(DragEventArgs args)
        {
            // Check for files in the hovering data object.
            if (args.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                var fileNames = args.Data.GetData(DataFormats.FileDrop, true) as string[];
                // Check for a single file or folder.
                if (fileNames?.Length is 1)
                {
                    // Check for a file (a directory will return false).
                    if (File.Exists(fileNames[0]))
                    {
                        // At this point we know there is a single file.
                        return fileNames[0];
                    }
                }
            }
            return null;
        }
        
        private List<string> FilesList(DragEventArgs args)
        {
            List<string> FilesList = new List<string>();

            // Check for files in the hovering data object.
            if (args.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                var fileNames = args.Data.GetData(DataFormats.FileDrop, true) as List<string>;
                // Check for a single file or folder.
                MessageBox.Show(fileNames.Count.ToString());


                //if (fileNames?.Length is 1)
                //{
                //    // Check for a file (a directory will return false).
                //    if (File.Exists(fileNames[0]))
                //    {
                //        // At this point we know there is a single file.
                //        return FilesList;
                //    }
                //}
            }
            return null;
        }
    }
}
