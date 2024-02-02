using System.Windows.Controls;

using CAN_software.ViewModels;

namespace CAN_software.Views;

public partial class DisplayCanGridPgPage : Page
{
    public DisplayCanGridPgPage(DisplayCanGridPgViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
