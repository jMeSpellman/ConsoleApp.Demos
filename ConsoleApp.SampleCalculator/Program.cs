// See https://aka.ms/new-console-template for more information

// Welcome Message   
Console.WriteLine("Welcome to the Sample Calculator");

// Prompt the user for Input
Console.WriteLine("Please Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show Calcultator Options
Console.WriteLine("Please Select One of the Following:");
Console.WriteLine(" + (Addition)");
Console.WriteLine(" - (Subtraction)");
Console.WriteLine(" * (Mulitplication)");
Console.WriteLine(" / (Division)");
Console.WriteLine(" % (Modulus)");

string? selection = Console.ReadLine();
int result = 0;
Boolean isValid = true;

// Decide which opertion is needed based on selection
switch (selection)
{
    case "+":
        result = num1 + num2; break;
    case "-":
        result = num1 - num2; break;
    case "*":
        result = num1 * num2; break;
    case "/":
        result = num1 / num2; break;
    case "%":
        result = num1 % num2; break;
    default:
        isValid = false; 
        break;
}

// Print Ouput
if (isValid)
{
    Console.WriteLine($"Result: {result}");
}
else
{
    Console.WriteLine($"Invalid Selection: {selection}");
}
