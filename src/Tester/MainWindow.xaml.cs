using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalendarDaySelect;

namespace Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public enum DayOfWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    public enum MonthE { Invalid, January, February, March, April, May, June, July, August, September, October, Noember, December};
    public partial class MainWindow : Window
    {
        public int[] DaysInMonth = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public List<DaySelect> days = new List<DaySelect>();
        public DateTime dte;
        public int Month = (int)MonthE.October;
        public int Year = 2021;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            days.Clear();
            dte = new DateTime(Year, Month, 1);
            //MessageBox.Show(dte.DayOfWeek.ToString());
            int x = (int)dte.DayOfWeek; 
            int y = 1;

            for (int v = 1; v <= DaysInMonth[Month]; v++)
            {
                DaySelect d = new DaySelect();
                d.DayOfMonth = v;
                d.Row = x;
                d.Column = y;
                days.Add(d);
       
                if (x >= 6)
                {
                    x = 0;
                    y++;
                }
                else
                {
                    x++;
                }
            }

            foreach (DaySelect day in days)
            {
                MonthGrid.Children.Add(day);
                Grid.SetColumn(day, day.Row);
                Grid.SetRow(day, day.Column);
            }
            //MessageBox.Show(days.Count.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            days.Clear();
            Month = 1;
            dte = new DateTime(Year, 1, 1);
            //MessageBox.Show(dte.DayOfWeek.ToString());
            int x;
            int y = 1;
            int Offset;
            bool OnDay = false;
            if (OnDay) { Offset = (int)dte.DayOfWeek; } else { Offset = 0; };
            x = Offset+1;

            for (int v = 1; v <= 365; v++)
            {
                DaySelect d = new DaySelect();
                d.DayOfMonth = dte.Day;
                d.Row = x;
                d.Column = y;
                days.Add(d);

                //if (x >= DaysInMonth[Month] + Offset)
                dte = dte.AddDays(1);
                if (dte.Day == 1)
                {
                    Month = dte.Month;
                    //   if (Month >= 12) { Month = 1; } else { Month++; }
                    //dte = dte.AddDays(1);
                    if (OnDay) { Offset = (int)dte.DayOfWeek; } else { Offset = 0; }
                    x = Offset+1;
                    y++;
                }
                else
                {
                    //dte = dte.AddDays(1);
                    x++;
                }

            }

            foreach (DaySelect day in days)
            {
                CalendarFrame.Children.Add(day);
                Grid.SetColumn(day, day.Row);
                Grid.SetRow(day, day.Column);
            }
        }
    }
}
