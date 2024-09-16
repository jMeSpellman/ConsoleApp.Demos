using ConsoleApp.ClassDemo.Utils;

namespace ConsoleApp.ClassDemo.Classes.PersonDemo;

public class Student : Person
{
    public void GenerateStudentIdNumber()
    {
        _idNumber = PersonHelper.GenerateIdNumber("STU");
    }
}
