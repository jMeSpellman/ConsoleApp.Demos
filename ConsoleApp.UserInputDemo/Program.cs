// Declare Variables

using System.Xml.Linq;

string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 67;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;


// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter last your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter  your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"Your are Employed: {working}");
Console.WriteLine($"Number of Working Years remaining: {workingYearsRemaining}");
