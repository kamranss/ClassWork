using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person per1 = new Person("Kamran", "Suleyman", "+56641564545616", "BackEndDev", "General");

            Console.WriteLine(per1.FullInfo());

        }



    }

}
