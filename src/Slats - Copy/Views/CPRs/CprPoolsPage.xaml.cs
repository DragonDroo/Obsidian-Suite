using Slats.ViewModels;
using Slats.Models;
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


namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for CprPoolsPage.xaml
    /// </summary>
    public partial class CprPoolsPage : Page
    {
        public CprPoolsPage(CprPoolsVM viewmodel)
        {
            InitializeComponent();
            DataContext = viewmodel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewPool();
        }

        private void NewPool()
        {
     
        }
    }
}
