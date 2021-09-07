using System.Collections.Generic;

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
    }
}