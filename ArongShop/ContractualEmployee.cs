namespace ArongShop
{
    public sealed class ContractualEmployee : Employee
    {
        private decimal SaleAmount;
        private decimal Commission;

        public ContractualEmployee(string firstName, string lastName, string nidNumber, decimal saleAmount, decimal commission) : base(firstName, lastName, nidNumber)
        {
            this.SaleAmount = saleAmount;
            this.Commission = commission;
        }

        public override decimal GetlEarning()
        {
            return (this.SaleAmount * this.Commission) / 100;
        }
    }
}