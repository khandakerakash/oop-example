namespace UniversityApplication
{
    public class Student
    {
        private string Name;
        private string Email;
        private string RollNo;

        public Student(string name, string email, string rollNo)
        {
            this.Name = name;
            this.Email = email;
            this.RollNo = rollNo;
        }

        public string GetEmail()
        {
            return this.Email;
        }
    }
}