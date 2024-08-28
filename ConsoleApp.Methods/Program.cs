// See https://aka.ms/new-console-template for more information
Console.WriteLine("********* - Methods - *********");

// void methods - complete a task without returning a value
//void PrintName()
//{
//    // Method
//    Console.WriteLine("Hola!");
//}

//// value returning methods - returns a value after an operation
//int GetFiveYearsAgo()
//{
//    int year = DateTime.Now.AddYears(-5).Year;
//    return year;

//    // Alternative
//    // return DateTime.Now.AddYears(-5).Year;
//}

//// methods with parameters
//void PrintNameWithParams(string name)
//{
//    // Method
//    Console.WriteLine("Your name is: " + name);
//}
//int GetYearDifferenceWithParams(int year)
//{
//    int yearDiff = DateTime.Now.Year - year;
//    return yearDiff;
//}

//// methods with optional parameters... also has a default value
//int GetFutureOrPastYear(int numberOfYears = 0)
//{
//    var year = DateTime.Now.AddYears(numberOfYears).Year;
//    return year;
//}
// methods with nullable parameters
void PrintNameNullableParams(string? name, int? count)
{
    // Standard Method
    //if (string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}
    //if (!count.HasValue)
    //{
    //    count = 1;
    //}

    // Alternative method
    // The null-coalescing assignment operator ??= assigns the value of it right-hand
    // operand to its left-hand operand if the left-hand operand evaluates to null.

    name ??= "Default Name";
    count ??= 1;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}


/* Function Calls */
//PrintName();
//int fiveYearsAgo = GetFiveYearsAgo();
//Console.WriteLine($"Five years ago was: {fiveYearsAgo}");

//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();
//PrintNameWithParams(name);

//Console.WriteLine("Enter a Year");
//int pastYear = Convert.ToInt32(Console.ReadLine());
//int yearsAgo = GetYearDifferenceWithParams(pastYear);
//Console.WriteLine($"This was: {yearsAgo} years ago");

//Console.WriteLine("Enter number of years in the future or past");
//int numberOfYears = Convert.ToInt32(Console.ReadLine());
//var pastYear1 = GetFutureOrPastYear();
//Console.WriteLine($"The year is: {pastYear1}");

//var pastYear2 = GetFutureOrPastYear(numberOfYears);
//Console.WriteLine($"The year is: {pastYear2}");

PrintNameNullableParams(null, null);
PrintNameNullableParams("Chester", 5);
