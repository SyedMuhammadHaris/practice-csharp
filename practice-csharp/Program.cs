// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using practice_csharp;
using System;
using System.Collections;
using System.Globalization;

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

            //Members member1 = new Members();
            //member1.Introduce(true);

            //Learning Arrays
            //initialize array
            // one way of initialize array
            //int[] grades = new int[5];
            //grades[0] = 23;
            //grades[1] = 34;
            //grades[2] = 35;
            //grades[3] = 58;
            //grades[4] = 94;

            //Console.WriteLine("Thg grade in position zero is : {0}", grades[0]);
            //Console.WriteLine("Thg grade in position one is : {0}", grades[1]);
            //Console.WriteLine("Thg grade in position two is : {0}", grades[4]);

            //// we can change the values in array after assining

            ////string input = Console.ReadLine();
            ////grades[0] = int.Parse(input);
            ////Console.WriteLine("The grade in position zero after change the value: {0}", grades[0]);

            //// second way of initialize array
            //string[] nameOfStudents = {"Sarim","Mubariz","Obaid" };
            //Console.WriteLine("name of student : {0}", nameOfStudents[0]);
            //nameOfStudents[0] = "Fahad";
            //Console.WriteLine("name of student : {0}", nameOfStudents[0]);

            ////Third way of initialize array

            //float[] percentageOfStudents = new float[] {70.9f, 83.9f,99.3f, 75.3f};
            //Console.WriteLine("Percerntage AT posotion zero is : {0}" , percentageOfStudents[0]);
            //Console.WriteLine("length of percentage array : {0}" , percentageOfStudents.Length);

            //for loop with array

            //int[] nums = new int[11];

            //for(int i = 0; i< nums.Length; i++)
            //{
            //    nums[i] = i;
            //}

            //for(int j = 0; j< nums.Length; j++)
            //{
            //    Console.WriteLine("Element {0} , {1}", j, nums[j]);
            //}

            //// foreach loop 
            //int counter =0;
            //foreach(int k in nums)
            //{
            //    Console.WriteLine("Element {0} , {1}", k, counter++);

            //}

            //create an array with 5 of your best friend
            //string[] bestFriends = new string[] {"Sarim","Fahad", "Obaid", "Mubriz","Hassan"};

            //foreach(string name in bestFriends)
            //{
            //    Console.WriteLine("Hi {0}",name);
            //}

            // Multidimensional array

            //decalre 2D Array
            //string[,] matrix;

            ////declare 3D Array
            //string[,,] matrix2;

            ////two dimensional Array
            //int[,] array2D = new int[,]
            //{
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};
            //Console.WriteLine("value in this postion is : {0}",array2D[2,2]);
            //int dimensionOfArray = array2D.Rank;
            //Console.WriteLine("The dimension of array is {0}", dimensionOfArray);

            ////we can initialize like that 
            //int[,] array2D2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //int[,] matrix = { 
            //    { 1,2,3},
            //    {4,5,6},
            //    {7,8,9} 
            //};

            //foreach(int items in matrix) 
            //{
            //    Console.Write("{0} {1}",items," ");
            //    //items = 0;
            //    //in foreach loop you cannot change values
            //}
            //Console.WriteLine("\nPrint 2D arraynusing nested for loop ");

            ////using nested loops

            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    //inner loop 
            //    for(int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        //matrix[i,j] = 0;
            //        Console.Write(matrix[i,j]+ " ");
            //        //in this loop we can change the values of array
            //    }
            //}

            //Jagged Array : Jagged array are those whose values are also arrays of different length

            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[3];
            //jaggedArray[1] = new int[5];
            //jaggedArray[2] = new int[6];

            //jaggedArray[0] = new int[] { 1,2,3,4,5};
            //jaggedArray[1] = new int[] { 1,2,3};
            //jaggedArray[2] = new int[] { 1,2,3,4};
            //Console.WriteLine("The value in the middle of first entry is : {0}", jaggedArray[0][2]);
            
            // alternative way
            //int[][] jaggedArray2 = new int[][]
            //{
            //    new int[] { 1,2,4,5,76,8},
            //    new int[] { 9,10,6,486}
            //};
            //Console.WriteLine("The value in the middle of first entry is : {0}", jaggedArray2[0][5]);

            //for(int i = 0; i < jaggedArray2.Length; i++)
            //{
            //    Console.WriteLine("Element {0}",i);
            //    for(int j = 0; j < jaggedArray2[i].Length; j++)
            //    {
            //      Console.WriteLine("{0} ",jaggedArray2[i][j]);

            //    }

            //}

            //ArrayList can store multipe type of with different data type 

            //declare ArrayList with undined amount of objects
            ArrayList myArrayList = new ArrayList();

            //decalare ArrayList with defined amount of Objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList2.Add(2);
            myArrayList2.Add("boy");
            myArrayList2.Add(19.6f);
            myArrayList2.Add('c');
            Console.WriteLine(myArrayList2.Count);
            Console.WriteLine(myArrayList2[1]);

            //to remove object from array
            //myArrayList2.Remove(2);
            ////remove from array list and also tell postion of object
            //myArrayList2.RemoveAt(1);
            //Console.WriteLine(myArrayList2[1]);

            foreach(object obj in myArrayList2) 
            {
                Console.WriteLine(obj);
            }

            //List in C#
            //List can only storre specific type of data type (int or string) 
            List<string> listOfNames = new List<string>();
            listOfNames.Add("Sahmir");
            listOfNames.Add("Amir");

            foreach(object obj in listOfNames)
            {
                Console.WriteLine(obj);
            }
            //Main();
        }
    }
}
