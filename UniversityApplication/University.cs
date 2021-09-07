using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityApplication
{
    public class University
    {
        private string Name;
        private List<Department> Departments;
        
        public University(string name)
        {
            this.Name = name;
            this.Departments = new List<Department>();
        }
        
        public string GetName()
        {
            return "University Name: " + this.Name;
        }

        public bool CreateDepartment(Department department)
        {
            ValidateDepartment(department);
            this.Departments.Add(department);
            return true;
        }

        private void ValidateDepartment(Department department)
        {
            var iSCodeExists = this.Departments.FirstOrDefault(x => x.GetCode() == department.GetCode());
            var iSNameExists = this.Departments.FirstOrDefault(x => x.GetName() == department.GetName());

            if (iSCodeExists != null || iSNameExists != null)
            {
                var message = "Department ";
                if (iSCodeExists != null)
                {
                    message += "code: " + $"{department.GetCode()}" + ", already exists.\n";
                }

                if (iSNameExists != null)
                {
                    message += "name: " + $"{department.GetName()}" + ", already exists.\n";
                }

                throw new Exception(message);
            }

            if (this.Departments.Count >= 5)
            {
                throw new Exception("Create more than 5 departments are not allowed in " + $"{this.Name}.");
            }
        }
    }
}