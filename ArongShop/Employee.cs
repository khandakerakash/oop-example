namespace ArongShop
{
    public  abstract class Employee
    {
        private string FirstName;
        private string LastName;
        private string NidNumber;

        protected Employee(string firstName, string lastName, string nidNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            NidNumber = nidNumber;
        }

        protected string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public abstract decimal GetlEarning();
        
        public string GetFullInformation()
        {
            return "Employee Full Name Is: " + this.GetFullName() + "\nNational Identity Number Is: " + this.NidNumber + "\nAnd His/Her Total Earn is: " + this.GetlEarning();
        }
    }
}