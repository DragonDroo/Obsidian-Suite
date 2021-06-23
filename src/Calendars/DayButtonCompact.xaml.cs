using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Controls.Calendars
{
    /// <summary>
    /// Interaction logic for DayButtonCompact.xaml
    /// </summary>
    public partial class DayButtonCompact : UserControl
    {
        DayModel dayModel = new DayModel();
          public DayButtonCompact()
          {
            InitializeComponent();
            DayOfMonthDisp.DataContext = dayModel;

          }
        public class DayModel : INotifyPropertyChanged
        {
            private int _dayOfMonth = 0;

            public int DayOfMonth
            {
                get { return _dayOfMonth; }
                set
                {
                    _dayOfMonth = value;
                    OnPropertyChanged();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dayModel.DayOfMonth++;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dayModel.DayOfMonth++;
        }

        private void ShowDayDetail(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

