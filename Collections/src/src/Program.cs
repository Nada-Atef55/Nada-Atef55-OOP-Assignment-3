namespace src;

internal class Program
{
    static void Main(string[] args)
    {
        string[] PnoneNumbers = { "01012345678", "+201512345678", "01312345678", "0101234567", "0101234567a" };
        Console.WriteLine("Validate phone number :");

        foreach (var phone in PnoneNumbers)
        {
            Console.WriteLine($"{phone} => {phone.IsValidEgyptianPhone()}");
        }


        Console.WriteLine("\n================================================\n");
        Console.WriteLine("Validate National Id :");
        string[] IDs = { "29901011234567", "19901011234567", "2990101123456" };
        foreach (var id in IDs)
        {
            Console.WriteLine($"{id} => {id.IsValidEgyptianNationalId}");
        }
    }
}
