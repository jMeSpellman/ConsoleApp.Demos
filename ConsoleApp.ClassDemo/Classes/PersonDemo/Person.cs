// See https://aka.ms/new-console-template for more information
// Define a Class
using System.Security.Cryptography;
namespace ConsoleApp.ClassDemo.Classes.PersonDemo;

public partial class Person
{
    // Create Alternative Constructor for Overloading
    public Person()
    {

    }

    public Person(string firstName, string lastName, string taxnumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxnumber;
    }

    // Propertie / Data Members
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Field member
    private string _taxNumber;
    protected string _idNumber = "N/A"; // Still a private string but it can be shared with classes that inherit the Person class

    // Method
    public void PrintFullName()
    {
        var type = GetType().Name;
        Console.WriteLine($"{type} name: {FirstName} {LastName}");
    }
    public void PrintInitials()
    {
        var type = GetType().Name;
        Console.WriteLine($"{type} intials: {FirstName[0]} {LastName[0]}");
    }

    public void GenerateTaxNumber() 
    { 
        if(string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = GetRandonNumber();
        }
        else
        {
            Console.WriteLine($"Tax number already exists for {FirstName} {LastName}");
        }
    }
    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    protected string GetRandonNumber()
    {
        return RandomNumberGenerator
                .GetInt32(100000, 9999999)
                .ToString();
    }
}
