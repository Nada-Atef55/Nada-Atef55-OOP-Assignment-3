
namespace src;

public class NotificationService
{
    private readonly INotifier _notification;

    public NotificationService(INotifier notification)
    {
        _notification = notification;
    }

    public void Send(string to, string message) => _notification.Send(to, message);
}

public interface INotifier
{
    void Send(string to, string message);
}

public class UrgentNotificationService 
{
    public readonly INotifier _notification;

    public UrgentNotificationService(INotifier notification)
    {
        _notification = notification;
    }

    public void Send(string to, string message) =>
        _notification.Send(to, $"[URGENT] {message}");
}



public class UrgentScheduledNotificationService 
{
    public readonly INotifier _notification;
    public UrgentScheduledNotificationService(DateTime sendAt, INotifier notification)
    {
        SendAt = sendAt;
        _notification = notification;
    }

    public DateTime SendAt { get; }

    public void Send(string to, string message)
        => _notification.Send($"[scheduled {SendAt:g}] {to}", $"[URGENT] {message}");
        
}






public class EmailNotification : INotifier
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}


public class SmsNotification : INotifier
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}


public class WhatsAppNotification : INotifier
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[whatsapp] {to}: {message}");
}







