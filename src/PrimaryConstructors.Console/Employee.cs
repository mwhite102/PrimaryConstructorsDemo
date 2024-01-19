namespace PrimaryConstructorsConsole
{
    // Class deriving from Person
    public class Employee(string firstName, string lastName, string company, string department) 
        : Person(firstName, lastName)
    {
        public string Company { get; } = company;

        public string Department { get; } = department;

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} works for {this.Company} in {this.Department}";
        }
    }
}
