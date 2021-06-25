using System.Windows.Controls;

using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for ServiceSettings.xaml
    /// </summary>
    public partial class ServiceSettings : Page
    {
        public ServiceSettings(ServiceSettingsVM viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
