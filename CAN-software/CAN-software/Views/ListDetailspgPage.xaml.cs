using System.Windows.Controls;

using CAN_software.ViewModels;

namespace CAN_software.Views;

public partial class ListDetailspgPage : Page
{
    public ListDetailspgPage(ListDetailspgViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
