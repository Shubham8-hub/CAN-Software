using System.Windows.Controls;

using CAN_software.ViewModels;

namespace CAN_software.Views;

public partial class HomeRibbonpgPage : Page
{
    public HomeRibbonpgPage(HomeRibbonpgViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
