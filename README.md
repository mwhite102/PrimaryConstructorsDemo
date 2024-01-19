# Primary Constructors in C# 12

Taking a look at Primary Constructors in C# 12.

## Prerequisites

* .NET 8
* C# 12

## Records in C# 9

The syntax of Primary Constructors was first introduced with Records in C# 9 and make defining reference types convenient and conscise.

* Records are immutable.  Making them great choices for Data Transfer Objects (DTOs)
* Value-based equality.  Compared by their values, not references like objects
* The compiler generates the boilerplate code for ```ToString```, ```Equals```, and ```GetHashCode``` so you don't have to
* For inheritance, records can inherit from other records

Simple ```record``` example

```csharp
// reference type record declaration
public record Person(string FirstName, string LastName);
```

## Records Extended in C# 10

C# 10 introduced for value types.

* Declared using ```record struct``` to distinquish them from reference type records
* Stored directly on the stack instead of the heap
	* Can be more efficient by avoiding heap allocation
	* Potential boxing/unboxing overhead, though
* Mutable by default unless declared as ```readonly```
* Value-based equality 

Simple ```record struct``` example

```csharp
// value type struct
public readonly Point(double X, double Y, double Z);
```

## Primary Constructors Introduced in C# 12

Now in C# 12, primary constructors and like [tribbles](https://en.wikipedia.org/wiki/Tribble). They're everywhere!

You can now uses the record style primary constructors for classes and structs.

There are some rules surrounding the paramters passed to primary constructors:

* The paramters may not be stored in the class or struct if they are not needed
* They are not members of the class by default like records
* They are not immutable.  They can be assigned to 

Here is a quick example:

```csharp
// A class with a primary constructor
public class Person(string firstName, string lastName)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
}

// Instantiate a person
Person personA = new Person("John", "Doe");
```

Deriving a class from the Person base class using primary constructors:

```csharp
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
```

It's worth noting that a derived class doesn't have to use a primary constructor:

```csharp
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
}

public override string ToString()
{
    return $"Customer {base.ToString()} has account number {this.AccountNumber}";
}
```

## More information on primary constructors in C# 12

[https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors)
