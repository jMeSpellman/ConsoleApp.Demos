// See https://aka.ms/new-console-template for more information

// Welcome Message   
Console.WriteLine("********** Welcome to the Sample Calculator **********");

int choice = 0;

    // Show caluclator options /Show menu
    Console.WriteLine("Please select an Operation: (-1 to exit)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci Sequence");

    choice = Convert.ToInt32(Console.ReadLine());


while (choice != -1)
{ 
    // Prompt the user for Input
    Console.WriteLine("Please Enter the first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please Enter the second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Boolean isValid = true;
    int answer = 0;
    switch (choice)
    {
        case 1:
            answer = (num1 + num2);
            break;
        case 2:
            answer = (num1 - num2);
            break;
        case 3:
            answer = (num1 * num2);
            break;
        case 4:
            answer = (num1 / num2);
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            
            isValid = false;
            break;
    }

    if (isValid)
    {
        Console.WriteLine($"Result is: {answer}");
        Console.WriteLine();
        Console.WriteLine("Please press [ENTER] to continue");
        Console.ReadLine();
        Console.Clear();

        // Show caluclator options /Show menu
        Console.WriteLine("Please select an Operation: (-1 to exit)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci Sequence");

        choice = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        choice = -1;
        Console.WriteLine($"Invalid Operation");
    }
}

Console.WriteLine("********** Thank you for using the Sample Calculator **********");
