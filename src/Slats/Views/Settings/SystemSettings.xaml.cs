using System.Windows.Controls;

using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for SystemSettings.xaml
    /// </summary>
    public partial class SystemSettings : Page
    {
        public SystemSettings(SystemSettingsVM viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
