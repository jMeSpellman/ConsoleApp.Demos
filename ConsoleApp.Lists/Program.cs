// See https://aka.ms/new-console-template for more information
Console.WriteLine("********* - Lists - *********");

// Declare a List
List<int> grades = new List<int>();
List<string> students = new List<string>();

int grade = 0;
string name = string.Empty;
int gradeCount =0;
int @continue;


// Alternative methods of declaring a List
// var grades = new List<int>();
// List<int> grades = new();

// Add Values to List
    //grades.Add(45);
    //grades.Add(95);
do
{
    gradeCount += 1;
    Console.Write("Enter Student Name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter a Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    if(grade != -1)
    {
        grades.Add(grade);
    }
    Console.Write("Do you wish to continue? (1 = yes | 2 = no): ");
    @continue = Convert.ToInt32(Console.ReadLine());
} while (@continue == 1);

// Print Values in a List using a For Loop
Console.WriteLine("Printing grades via a for loop");
//for (int i = 0; i < grades.Count; i++)
//{
//    Console.WriteLine(grades[i]);
//}
Console.WriteLine("The Grades you entered are : ");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

// Print Values in a List using a ForEach Loop
//Console.WriteLine("Printing grades via a foreach loop");
//foreach (int item in grades)
//{
//    Console.WriteLine(item);
//}