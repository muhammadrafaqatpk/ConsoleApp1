using System;
using System.Collections;
namespace ConsoleApp1
{ 
    interface i1
    {
        void InterFaceMethod();
    }
    interface i2
    {
        void InterFaceMethod();
    }
    
    class Program : i1,i2
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.InterFaceMethod();
            ((i2)p).InterFaceMethod();
        }

        public void InterFaceMethod()
        {
            Console.WriteLine("i1 interface method");

        }
        void i2.InterFaceMethod()
        {
            Console.WriteLine("i2 interface method");

        }
    }
        
}
