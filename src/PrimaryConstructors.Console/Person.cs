namespace PrimaryConstructorsConsole
{
    // A class with a primary constructor
    public class Person(string firstName, string lastName)
    {
        public string FirstName { get; } = firstName;
        public string LastName { get; } = lastName;

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
    

