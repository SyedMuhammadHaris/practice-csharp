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

            //Human mubariz = new Human("Mubariz", "Shaikh",23,"black"); //here we pass contructor values create in HUMAN class
            //mubariz.IntrroduceYourSelf();

            //Human sarim = new Human("Sarim", "Ali", 1,"Green");
            //sarim.IntrroduceYourSelf();
            //Human fahad = new Human("Fahad","Shamsi",24);
            //fahad.IntrroduceYourSelf();

            //Human Harry = new Human("Harry");
            //Harry.IntrroduceYourSelf();
            ////mubariz.firstName = "Mubariz";
            ////mubariz.lastName = "Shaikh";
            ////mubariz.printName("Mubariz","Shaikh");

            //Human basicHuman = new Human();
            //basicHuman.IntrroduceYourSelf();

            //New learning Session 
            //Box box1= new Box();

            //box1.SetLength(8);

            ////box1.width= 5;
            ////box1.height= 5;
            //box1.Width= 8;
            //box1.Height= -5;
            ////Console.WriteLine("The length is: {0}",box1.GetLength());
            //Console.WriteLine("The volume is: {0}", box1.GetVolume());
            //Console.WriteLine("The Width is: {0}", box1.Width);
            //box1.DisplayInfo();


            //Members class object

            Members member1 = new Members();
            member1.Introduce(true);


            //Main();
        }
    }
}
