using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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

namespace CalendarDaySelect
{
    /// <summary>
    /// Interaction logic for DaySelect.xaml
    /// </summary>
    public partial class DaySelect : UserControl, INotifyPropertyChanged
    {
        //private DayVM dvm { get; set; }
        public DaySelect()
        {
            InitializeComponent();
            BackgroundBrush = new SolidColorBrush(Colors.CadetBlue);
            HighlightBrush = new SolidColorBrush(Colors.LightGray);

            //DataContext = dvm;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime _Date;
        private int _FlagBorder;
        private int _Flagackground;
        private int _FlagForeground;
        private int _DayOfMonth;

        private Brush _HighlightBrush;
        public Brush HighlightBrush
        {
            get => _HighlightBrush;

            set
            {
                _HighlightBrush = value;
                RaisePropertyChanged();
            }
        }

        private Brush _background;
        public Brush BackgroundBrush
        {
            get => _background;
            
            set
            {
                _background = value;
                RaisePropertyChanged();
            }
        }
        public int DayOfMonth
        {
            get => _DayOfMonth;
            set
            {
                _DayOfMonth = value;
                RaisePropertyChanged();
            }
        }


        public DateTime Date
        {
            get => _Date;
            set
            {
                _Date = value;
                RaisePropertyChanged();
                DayOfMonth = _Date.Day;
            }
        }

        public int FlagBorder
        {
            get => _FlagBorder;
            set
            {
                _FlagBorder = value;
            }

        }
        public int Flagackground
        {
            get => _Flagackground;
            set
            {
                _Flagackground = value;
            }

        }
        public int FlagForeground
        {
            get => _FlagForeground;
            set
            {
                _FlagForeground = value;
            }

        }


        public int Row { get; set; }
        public int Column { get; set; }

        public void RaisePropertyChanged([CallerMemberName] String propertyName = null)
        {
            AssertPropertyExists(propertyName);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Warns the developer if this object does not have
        /// a public property with the specified name. This
        /// method does not exist in a Release build.
        /// </summary>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public virtual void AssertPropertyExists(string propertyName)
        {
            // Verify that the property name matches a real,
            // public, instance property on this object.
            var properties = TypeDescriptor.GetProperties(this);
            if (properties[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;
                Debug.Fail(msg);
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BackgroundBrush = new SolidColorBrush(Colors.DarkBlue);

        }

        private void Border_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            HighlightBrush = new SolidColorBrush(Colors.DarkGoldenrod);

        }
    }
}
