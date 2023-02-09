using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    internal class Members
    {
        //member private field
        private string memberName;
        private string jobTitle;
        public int age;
        private int salary;

        // member property -- exposes jobTitle safely -- properties start with a capital letter 
        public string JobTitle
        {
            get
            {
                return jobTitle; 
            } 
            set
            {
                jobTitle = value;
            }
        }

        public void SharePrivateInfo()
        {
            Console.WriteLine("My Slary is : {0}",salary);
        }
        //public member method of this class which can called from another class
        public void Introduce(bool isFirend)
        {
            if (isFirend)
            {
                SharePrivateInfo();
            }
            else
                Console.WriteLine("My name is {0} and my Job title is {1} and age is {2}",memberName,jobTitle,age);

        }
       //Member constructor
        public Members()
        {
            age = 25;
            memberName = "Dani";
            jobTitle = "Developer";
            salary = 60000;
            Console.WriteLine("Object is created");
        }

        //Memeber ~ Finalizer ~Destructor
        ~Members()
        {
            //Clean up statements
            Console.WriteLine("Destruction of member objects");
            Debug.Write("Destruction of member objects");
        }
    }
}
