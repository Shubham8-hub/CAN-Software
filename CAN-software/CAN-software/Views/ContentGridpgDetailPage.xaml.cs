using System.Windows.Controls;

using CAN_software.ViewModels;

namespace CAN_software.Views;

public partial class ContentGridpgDetailPage : Page
{
    public ContentGridpgDetailPage(ContentGridpgDetailViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
