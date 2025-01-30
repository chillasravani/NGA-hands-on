// using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ConsoleApp1_NGA;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1_NGA
{
    internal class OOps
    {

        //protected string Name;

        /*abstract class Animal

        {
            public string? Name { get; set; }
            public void SetName(string name)
            {
                Name = name;
            }
            public string GetName()
            {
                return Name!;
            }
            public abstract void Eat();
        }
        class Dog : Animal
        {
            public override void Eat()
            {
                //throw new NotImplementedException();
                Console.WriteLine("dog is Eating");
            }
        }

        class OOPs
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the dogs name");
                string? name = Console.ReadLine();
                Dog dog = new Dog();
                //dog.SetName(name);
                Console.WriteLine(dog.GetName());
                dog.Eat();
            }


        }
        public class Method

        {
            public static void Main(string[] args)
            {
                int n = 3;
                Constr[] people = new Constr[3];
                for (int i = 0; i < n; i++)
                {
                    people[i] = new Constr(){
                        Name = Console.ReadLine()
                    };
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(people[i].ToString());
                }
            }
        }
        class Constr
        {
            public string Name { get; set; }
            public override string ToString()
            {
                return "Hello! My Name is "+Name;
            }
        }
        public class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return "Hello! My Name is " + Name;
            }
            ~Person() {
                Name = string.Empty;
            }
        } 
        class People
        {
            public static void Main(string[] args)
            {
                int n = 3;
                Person[] people=new Person[n];
                for (int i = 0; i < n; i++)
                {
                    people[i]=new Person(Console.ReadLine());
                }
                for(int i = 0;i < n; i++)
                {
                    Console.WriteLine(people[i].ToString());
                }
                

            }
        }
        public class Person
        {
            public int Age;
            public void Greet()
            {
                Console.WriteLine("Hello!");
            }
            public void SetAge(int age)
            {
                Age = age;

            }
        }
        class Teacher : Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm Explaining ");
            }
        }
        class Student : Person
        {
            public void Study()
            {
                Console.WriteLine("I'm Studying ");
            }
            public void ShowAge()
            {
                Console.WriteLine("My Age is{0} years old", Age);
            }
        }
        class StudentTeacher
        {
            public static void Main(string[] args)
            {
                Person per=new Person();
                per.Greet();

                Student stu=new Student();
                stu.SetAge(21);
                stu.Greet();
                stu.ShowAge();
                stu.Study();

                Teacher tea=new Teacher();
                tea.SetAge(22);
                tea.Greet();
                tea.Explain();
            }
        }*/
        public class PhotoBook
        {
            protected int numPages;
            public PhotoBook()
            {
                numPages = 16;
            }
            public PhotoBook(int numPages)
            {
                this.numPages = numPages;
            }
            public int getNumPages() { 
                return numPages; 
            }


        }
        public class SuperPhotoBook:PhotoBook
        {
            public SuperPhotoBook()
            {
                numPages = 64;
            }
        }
        class PhotoBooktest
        {
            public static void Main(string[] args)
            {
                PhotoBook Album1 = new PhotoBook();
                Console.WriteLine(Album1.getNumPages());

                PhotoBook Album2 = new PhotoBook(24);
                Console.WriteLine(Album2.getNumPages());

                SuperPhotoBook spb = new SuperPhotoBook();
                Console.WriteLine(spb.getNumPages());

                SuperPhotoBook spb2 = new SuperPhotoBook();
                Console.WriteLine(spb2.getNumPages());
            }
        }
    }
}
    
    
