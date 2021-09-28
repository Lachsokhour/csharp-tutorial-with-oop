namespace Practices_280921
{
    public class Person
    {
        protected int age;
        public void Greet(){
            System.Console.WriteLine("Hello!");
        }
        public void SetAge(int age){this.age = age;}
    }

    public class Student : Person {
        public void Study() {
            System.Console.WriteLine("I'm studying.");
        }
        public void ShowAge() {
            System.Console.WriteLine($"My age is {age} years old.");
        }
    }

    public class Teacher : Person {
        public void Explain() {
            System.Console.WriteLine("I'm explaining.");
        }
    }
}