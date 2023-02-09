using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    internal class Box
    {
        //member variable
        // We encapsulate variable with private keyword pr secure
        private int length = 3; // members variable with private keyword cannot acees in another class
        //public int width;
        private int height;
        public int volume;

        //private void SetLength(int length)
        //{
        //    this.length = length;
        //}
         //This is one way to get and set the of private variable
        public void SetLength(int length)
        {
            if(length < 3)
            {
                throw new Exception("Length should be greater than 3");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        //second method to get and set the value of private variable
        public int Height // propery of member variable
        {
           get
            {
                return height;
            }
            set
            {
                height = -value;
            }
        }

        //third method to get and set property
        public int Width { get; set; }

        public int GetVolume()
        {
            return this.length * Width * this.height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("The box dimension is {0} {1}",height,length);
        }
    }
}
