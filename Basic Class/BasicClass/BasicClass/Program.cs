using System;

namespace BasicClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Object for the basicClass

            basicClass bs = new basicClass();

            bs.MethodCall();  //Calling the method using basicClass object
            
        }
    }

    public class basicClass
    {
        public basicClass()
        {
            Console.WriteLine("Basic Class Constructor is called! \n The Object has been created for the class BasicClass");
        }

        public void MethodCall()
        {

            Console.WriteLine("Method is called");

        }
    }
}
