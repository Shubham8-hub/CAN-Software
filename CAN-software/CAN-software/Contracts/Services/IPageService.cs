using System.Windows.Controls;

namespace CAN_software.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
