namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Welcome to Address Book System");
            ContactsRecord record = new ContactsRecord();
            record.Input();
        }
    }
}