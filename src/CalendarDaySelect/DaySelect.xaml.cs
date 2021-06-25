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
            BorderBrush = new SolidColorBrush(Colors.LightGray);
            DayForegroundBrush = new SolidColorBrush(Colors.Black);
            BackgroundBrushes.Add(new SolidColorBrush(Colors.LightGray));
            BackgroundBrushes.Add(new SolidColorBrush(Colors.DarkGray));
            BackgroundBrushes.Add(new SolidColorBrush(Colors.Silver));
            BackgroundBrushes.Add(new SolidColorBrush(Colors.White));
            DayBorderBrushes.Add(new SolidColorBrush(Colors.White));
            DayBorderBrushes.Add(new SolidColorBrush(Colors.Yellow));
            DayBorderBrushes.Add(new SolidColorBrush(Colors.Green));
            DayBorderBrushes.Add(new SolidColorBrush(Colors.Pink));
            DayForegroundBrushes.Add(new SolidColorBrush(Colors.Pink));
            DayForegroundBrushes.Add(new SolidColorBrush(Colors.Violet));
            DayForegroundBrushes.Add(new SolidColorBrush(Colors.Blue));
            DayForegroundBrushes.Add(new SolidColorBrush(Colors.Black));
            //DataContext = dvm;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //ToDo: Add ability to update Brush collections from outside the control
        private List<Brush> BackgroundBrushes = new List<Brush>();
        private List<Brush> DayBorderBrushes = new List<Brush>();
        private List<Brush> DayForegroundBrushes = new List<Brush>();
        private DateTime _Date;
        private int _FlagBorder;
        private int _Flagackground;
        private int _FlagForeground;
        private int _DayOfMonth;

        private Brush _DayForegroundBrush;
        public Brush DayForegroundBrush
        {
            get => _DayForegroundBrush;

            set
            {
                _DayForegroundBrush = value;
                RaisePropertyChanged();
            }
        }

        private Brush _DayBorderBrush;
        public Brush DayBorderBrush
        {
            get => _DayBorderBrush;

            set
            {
                _DayBorderBrush = value;
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
                DayBorderBrush = DayBorderBrushes[_FlagBorder];
            }

        }
        public int Flagackground
        {
            get => _Flagackground;
            set
            {
                _Flagackground = value;
                BackgroundBrush = BackgroundBrushes[_Flagackground];
            }

        }
        public int FlagForeground
        {
            get => _FlagForeground;
            set
            {
                _FlagForeground = value;
                DayForegroundBrush = DayForegroundBrushes[_FlagForeground];
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
            //BackgroundBrush = new SolidColorBrush(Colors.DarkBlue);
            
            if (Flagackground >= BackgroundBrushes.Count-1) { Flagackground = 0; } else { Flagackground++; }
        }

        private void Border_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            //HighlightBrush = new SolidColorBrush(Colors.DarkGoldenrod);
            if (FlagBorder >= DayBorderBrushes.Count-1) { FlagBorder = 0; } else { FlagBorder++; }

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                if (FlagForeground >= DayForegroundBrushes.Count - 1) { FlagForeground = 0; } else { FlagForeground++; }
            }
        }
    }
}
