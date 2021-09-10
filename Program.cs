using System;
using System.Linq;

namespace Basic_Sequence_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbArray = new int [Math.Abs(n) + 1];
            var sum = 0;
            //if(n>=0)
            //{
                for (int i = 0; i < Math.Abs(n) + 1; i++)
                {
                    if (n >= 0) sum+=i;
                    else sum-=i;
                    numbArray[i] = sum;
                }
            //}
            //else
            //{
            //    for (int i = 0; i > n - 1; i--)
            //    {
            //        numbArray[i*-1] = i + j;
            //        j = numbArray[i*-1];
            //    }
            //}
            var NewArray = Enumerable.Range(0, Math.Abs(n) + 1).Select(i => Math.Sign(n) * (i + 1) * i / 2).ToArray(); ;

        }
    }
}
