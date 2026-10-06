using Refactoring.Part02.Enrollment;
using Refactoring.Part02.Reports;

namespace Refactoring.Part02;

internal class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("=== Reports ===");

        var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
        Directory.CreateDirectory(outDir);
        
        new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
        new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
        new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
        Console.WriteLine($"Wrote reports to {outDir}");
        Console.WriteLine();




        Console.WriteLine("=== Enrollment ===");

        var studentId = "S100";
        var courseId = "CS201";
        var amount = 1500m;

        var payment = new PaymentGateway();
        var seats = new SeatInventory();
        var invoices = new InvoiceGenerator();
        var email = new EmailService();

        var enrollmentFacade = new EnrollmentFacade(payment, seats, invoices, email);
        enrollmentFacade.Enroll(studentId, courseId, amount);
    }
}
