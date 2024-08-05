// Declare Variables

string name = string.Empty;
int age = 0;
int retirementAge = 67;


// Prompt the user for input
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();
Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working Years remaining: {workingYearsRemaining}");

