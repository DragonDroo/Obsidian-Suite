using Slats.ViewModels;
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
    /// Interaction logic for Privileges.xaml
    /// </summary>
    public partial class Privileges : Page
    {
        public CollectionView view;
        public PropertyGroupDescription groupDescription;
        public List<EmployeeX> items;
        public Privileges(PrivilegesVM viewmodel)
        {
            InitializeComponent();
            DataContext = viewmodel;

            items = new List<EmployeeX>();
            items.Add(new EmployeeX() { Name = "Ram Charan", Age = 33, Email = "r.charan@gmail.com", dept = DepartmentX.Accounting, alt=Alternate.CharlotteCBOC });
            items.Add(new EmployeeX() { Name = "Raju Rastogi", Age = 22, Email = "e.rastogi@gmail.com", dept = DepartmentX.Management, alt=Alternate.CharlotteHCC});
            items.Add(new EmployeeX() { Name = "Dilip Bhatt", Age = 35, Email = "d.bhatt@gmail.com", dept = DepartmentX.Economics, alt=Alternate.CharlotteHCC});
            items.Add(new EmployeeX() { Name = "Dipesh Patil", Age = 33, Email = "d.patil@gmail.com", dept = DepartmentX.Accounting, alt=Alternate.Kernersville });
            items.Add(new EmployeeX() { Name = "Ronak Sharma", Age = 39, Email = "r.sharma@gmail.com", dept = DepartmentX.Finance, alt = Alternate.Kernersville });
            items.Add(new EmployeeX() { Name = "Punit Shah", Age = 43, Email = "p.shah@gmail.com", dept = DepartmentX.Economics, alt = Alternate.Kernersville });
            items.Add(new EmployeeX() { Name = "Haresh Shukla", Age = 25, Email = "h.shukla@gmail.com", dept = DepartmentX.Management, alt = Alternate.CharlotteCBOC });
            items.Add(new EmployeeX() { Name = "John Cena", Age = 32, Email = "j.cena@gmail.com", dept = DepartmentX.Accounting, alt = Alternate.CharlotteCBOC });
            items.Add(new EmployeeX() { Name = "Govind Patil", Age = 41, Email = "g.patil@gmail.com", dept = DepartmentX.Marketing, alt = Alternate.CharlotteHCC });

            lvEmps.ItemsSource = items;
            view = (CollectionView)CollectionViewSource.GetDefaultView(lvEmps.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("dept");
            view.GroupDescriptions.Add(groupDescription);
        }

        private void lvEmps_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(e.OriginalSource.GetType().ToString());
           if (e.OriginalSource.GetType().ToString() != "System.Windows.Controls.GridViewColumnHeader")
            {
                return;

            }
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            if (headerClicked.Column.Header == null)
            {
                return;
            }
            string caseit = headerClicked.Column.Header as string;

            //if (caseit != "Dept" && caseit != "Alt") { return;  }
            view.GroupDescriptions.Clear();
            lvEmps.ItemsSource = items;
            view = (CollectionView)CollectionViewSource.GetDefaultView(lvEmps.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription(headerClicked.Column.Header as string);
            view.GroupDescriptions.Add(groupDescription);

            //if (caseit == "Age")
            //{
            //    lvEmps.ItemsSource = items;
            //    view = (CollectionView)CollectionViewSource.GetDefaultView(lvEmps.ItemsSource);
            //    PropertyGroupDescription groupDescription = new PropertyGroupDescription("dept");
            //    view.GroupDescriptions.Add(groupDescription);
            //}
            //if (caseit == "Age")
            //{
            //    //PropertyGroupDescription propertyGroupDescription = new PropertyGroupDescription("dept");
            //    PropertyGroupDescription groupDescription = propertyGroupDescription;
            //    view.GroupDescriptions.Add(groupDescription);
            //}
            //PropertyGroupDescription groupDescription = new PropertyGroupDescription("dept");
            //view.GroupDescriptions.Add(groupDescription);
          //  MessageBox.Show(headerClicked.Column.Header as string);
        }
    }
}
