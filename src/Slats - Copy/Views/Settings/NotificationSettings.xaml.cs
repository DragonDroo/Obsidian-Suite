using System.Windows.Controls;

using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for NotificationSettings.xaml
    /// </summary>
    public partial class NotificationSettings : Page
    {
        public NotificationSettings(NotificationSettingsVM viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
