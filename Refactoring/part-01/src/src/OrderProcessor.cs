
namespace src;
//  Is it better to apply singletone ??


public class OrderProcessor
{
    private readonly IOrderRepository _repo;
    private readonly IConfirmationSender _confirmation;

    public OrderProcessor(IOrderRepository repo, IConfirmationSender confirmation)
    {
        _repo = repo;
        _confirmation = confirmation;
    }

    public void Process(int orderId, string customerEmail)
    {
        _repo.Save(orderId, DateTime.Now);
        _confirmation.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}



public interface IConfirmationSender
{
    void Send(string to, string body);
}


public interface IOrderRepository
{
    void Save(int  orderId, DateTime date);
}




public class SqlOrderRepository : IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender : IConfirmationSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}