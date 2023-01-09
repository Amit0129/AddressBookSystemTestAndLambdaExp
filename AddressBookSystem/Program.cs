namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            addressBookBuilder.Operations();
        }
    }
}