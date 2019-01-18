using System;


namespace ProjectEuler
{
   class Program
   {
       static void Main(string[] args)
       {
           long i, j, sum = 17;
           bool flag = true;
           for (i = 2; i < 2000000;i++)
           {
               if ((i % 2) != 0 && (i % 3) != 0 && (i % 5) != 0 && (i % 7) != 0 )
               {
                   flag = true;
                   for (j = 2; j <= Math.Sqrt(i); j++)
                   {
                       if (i % j == 0)
                       {
                           flag = false;
                       }
                   }
                   if (flag == true)
                   {
                       sum = sum + i;
                   }
               }
           }
           Console.WriteLine(sum);
           Console.ReadLine();
       }
   }
}
