using System;

namespace HCF
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n1, n2, j, HCF = 1;
            Console.WriteLine(" Enter the first number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = int.Parse(Console.ReadLine());
            j = (n1 < n2) ? n1 : n2;
            for (i = 1; i <= j; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    HCF = i;
                }
            }
            Console.WriteLine("\nHCF of{0}and{1} is:{2}\n\n",n1,n2,HCF);
        }
    }
}
