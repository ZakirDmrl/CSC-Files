using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int sayi1,int sayi2);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Math math = new Math();
            //customerManager.SendError();
            //customerManager.SendMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.SendError;
            myDelegate -= customerManager.SendMessage;
            myDelegate();
            MyDelegate2 myDelegate2 = customerManager.Greeting;
            myDelegate2("Zakir");
            MyDelegate3 myDelegate3 = math.Add;
            Console.WriteLine(myDelegate3(4,5));
            Console.ReadLine();
        }
        class CustomerManager
        {
            public void SendMessage() 
            {
                Console.WriteLine("Hello");
            }
            public void SendError() 
            {
                Console.Error.WriteLine("Be Careful!");
            }
            public void Greeting(string text)
            {
                Console.WriteLine(text);
            }
        }
        class Math
        {
            public int Add(int a,int b) {
            return (a + b);
            }
        }
    }
}
