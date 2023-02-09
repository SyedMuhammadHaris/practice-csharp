// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using practice_csharp;
using System;



namespace HelloWorldApplication  
{
    public class Program
    {
        

        public static void Main()
        {
            //Human Sarim = new Human();
            //Sarim.firstName = "Sarim";
            //Sarim.lastName = "Ali";
            //Sarim.printName();

            Human mubariz = new Human("Mubariz", "Shaikh",23,"black"); //here we pass contructor values create in HUMAN class
            mubariz.IntrroduceYourSelf();

            Human sarim = new Human("Sarim", "Ali", 1,"Green");
            sarim.IntrroduceYourSelf();
            Human fahad = new Human("Fahad","Shamsi",24);
            fahad.IntrroduceYourSelf();

            Human Harry = new Human("Harry");
            Harry.IntrroduceYourSelf();
            //mubariz.firstName = "Mubariz";
            //mubariz.lastName = "Shaikh";
            //mubariz.printName("Mubariz","Shaikh");

            Human basicHuman = new Human();
            basicHuman.IntrroduceYourSelf();


            //Main();
        }
    }
}
