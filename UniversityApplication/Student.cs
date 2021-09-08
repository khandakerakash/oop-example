using System;
using System.Collections.Generic;

namespace UniversityApplication
{
    public class Student
    {
        private string Name;
        private string Email;
        private string RollNo;

        public Student(string name, string email, string rollNo)
        {
            validateStudent(name, email);
            this.Name = name;
            this.Email = email;
            this.RollNo = GetRollNo();
        }

        private string GetRollNo()
        {
            var random = new Random();
            var rollList = new List<int>();

            for (int i = 0; i <= 5; i++)
            {
                rollList.Add(random.Next(10));
            }

            return rollList.ToString();
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public string Update(string name,string email)
        {
            return this.Name = Name;
        }
        
        public string GetName()
        {
            return this.Name;
        }

        private void validateStudent(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw  new Exception("Student Name cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw  new Exception("Student email cannot be empty");
            }
        }
    }
}