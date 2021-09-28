using System;

namespace Practices_280921
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem #1
            System.Console.WriteLine("----Problem #1----");
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(25);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
            System.Console.WriteLine("----end Problem #1----");
            // end Problem #1

            // Problem #2
            System.Console.WriteLine("----Problem #2----");
            PhotoBook photoBook = new PhotoBook();
            System.Console.WriteLine(photoBook.GetNumPages());

            PhotoBook photoBook1 = new PhotoBook(56);
            System.Console.WriteLine(photoBook1.GetNumPages());

            SuperPhotoBook superPhotoBook = new SuperPhotoBook();
            System.Console.WriteLine(superPhotoBook.GetNumPages());
            System.Console.WriteLine("----end Problem #2----");
            // end Problem #2

            Car car = new Car(0);
            System.Console.Write("Please enter your fuel number: ");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel)) {
                car.Drive();
            }
        }
    }
}
