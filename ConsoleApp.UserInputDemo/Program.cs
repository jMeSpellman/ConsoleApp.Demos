// Variable Declarations and Types

using System.Globalization;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Xml.Serialization;

//const int retirementAge = 67;
char choice = char.MinValue;
string? firstName = string.Empty;
string lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool working = true;

List<Person> persons = new List<Person>();

while (choice != 'E')
{
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

    Person person = new(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        //DateOfBirth = dob,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };

    persons.Add(person);
    //persons.Add(new Person(dob)
    //{
    //    FirstName = firstName,
    //    LastName = lastName,
    //    Gender = gender,
    //    IsWorking = working,
    //    Salary = salary
    //});
    Console.WriteLine("C - Continue | E - Exit");
    choice = Convert.ToChar(Console.ReadLine());
}

foreach (var person in persons)
{
    // Output the results to the user
    Console.WriteLine();
    Console.WriteLine($"Full name: {person.ToString()}");
    Console.WriteLine($"Age: {person.GetAge}");
    Console.WriteLine($"Your Salary is: {person.Salary.ToString("C")}");
    Console.WriteLine($"Your Gender is: {person.Gender}");
    Console.WriteLine($"Your are Employed: {person.IsWorking}");
    Console.WriteLine($"Number Of Working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"Estimated Retirment Year: { person.GetEstimatedRetirementDate()}");
}



