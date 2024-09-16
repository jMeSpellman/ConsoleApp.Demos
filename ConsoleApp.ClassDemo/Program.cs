// See https://aka.ms/new-console-template for more information
using ConsoleApp.ClassDemo.Classes.PersonDemo;
using ConsoleApp.ClassDemo.Classes.ShapeDemo;

Console.WriteLine("********* - Class and Objects - *********");

// Define an objext of type Person
Person person; // this will be null by default

Person baby = new Person() { FirstName = string.Empty, LastName = string.Empty };
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateOfBirth = new DateOnly(2023, 10, 29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine(taxNumber);

//var person1 = new Person ("Developer","One", new DateOnly(2000, 10,31));

//person1.PrintFullName();
//person1.PrintInitials();

//var person2 = new Person("Developer", "Two", "741852963") { FirstName = string.Empty, LastName = string.Empty };
//person2.PrintFullName();
//person2.PrintInitials();
//person2.GenerateTaxNumber();
//var person2IdNumber = person2.GetIdNumber();
//Console.WriteLine(person2IdNumber);

var teacher = new Teacher() { FirstName = string.Empty, LastName = string.Empty };
teacher.LastName = "Thompson";
teacher.FirstName = "Theresa";
teacher.DateOfBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teacherTaxNumber);
teacher.GenerateTeacherIdNumber();
var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);

Student student = new() { FirstName = string.Empty, LastName = string.Empty};
student.LastName = "Thompson";
student.FirstName = "Theresa";
student.DateOfBirth = new DateOnly(2023, 10, 29);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
var studentTaxNumber = student.GetTaxNumber();
Console.WriteLine(studentTaxNumber);
student.GenerateStudentIdNumber(); 
var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);

//Polygon polygon = new Polygon(); // Compiler Error: Cannot create an instance of the abstract type
Rectangle rectangle = new(10, 20); // Cannot leave parameter of new() empty, as Constructor requests a Width and Length
var rectangleArea = rectangle.Area();
rectangle.GetShapeName();
Console.WriteLine($"Rectangle area is: {rectangleArea}");
Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Square area is: {squareArea}");

Triangle triangle = new(10, 50);
var triangleArea = triangle.Area();
Console.WriteLine($"Triangle area is: {triangleArea}");

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid Area is: {cuboidArea}");
Console.WriteLine($"Cuboid Volume is: {cuboidVolume}");
Console.WriteLine($"Cuboid Perimeter is: {cuboidPerimeter}");

Sphere sphere = new(5);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"{nameof(Sphere)} Circuference is: {sphereCircumference}");
Console.WriteLine($"{nameof(Sphere)} Volume is: {sphereVolume}");
