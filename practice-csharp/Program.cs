// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

//public class HelloWorld
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Hello Mono World");
//    }
//}

namespace HelloWorldApplication  
{
    public class Program
    {
        //<summary>
        // This is the entry point of our application (the static method)
        //</suumary>
        //static void Main(string[] args)  

        //primitive data types are those which are provided by programming language
        //we can also create custom data types which are stack , queue, linkedlist and many more
        //some Primitive data types in c# 
        ////Explicitly means we create variables with data types
        //float x = 2.99f;
        //int y = 200000;
        //string name = "John Cena";
        //char letter = 'A'; // character can be defined in single quotes
        //bool decision = false; // or true boolean data type

        ////static int a = 30;
        //static void Main() //<- method 1
        //{   
        //    //Implicitly means if we provide string datatype varaible behave like strings or vice versa;
        //    var ab = "name";
        //    //Console.WriteLine("Hello World again");

        //    //string name = " Haris ";
        //    //Console.WriteLine("Hi " + name);

        //    //int number = 30;
        //    //float price = 2.98f;

        //    //Console.WriteLine("The Product Is : " + number*price);

        //    //int a = 1; // we can change the value of a variable
        //    //int b = 2;
        //    ////here we change the value of 'a' variable
        //    //a = 6;
        //    //int c = a + b;

        //    //Console.WriteLine("The Sum is " + c);

        //    //Debuging using breakpoints

        //    //float vat = 17f;
        //    //float productA = 9.99f;
        //    //float productB = 8.04f;
        //    //float productC = 21.98f;

        //    //float summed = productA + productB + productC;
        //    //float totalTax = (summed / 100 ) * vat;

        //    //summed += totalTax;
        //    //Console.WriteLine("The total price is:" + summed);

        //    // Scope of variables

        //    int a = 50;
        //    Console.WriteLine("The value of a is"+ a);

        //    //ReaasignedAvariable();
               
        //}

      //public static void ReaasignedAvariable ( ) // <- second mehtod in the class
      //  {
      //      Console.WriteLine("The ReaasignedAvariable "+a);
      //  }

    public static void Main()
    {
            //Your task is to swap a two numbers without using third varaible

            int a = 30;
            int b = 50;
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine("The value of a after swaping is : " + a);
            Console.WriteLine("The value of b after swaping is : " + b);

            //int temp = a;
            //a = b;
            //b = temp;
        }
    }
}