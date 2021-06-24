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

namespace CalendarDaySelect
{
    /// <summary>
    /// Interaction logic for MonthSelect.xaml
    /// </summary>
    public enum DayOfWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
public enum MonthE { Invalid, January, February, March, April, May, June, July, August, September, October, Noember, December };
public partial class MonthSelect : UserControl
    {
        public int[] DaysInMonth = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public List<DaySelect> days = new List<DaySelect>();
        public DateTime dte;
        public int Month = (int)MonthE.October;
        public int Year = 2021;
        public MonthSelect()
        {
            InitializeComponent();

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
        }
    }
}
