using CAN_software.Contracts.ViewModels;
using CAN_software.Core.Contracts.Services;
using CAN_software.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CAN_software.ViewModels;

public class ContentGridpgDetailViewModel : ObservableObject, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;
    private SampleOrder _item;

    public SampleOrder Item
    {
        get { return _item; }
        set { SetProperty(ref _item, value); }
    }

    public ContentGridpgDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
