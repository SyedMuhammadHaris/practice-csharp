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

    //public static void Main()
    //{
    //        //Your task is to swap a two numbers without using third varaible

    //        int a = 30;
    //        int b = 50;
    //        b = a + b;
    //        a = b - a;
    //        b = b - a;
    //        Console.WriteLine("The value of a after swaping is : " + a);
    //        Console.WriteLine("The value of b after swaping is : " + b);

    //        //int temp = a;
    //        //a = b;
    //        //b = temp;
    //    }

    // Methods in C#
     //public static void Main()
     //   {
     //       //PrintName();
     //       //Console.WriteLine("My age is : " + PrintAge(25));

     //       Console.WriteLine(Multiply(Multiply(2.45f,5.32f), Multiply(4.45f, 6.32f)));
     //       Console.WriteLine("Result of Divide is : "+Divide(5,8));
     //   }

     //   //accces modifier, static keyword(if main method create with static keyword), return type of method, name of method(parameter1,parameter2, ...);
     //   //public static void PrintName()
     //   //{
     //   //    Console.WriteLine("My name is Nadeem");
     //   //}
     //   //public static int PrintAge(int age)
     //   //{
     //   //   return age;
     //   //}

     //   public static float Multiply(float a , float b)
     //   {
     //       return a * b;
     //   }

     //   public static double Divide(double a , double b)
     //   {
     //       return a / b;
     //   }

        //public static void Main()
        //{

        //    int var1 =  Convert.ToInt32(Console.ReadLine());
        //    int var2 = Convert.ToInt32(Console.ReadLine());
        //    string var3 = Console.ReadLine();
        //    int num3 = int.Parse(var3);
        //    Console.WriteLine("The result is : " + Add(var1 , var2, num3));
        //    Some("Helllooooooo");
        //}
        //public static int Add(int a, int b, int c)
        //{

        //    return a + b + c;
        //}
        //public static void Some(string a)
        //{
        //    Console.WriteLine(a);
        //}

        public static void Main()
        {
            Console.WriteLine("Enter a number : ");
            string userInput = Console.ReadLine();
            try
            {  
                int userInputInt = int.Parse(userInput);
            }
            //catch (Exception)
            //{
            //throw;
            //    Console.WriteLine(" The error is");
            //}
            catch (FormatException)// and other exception is overflow exception , argumentNull exception, DivideByZeroException
            {
                Console.WriteLine("The error is format excenption");
            }
            finally
            {
                Console.WriteLine("Fnallyy call");
            }
                    // Console.WriteLine("Enter a number : ");
        // int num1 = -5;
        // int num2 = -num1;
        // Console.WriteLine(num2);
        // int num = 0;
        // //increment
        // num++;
        // Console.WriteLine(num);
        // Console.WriteLine(num++);
        // Console.WriteLine(++num);
        
        // //decrement
        // num--;
        //  Console.WriteLine(num);
        // Console.WriteLine(num--);
        // Console.WriteLine(--num);
        //add,sub,mul,div
        
    //     int num1 = 6;
    //     int num2 = 9;
    //     int result = num1 + num2;
    //     Console.WriteLine("The add of two number is : "+ result+"\n");
    //     result = num1 - num2;
    //     Console.WriteLine("The sub of two number is : "+ result);
    //     result = num1 * num2;
    //     Console.WriteLine("The mul of two number is : "+ result);
    //     float a = 3;
    //     float b = 5;
    //     float result1 = a / b;
    //     Console.WriteLine("The div of two number is : "+ result1);
    //     result = num1 % num2;
    //     Console.WriteLine("The remainder of two number is : "+ result);

    //   //relational and  type operators
       
    //   bool isGreater;
    //   isGreater = num1 > num2;
    //   Console.WriteLine("The num is greater or not : "+isGreater);
       
    //   //Equality Operators
    //   bool isEqual;
    //   isEqual = num1 == num2;
    //   Console.WriteLine("The 2 numbers is Equal or not : "+ isEqual);
       
    //   isEqual = num1 != num2;
    //   Console.WriteLine("The 2 numbers is Equal or not : "+ isEqual);
       
    //   //Conditional Operators
    //   bool isSunny = true;
    //   bool isCold = false;
    //   bool isResult  = isSunny && isCold;
    //   Console.WriteLine("The && operator result is :"+ isResult);
    //   isResult = isSunny || isCold;
    //   Console.WriteLine("The OR || operator result is :"+ isResult);
       
            // if statements
    //   string temperature = Console.ReadLine();
    //   int temp = int.Parse(temperature);
    //   if(temp < 10){
    //       Console.WriteLine("It is very cold");
    //   }
    //   if(temp > 10){
    //      Console.WriteLine("It is not cold");
    //   }
    //   if(temp == 10){
    //      Console.WriteLine("It is cold");
    //   }
        }
    }
}
