using System.Windows.Controls;

using CAN_software.ViewModels;

namespace CAN_software.Views;

public partial class ContentGridpgPage : Page
{
    public ContentGridpgPage(ContentGridpgViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
