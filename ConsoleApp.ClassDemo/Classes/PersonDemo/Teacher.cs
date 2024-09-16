using ConsoleApp.ClassDemo.Utils;

namespace ConsoleApp.ClassDemo.Classes.PersonDemo
{
    // Teacher Class inherits from Person Class
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("TCH");
        }
    }
}
