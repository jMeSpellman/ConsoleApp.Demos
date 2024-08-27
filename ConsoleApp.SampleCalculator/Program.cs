// See https://aka.ms/new-console-template for more information

int choice = 0;
int num1, num2 = 0;
while (choice != -1)
{
    try
    {
        Console.Clear();
        // Welcome Message   
        Console.WriteLine("********** Welcome to the Sample Calculator **********");

        // Show caluclator options /Show menu
        Console.WriteLine("Please select an Operation: (-1 to exit)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci Sequence");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.WriteLine("Please Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());
       
        // Prompt the user for Input
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

                throw new Exception("Invalid Menu Item Selected");
        }

        // Printout Result
        Console.WriteLine($"Result is: {answer}");
        Console.WriteLine();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot Divide By Zero!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Please press [ENTER] to continue");
        Console.ReadLine();
        Console.Clear();
    }

}

Console.WriteLine("********** Thank you for using the Sample Calculator **********");
