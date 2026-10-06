

namespace Refactoring.Part02.Enrollment;

public class EnrollmentFacade
{
    private readonly PaymentGateway _paymentGateway;
    private readonly SeatInventory _seatInventory;
    private readonly InvoiceGenerator _invoiceGenerator;
    private readonly EmailService _emailService;

    public EnrollmentFacade(PaymentGateway paymentGateway, SeatInventory seatInventory,
        InvoiceGenerator invoiceGenerator, EmailService emailService)
    {
        _paymentGateway = paymentGateway;
        _seatInventory = seatInventory;
        _invoiceGenerator = invoiceGenerator;
        _emailService = emailService;
    }

    public void Enroll(string studentId, string courseId, decimal amount)
    {
        _paymentGateway.Charge(studentId, amount);
        _seatInventory.Reserve(courseId, studentId);
        var invoiceId = _invoiceGenerator.Create(studentId, amount);
        _emailService.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
    }
}
