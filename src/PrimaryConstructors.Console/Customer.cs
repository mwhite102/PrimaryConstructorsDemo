namespace PrimaryConstructorsConsole
{
    /// <summary>
    /// A class that derives from a class that has a primary constructor, 
    /// but uses a traditional constructor
    /// </summary>
    public class Customer : Person
    {
        public Customer(string firstName, string lastName, string accountNumber) 
            : base(firstName, lastName)
        {
            AccountNumber = accountNumber;
        }

        public string AccountNumber { get; }

        public override string ToString()
        {
            return $"Customer {base.ToString()} has account number {this.AccountNumber}";
        }
    }
}
