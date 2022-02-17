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
using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for MeetingAttendStaffPage.xaml
    /// </summary>
    public partial class MeetingAttendStaffPage : Page
    {
        public MeetingAttendStaffPage(MeetingAttendStaffVM viewmodel)
        {
            InitializeComponent();
            DataContext = viewmodel;

            List<UserX> items = new List<UserX>();
            items.Add(new UserX() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new UserX() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new UserX() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });
            lvDataBinding.ItemsSource = items;
        }
    }
}
