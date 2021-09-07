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

        public List<Student> GetAllStudents()
        {
            return this.Students.ToList();
        }

        public Student GetAStudent(string email)
        {
            var student = this.Students.FirstOrDefault(x => x.GetEmail() == email);

            if (student == null)
            {
                throw new Exception("No Data Found.");
            }
            return student;
        }

        public Student UpdateStudent(Student student, string email)
        {
            var result = new Student("", "", "");
            
            var studentInfo = this.Students.FirstOrDefault(x => x.GetEmail() == email);
            
            if (studentInfo == null)
            {
                throw new Exception("No Data Found.");
            }
            else
            {
                foreach (var aStudent in Students)
                {
                    if (email == student.GetEmail())
                    {
                        //aStudent.GetName() = student.SetName();

                        result = aStudent;
                    }
                }
 
            }
            
            return result;
        }

        public Student DeleteStudent(string email)
        {
            var student = this.Students.FirstOrDefault(x => x.GetEmail() == email);
            
            if (student == null)
            {
                throw new Exception("No Data Found.");
            }
            
            this.Students.Where(x => x.GetEmail() != email).ToList();
            return student;
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