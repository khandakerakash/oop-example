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
            var iSDepartmentCodeExists = this.Departments.FirstOrDefault(x => x.GetCode() == department.GetCode());
            var iSDepartmentNameExists = this.Departments.FirstOrDefault(x => x.GetName() == department.GetName());

            if (iSDepartmentCodeExists != null || iSDepartmentNameExists != null)
            {
                var message = "Department ";
                if (iSDepartmentCodeExists != null)
                {
                    message += "code: " + $"{department.GetCode()}" + ", already exists.\n";
                }

                if (iSDepartmentNameExists != null)
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