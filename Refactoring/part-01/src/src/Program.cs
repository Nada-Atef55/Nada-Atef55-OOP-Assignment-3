namespace src;

internal class Program
{
    static void Main(string[] args)
    {
        var shippingWithAramex = new ShippingCostService(new Aramex());
        var shippingWithFedx = new ShippingCostService(new FedEx());
        var shippingWithBosta = new ShippingCostService(new Bosta());


        Console.WriteLine($"Aramex 2kg -> {shippingWithAramex.CalculateCost(2)}");
        Console.WriteLine($"FedEx 2kg  -> {shippingWithFedx.CalculateCost(2)}");
        Console.WriteLine($"Bosta 2kg  -> {shippingWithBosta.CalculateCost(2)}");
        Console.WriteLine();


        var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
        processor.Process(1001, "customer@example.com");
        Console.WriteLine();


        new UrgentScheduledNotificationService(DateTime.Today.AddHours(18), new EmailNotification())
            .Send("customer@example.com", "Your order ships tomorrow");
        new UrgentNotificationService(new SmsNotification())
            .Send("+201000000000", "OTP 4821");


    }
}
