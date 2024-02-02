using System.Windows.Controls;

using CAN_software.ViewModels;

namespace CAN_software.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
