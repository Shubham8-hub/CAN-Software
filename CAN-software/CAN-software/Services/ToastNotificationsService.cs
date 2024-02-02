using CAN_software.Contracts.Services;

using CommunityToolkit.WinUI.Notifications;

using Windows.UI.Notifications;

namespace CAN_software.Services;

public partial class ToastNotificationsService : IToastNotificationsService
{
    public ToastNotificationsService()
    {
    }

    public void ShowToastNotification(ToastNotification toastNotification)
    {
        ToastNotificationManagerCompat.CreateToastNotifier().Show(toastNotification);
    }
}
