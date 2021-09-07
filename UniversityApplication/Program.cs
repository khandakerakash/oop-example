using System;

namespace UniversityApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            
            // For Department
            try
            {
                University university = new University("Dhaka City College");
                Console.WriteLine(university.GetName());

                Department cse = new Department("CSE", "Computer Science And Engineering");
                Department bba = new Department("BBA", "Bachelor of Business Administration");
                Department math = new Department("Math", "Mathematics");

                university.CreateDepartment(cse);
                university.CreateDepartment(bba);
                university.CreateDepartment(math);
                
                // Console.WriteLine(university.CreateDepartment(cse));
                // Console.WriteLine(university.CreateDepartment(bba));
                // Console.WriteLine(university.CreateDepartment(math));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            //Console.ReadKey();
        }
    }
}