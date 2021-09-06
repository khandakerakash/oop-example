using System.Collections.Generic;
using System.Linq;

namespace NationalUniversity
{
    public abstract class University
    {
        private string DepartmentCode;
        private string DepartmentName;

        protected University(string departmentCode, string departmentName)
        {
            DepartmentCode = departmentCode;
            DepartmentName = departmentName;
        }
        
        // public string CreateDepartment()
        // {
        //     return DepartmentStatic.InsertDepartment(department);
        // }
        
        public static class DepartmentStatic
        {
            private static List<University> AllDepartment { get; set; } = new List<University>();

            public static University InsertDepartment(University department)
            {
                AllDepartment.Add(department);
                return department;
            }

            public static List<University> GetAllDepartment()
            {
                return AllDepartment;
            }
        }
    }
}