// See https://aka.ms/new-console-template for more information

using System;

Console.Write("Please enter the first number: ");
int  num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/* 
    Math Operations and operators
 */

// Add numbers
int  sum = num1 + num2;
// multiply
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;
Console.WriteLine("************* Math Results *************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("************* End Math Results *************");


/*
    Logic Operations and Operators
 */
Console.WriteLine("************* Logic Results *************");

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1>=num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal To: {isNotEqualTo}");
Console.WriteLine();
Console.WriteLine("************* End Logic Results *************");

/*
    Assignment Operations and Operators
 */

Console.Write("Please enter a third number for Assigment Operations: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************* Assignment Results *************");
Console.WriteLine();
Console.WriteLine($"Num 1 at Start of Assignment Operations: {num1}");
num1 += num3;
Console.WriteLine($"Num 1 increased by {num3}: {num1}");
num1 -= num3;
Console.WriteLine($"Num 1 decreased by {num3}: {num1}");
num1 /= num3;
Console.WriteLine($"Num 1 divided by {num3}: {num1}");
num1 %= num3;
Console.WriteLine($"Num 1 modulus by {num3}: {num1}");
num1 *= num3;
Console.WriteLine($"Num 1 multiplied by {num3}: {num1}");
Console.WriteLine();
Console.WriteLine("************* End Assignment Results *************");