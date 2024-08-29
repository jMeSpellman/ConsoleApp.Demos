// See https://aka.ms/new-console-template for more information
Console.WriteLine("********* - Arrays - *********");
// Tell me how many students and grades are to be entered
Console.Write("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Declare Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];

// Add values to Fixed Size Array
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

//for (int i = 0; i < grades.Length; i++)
//{
//    Console.Write("Enter a Grade: ");
//    grades[i] = Convert.ToInt32(Console.ReadLine()); 
//}

for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write("Enter Student Name: ");
    students[i] = Console.ReadLine();

    Console.Write("Enter a Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

//// Print values in a Fixed Size Array
//Console.WriteLine("The Grades you entered are : ");
//for (int i = 0; i < grades.Length; i++)
//{
//    Console.WriteLine(grades[i]);
//}
Console.WriteLine("The Grades you entered are : ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}


//// Declare Variable Sized Aray
//string[] studentNames = new string[] { "Charles", "Wade", "Logan" };
//// Add Values to Variable Sized Array

//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write("Enter Student Name: ");
//    studentNames[i] = Console.ReadLine();
//}

//// Print values in Variable Sized Array
//Console.WriteLine("The Names you entered are : ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}