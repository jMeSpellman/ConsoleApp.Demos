// See https://aka.ms/new-console-template for more information

//Simple For Loop Demo
// Print Hello World 10 times

/*
Console.WriteLine("********** Simple For Loop **********");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello World! [{i}]");
}

// Ask User how many time they wish to Print Hello World and Print accordingly
Console.WriteLine("How many times do you want to Print 'Hello World'");
int copies = Convert.ToInt32(Console.ReadLine());

for (int i = 1; (i <= copies); i++)
{
    Console.WriteLine($"Hello World! [{i}]");
}

Console.WriteLine("********** Simple For Loop End **********");
*/

Console.WriteLine("********** While Loop **********");

int num = 0;
int total = 0;
while(num != -1)
{
    Console.WriteLine("Please enter a number to be summed (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    if(num != -1){ total += num; }
}

Console.WriteLine($"You sum is: {total}");

Console.WriteLine("********** While Loop End **********");

Console.WriteLine("********** Do While Loop **********");

num = 0;
total = 0;
do
{
    Console.WriteLine("Please enter a number to be summed (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num != -1) { total += num; }

} while (num != -1);

Console.WriteLine($"You sum is: {total}");

Console.WriteLine("********** Do While Loop End **********");
