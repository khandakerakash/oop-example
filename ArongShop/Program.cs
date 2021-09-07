using System;

namespace ArongShop
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee("Khandaker", "Akash", "19919312323000145", 8500);
            Console.WriteLine(permanentEmployee.GetFullInformation());

            ContractualEmployee contractualEmployee = new ContractualEmployee("Mr.", "Deb", "1999123456789", 500000, 5);
            Console.WriteLine(contractualEmployee.GetFullInformation());
        }
    }
}
