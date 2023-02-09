using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    internal class Human
    {
        //string name = "Hhhh";
        //public string firstName;
        //public string lastName;
        private string firstName;
        private string lastName;
        private int age;
        private string eyeColor;

        //public void printName(string firstName, string lastName)
        //{
        //    Console.WriteLine("My name is {0} {1}",firstName,lastName);
        //}
        //We can create in multiple contructors in C# of same name

        //default Contructor 1
        public Human()
        {
            Console.WriteLine("Constructor is caled Object is created");
        }
       // Contructor 2
        public Human(string myFirstName)
        {
            firstName = myFirstName;
        }
        //Contructor 3
        public Human(string myFirstName, string lastName, int age)
        {
            firstName = myFirstName;
            this.lastName = lastName;
            this.age = age;
        }
        //Contructor 4 in C#
        public Human(string myFirstName,string lastName, int age, string eyeColor)
        {
            firstName = myFirstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        public void IntrroduceYourSelf()
        {
            if (firstName != null && lastName != null && eyeColor != null && age != 0)
            {
                if (age == 1)
                {
                    Console.WriteLine("My name is {0} {1} and {2} year and my eye color is {3}", firstName, lastName, age, eyeColor);
                }
                else
                    Console.WriteLine("My name is {0} {1} and {2} years and my eye color is {3}", firstName, lastName, age, eyeColor);
            }
            else
                if(firstName != null && lastName != null && age != 0)
            {
                Console.WriteLine("\"My name is {0} {1} and {2} years", firstName,lastName,age);
            }
            else
                 if (firstName != null)
            {
                Console.WriteLine("Your first name is : {0}", firstName);
            }
            else
                Console.WriteLine("Empty Constructor");
        }

        
    }
}
