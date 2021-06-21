using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;

namespace Slats.Models
{
    /// <summary>
    /// Interaction logic for FileManager.xaml
    /// </summary>
    /// 
    public class Item
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastWriteTime { get; set; }
        public string Extension { get; set; }
    }

    public class FileItem : Item
    {

    }
    public class DirectoryItem : Item
    {
        public ObservableCollection<Item> Items { get; set; }

        public DirectoryItem()
        {
            Items = new ObservableCollection<Item>();
        }
    }
    public class ItemProvider
    {
        public ObservableCollection<Item> GetItems(string path)
        {
            var items = new ObservableCollection<Item>();

            var dirInfo = new DirectoryInfo(path);

            foreach (var directory in dirInfo.GetDirectories())
            {
                var item = new DirectoryItem
                {
                    Name = directory.Name,
                    Path = directory.FullName,
                    Items = GetItems(directory.FullName),
                    Created = directory.CreationTime,
                    Extension = directory.Extension,
                    LastWriteTime = directory.LastWriteTime
                };

                items.Add(item);
            }

            foreach (var file in dirInfo.GetFiles())
            {
                var item = new FileItem
                {
                    Name = file.Name,
                    Path = file.FullName
                };

                items.Add(item);
            }

            return items;
        }
    }
}