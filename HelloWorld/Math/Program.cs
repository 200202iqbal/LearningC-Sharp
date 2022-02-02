using System;
namespace Math
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int varA = 10;
            int varB = 5;
       
            Console.WriteLine(System.Math.Max(varA,varB));
            Console.WriteLine(System.Math.Min(varA, varB));
            Console.WriteLine(System.Math.Sqrt(64));
            Console.WriteLine(System.Math.Abs(-15));
            Console.WriteLine(System.Math.Round(6.4));
            Console.WriteLine(System.Math.Round(6.7));
        }
    }
}
