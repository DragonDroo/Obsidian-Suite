using System.Configuration;
using System.Windows.Controls;
using System.Data.SqlClient;
using Slats.ViewModels;
using System.Collections.Generic;
using System.Windows.Data;

namespace Slats.Views
{
    public class StockItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool IsObsolete { get; set; }
    }
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;


            // ****************************** Formating Example
            //create business data
            var itemList = new List<StockItem>();
            itemList.Add(new StockItem { Name = "Many items", Quantity = 100, IsObsolete = false });
            itemList.Add(new StockItem { Name = "Enough items", Quantity = 10, IsObsolete = false });
            itemList.Add(new StockItem { Name = "Shortage item", Quantity = 1, IsObsolete = false });
            itemList.Add(new StockItem { Name = "Item with error", Quantity = -1, IsObsolete = false });
            itemList.Add(new StockItem { Name = "Obsolete item", Quantity = 200, IsObsolete = true });

            //link business data to CollectionViewSource
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("ItemCollectionViewSource"));
            itemCollectionViewSource.Source = itemList;
            // ****************************** Formating Example

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //   var con = ConfigurationManager.ConnectionStrings["Yourconnection"].ToString();
            string con = "Provider=MSOLAP.8;Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=OPES_Productivty_APP;Data Source=vhacdwmdm02.vha.med.va.gov;MDX Compatibility=1;Safety Options=2;MDX Missing Member Mode=Error;Update Isolation Level=2";

            ////Person matchingPerson = new Person();
            //using (var myConnection = new SqlConnection(con))
            //{
            //    string oString = "Select * from Employees where FirstName=@fName";
            //    SqlCommand oCmd = new SqlCommand(oString, myConnection);
            //    oCmd.Parameters.AddWithValue("@Fname", fName);
            //    myConnection.Open();
            //    using (SqlDataReader oReader = oCmd.ExecuteReader())
            //    {
            //        while (oReader.Read())
            //        {
            //            matchingPerson.firstName = oReader["FirstName"].ToString();
            //            matchingPerson.lastName = oReader["LastName"].ToString();
            //        }

            //        myConnection.Close();
            //    }
            //}
        }
    }
}
