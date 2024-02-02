using System.Collections.ObjectModel;
using System.Windows.Input;

using CAN_software.Contracts.Services;
using CAN_software.Contracts.ViewModels;
using CAN_software.Core.Contracts.Services;
using CAN_software.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CAN_software.ViewModels;

public class ContentGridpgViewModel : ObservableObject, INavigationAware
{
    private readonly INavigationService _navigationService;
    private readonly ISampleDataService _sampleDataService;
    private ICommand _navigateToDetailCommand;

    public ICommand NavigateToDetailCommand => _navigateToDetailCommand ?? (_navigateToDetailCommand = new RelayCommand<SampleOrder>(NavigateToDetail));

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public ContentGridpgViewModel(ISampleDataService sampleDataService, INavigationService navigationService)
    {
        _sampleDataService = sampleDataService;
        _navigationService = navigationService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // Replace this with your actual data
        var data = await _sampleDataService.GetContentGridDataAsync();
        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    private void NavigateToDetail(SampleOrder order)
    {
        _navigationService.NavigateTo(typeof(ContentGridpgDetailViewModel).FullName, order.OrderID);
    }
}
