using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine(sumArrIndex(new string[] { "gfg"}));
            //Console.WriteLine(Number(76));
            //Console.WriteLine(NumberFactorial(40))
            //Console.WriteLine(RevertString("salam"));
            Console.WriteLine(RevertStringWords("salam necesen"));


        }
        #region Method
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
            return    n % 21 == 0;

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
        static string RevertString( string m)
        {
            string n = "";
            for (int i = m.Length-1 ; i >= 0; i-- )
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
            for (int i = 0; i <= arr.Length-1; i++)
            {
                a = arr[i];
                if (a== arr[arr.Length-1])
                {
                    a = arr[i] + " ";
                }
                for (int j = a.Length-1; j >=0; j--)
                {
                    b += a[j];
                }

               

            }
            return b;
           

        }


        #endregion
    }
}
