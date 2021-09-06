namespace ArongShop
{
    public sealed class PermanentEmployee : Employee
    {
        private decimal MonthlySalary;

        public PermanentEmployee(string firstName, string lastName, string nidNumber, decimal monthlySalary) : base(firstName, lastName, nidNumber)
        {
            this.MonthlySalary = monthlySalary;
        }

        public override decimal GetlEarning()
        {
            return this.MonthlySalary;
        }
    }
}