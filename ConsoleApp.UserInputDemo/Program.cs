// Declare Variables

using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;

int age = 0;
int retirementAge = 67;


// Prompt the user for input
Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();

lastName = Console.ReadLine();
Console.WriteLine("Please enter last your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working Years remaining: {workingYearsRemaining}");

