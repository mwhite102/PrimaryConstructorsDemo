namespace PrimaryConstructorsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a Person
            Person personA = new Person("John", "Doe");

            // Write personA to the console
            Console.WriteLine($"Created {nameof(personA)} {personA.ToString()}");

            // Create an Employee
            Employee employeeA = new Employee("Jane", "Doe", "Acme", "Sales");

            // Write employeeA to the console
            Console.WriteLine($"Created {nameof(employeeA)} {employeeA.ToString()}");

            // Create a Customer
            Customer customerA = new Customer("Peter", "Pan", Guid.NewGuid().ToString());

            // Write customerA to the console
            Console.WriteLine($"Created {nameof(customerA)} {customerA.ToString()}");
        }
    }
}
