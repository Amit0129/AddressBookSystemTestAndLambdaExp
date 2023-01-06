namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook records = new AddressBook();
            Console.WriteLine("1. Add a new Record");
            Console.WriteLine("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    records.AddRecords();
                    records.PrintRecords();
                    Console.ReadLine();
                    break;
            }
        }
    }
}