using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  https://www.codeproject.com/articles/874425/drag-and-drop-in-mvvm-wpf

namespace DragDrop
{
    /// <summary>
    /// Event args for when a visual is dropped
    /// </summary>
    public class DragDropEventArgs : EventArgs
    {
        public Object DataContext;
        public DragDropEventArgs() { }
        public DragDropEventArgs(Object dataContext)
        {
            DataContext = dataContext;
        }
    }
}
