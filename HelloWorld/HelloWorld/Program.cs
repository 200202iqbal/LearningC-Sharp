using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello World I will print on the same line");

            //This is a comment
            Console.WriteLine("// is comment");

            /*
             * The code below will print the words Hello World
to the screen, and it is amazing
             */
            string name = "John";
            int age = 26;
            Console.WriteLine(name+ " is " + age + " years old");

            age = 20;
            Console.WriteLine("6 years ago, " + name + " is " + age + " years old");

            //Type Casting
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));

            Console.WriteLine("Enter name :");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is : " + userName);

            Console.WriteLine("Enter age :");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is : " + userAge);
        }
    }
}
