using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace UniversityApplication
{
    public class Department
    {
        private string Code;
        private string Name;
        private List<Student> Students;

        public Department(string code, string name)
        {
            this.Code = code;
            this.Name = name;
            this.Students = new List<Student>();
        }

        public string GetCode()
        {
            return this.Code;
        }

        public string GetName()
        {
            return this.Name;
        }

        public bool CreateStudent(Student student)
        {
            ValidateStudent(student);
            this.Students.Add(student);
            return true;
        }

        private void ValidateStudent(Student student)
        {
            var isEmailExists = this.Students.FirstOrDefault(x => x.GetEmail() == student.GetEmail());

            if (isEmailExists != null)
            {
                throw new Exception("Student email: " + $"{student.GetEmail()}, is already exists.");
            }

            if (!IsValidEmail(student.GetEmail()))
            {
                throw new Exception("Invalid email address.");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}