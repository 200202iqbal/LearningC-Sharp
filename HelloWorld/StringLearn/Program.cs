using System;

namespace StringLearn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is : "+txt.Length);

            //ToUpper and ToLower
            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());
            Console.WriteLine(txt2.ToLower());

            // input first name
            Console.Write("Input your first name : ");
            string firstName = Console.ReadLine();
            

            Console.Write("Input your last name : ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your Fullname is : " + fullName);

            //use string.Concat();
            Console.WriteLine(string.Concat(firstName, lastName));

            //string interpolation
            string name = $"My fullname is :{firstName} {lastName}";
            Console.WriteLine(name);

            //access string
            Console.WriteLine(fullName[0]);
        }
    }
}
