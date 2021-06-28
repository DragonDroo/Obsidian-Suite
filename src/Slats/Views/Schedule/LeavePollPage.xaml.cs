using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Slats.ViewModels;
using CalendarDaySelect;

namespace Slats.Views
{
    #region Public Constructors
    /// <summary>
    /// Interaction logic for LeavePollCalendarPage.xaml
    /// </summary>
    public partial class LeavePollPage : Page
    {
        public LeavePollPage(LeavePollVM viewmodel)
        {
            InitializeComponent();
            DataContext = viewmodel;

#if DEBUG
            AppDomain.CurrentDomain.FirstChanceException += (source, e) =>
            {
                Debug.WriteLine("FirstChanceException event raised in {0}: {1}",
                    AppDomain.CurrentDomain.FriendlyName, e.Exception.Message);
            };
#endif
     //       DataContext = new ModelView.ModelView();
        }

#endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// Add line numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var index = e.Row.GetIndex() + 1;
            e.Row.Header = $"{index}";
        }
        #endregion Private Methods

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Month1.Month = 1;
            Month2.Month = 2;
            Month3.Month = 3;
            Month4.Month = 4;
            Month5.Month = 5;
            Month6.Month = 6;
            Month7.Month = 7;
            Month8.Month = 8;
            Month9.Month = 9;
            Month10.Month = 10;
            Month11.Month = 11;
            Month12.Month = 12;
        }
    }
}
