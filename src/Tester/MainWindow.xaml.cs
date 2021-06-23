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
    public partial class MainWindow : Window
    {
        public List<DaySelect> days = new List<DaySelect>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            int x = 0;
            int y = 0;

            for (int v = 1; v < 42; v++)
            {
                DaySelect d = new DaySelect();
                d.DayOfMonth = v;
                d.Row = x;
                d.Column = y;
                days.Add(d);
       
                if (x >= 7)
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
    }
}
