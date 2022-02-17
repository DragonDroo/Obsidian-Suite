using System.Windows.Controls;

using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for StaffListSupervisorPage.xaml
    /// </summary>
    public partial class StaffListSupervisorPage : Page
    {
        public StaffListSupervisorPage(StaffListSupervisorVM viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
