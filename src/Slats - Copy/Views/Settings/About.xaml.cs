using System.Windows.Controls;

using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About(AboutVM viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
