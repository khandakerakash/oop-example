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

                Student akash = new Student("Khandaker Akash", "akash@gmial.com", "120");
                Student deb = new Student("Deb Biswas", "deb@gmial.com", "115");
                Student shadhon = new Student("Shadhon", "shadhon@gmial.com", "114");
                Student raju = new Student("Raju", "raju@gmial.com", "113");
                Student rafi = new Student("Rafi", "rafi@gmial.com", "112");
                

                // cse.CreateStudent(akash);
                // cse.CreateStudent(deb);
                // cse.CreateStudent(shadhon);
                // cse.CreateStudent(raju);
                // cse.CreateStudent(rafi);
                
                Console.WriteLine(cse.CreateStudent(akash));
                Console.WriteLine(cse.CreateStudent(deb));

                // cse.GetAllStudents();

                // cse.GetAStudent("akash@gmail.com");
                
                Console.WriteLine(cse.GetAStudent("akash@gmail.com"));
                
                Console.WriteLine(cse.GetAllStudents());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}