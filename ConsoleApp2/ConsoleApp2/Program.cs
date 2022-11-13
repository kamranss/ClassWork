using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person per1 = new Person("Kamran", "Suleyman", "+56641564545616", "BackEndDev", "General");
            Console.WriteLine(per1.FullInfo());

            Person per2 = new Person();
            per2.Name = "Kamil";
            per2.Surname = "Agayev";
            per2.Phonenumber = "+546465467486";
            per2.Category = "frontEndDev";
            

            Console.WriteLine(per2.FullInfo());



        }



    }

}
