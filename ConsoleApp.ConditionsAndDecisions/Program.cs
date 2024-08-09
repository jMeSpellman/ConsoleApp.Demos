// See https://aka.ms/new-console-template for more information
// ConsoleApp.ConditionsAndDecisions

// Prompt for User Input
Console.Write("Please Enter students's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print Pass or Fail based on Input
Console.WriteLine("********** Simple IF Results **********");
if (grade > 50)
{
    Console.WriteLine("Student has Passed");
}
else
{
    Console.WriteLine("Student has Failed");
    Console.WriteLine("Please Refer student");

}
Console.WriteLine("********** Simple IF Results End **********");

// Complex If..Else If.. statement - decide to assess the grade value
Console.WriteLine("********** Complex IF..ELSE IF Results **********");

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid Entry!");
}
else if (grade  < 50)
{
    Console.WriteLine("Student has Failed: F");
}
else if (grade >= 50 && grade <=64)
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <=84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A");
}

Console.WriteLine("********** Complex IF..ELSE IF Results End **********");

Console.WriteLine("********** Ternary operators Result **********");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Status is: {passStatus}");
Console.WriteLine("********** Ternary operators Result End **********");

Console.WriteLine("********** Switch Statement Results **********");
/*

 * Write a program to accept an integer as the day of the week and print the appropriate
 * message as outliinted below
 1 - Sunday
 2 - Monday
 3 - Tuesday
 4 - Wednesday
 5 - Thursdate
 6 - Friday (TGIF!!)
 7 - Saturday (Beach Day!!!)

 */
Console.WriteLine("Enter a Day of the week (1 - 7): ");
int dayOftheWeek = Convert.ToInt32(Console.ReadLine());
string weekDay = "";

switch (dayOftheWeek)
{
    case 1:
        weekDay = "Sunday";
        break;
    case 2:
        weekDay = "Monday";
        break;
    case 3:
        weekDay = "Tuesday";
        break;
    case 4:
        weekDay = "Wednesday";
        break;
    case 5:
        weekDay = "Thursday";
        break;
    case 6:
        weekDay = "Friday";
        break;
    case 7:
        weekDay = "Saturday";
        break;
    default:
        weekDay = "Invalid Entry!";
        break;
}
Console.WriteLine($"{weekDay}");

Console.WriteLine("********** Switch Statement Results End **********");


// The remainder of the Application
Console.WriteLine("Thankyou for using this program");