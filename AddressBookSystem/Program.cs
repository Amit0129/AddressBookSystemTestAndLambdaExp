namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook records = new AddressBook();
            bool check = true;
            while (check)
            {
                Console.WriteLine("\n\nWelcome to Address Book System");
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nEnter your choice : ");

                int ch = Convert.ToInt32(Console.ReadLine()); 
                switch (ch)
                {
                    case 1:
                        records.AddRecords(); 
                        records.PrintRecords(); 
                        break;
                    case 2:
                        Console.WriteLine("Enter your First Name : ");
                        string fn = Console.ReadLine(); 
                        Console.WriteLine("Enter your Last Name : ");
                        string ln = Console.ReadLine();
                        records.UpdateRecords(fn, ln); 
                        records.PrintRecords(); 
                        break;
                    case 4:
                        check=false; 
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}