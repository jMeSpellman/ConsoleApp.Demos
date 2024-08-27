// Variable Declarations and Types

using System.Globalization;
using System.Net.Http.Headers;
using System.Xml.Linq;

const int retirementAge = 67;

string? firstName = string.Empty;
string lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool working = true;


// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your D.O.B (dd/mm/yyyy): ");
// age = Convert.ToInt32(Console.ReadLine());
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;

Console.Write("Please enter last your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter  your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process data
int workingYearsRemaining = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary.ToString("C")}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"Your are Employed: {working}");
Console.WriteLine($"Number of Working Years remaining: {workingYearsRemaining}");
Console.WriteLine($"Estimated Retirement Year: {estimatedRetirementDate.Year}");

