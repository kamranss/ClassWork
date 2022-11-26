using System;

namespace ConsoleApp2
{
    class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine(sumArrIndex(new string[] { "gfg"}));
            //Console.WriteLine(Number(76));
            //Console.WriteLine(NumberFactorial(40))
            //Console.WriteLine(RevertString("salam"));
            //Console.WriteLine(RevertStringWords("salam necesen"));  
            //Console.WriteLine(ChangeVariableValue(4,5));
            //Car car1 = new Car();
            //car1.Model = "djsdkjs";

            //int num = 3;
            //Console.WriteLine(num.CheckFactorial());

            string a = "ldeojejoaaa|";
            Console.WriteLine(a.Checkstr("a"));




        }

        #region Methods
        static string ChangeVariableValue(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            return $"{a} {b}";
        }
        static int sumArrIndex(params string[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                count++;
            }

            return count;
        }
        static bool Number(int n)
        {
            return n % 21 == 0;

        }
        static int NumberFactorial(int n)
        {
            int m = 1;
            for (int i = 1; i <= n; i++)
            {
                m *= i;
            }
            return m;
        }
        static string RevertString(string m)
        {
            string n = "";
            for (int i = m.Length - 1; i >= 0; i--)
            {

                n += m[i];
            }
            return n;

        }
        static string RevertStringWords(string m)
        {

            string[] arr = m.Split(" ");
            string a = "";
            string b = "";
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                a = arr[i];
                if (a == arr[arr.Length - 1])
                {
                    a = arr[i] + " ";
                }
                for (int j = a.Length - 1; j >= 0; j--)
                {
                    b += a[j];
                }



            }
            return b;


        }
        #endregion





    }

}
