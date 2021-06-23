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

namespace Controls.Calendars
{
    /// <summary>
    /// Interaction logic for CelendarMonthCompact.xaml
    /// </summary>
    public partial class CelendarMonthCompact : UserControl
    {
        private CalendarMonthVM _viewModel;
        public string monthName = "January";
        public string MonthName { get; set; }
        public CelendarMonthCompact()
        {
            InitializeComponent();
            MonthName = "January";
        }
    }
}
