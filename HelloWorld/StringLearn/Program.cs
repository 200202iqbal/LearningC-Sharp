using System;

namespace StringLearn
{
    class MainClass
    {
        private string[] names = {"Spencer","Sally","Doug"};
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

            //index position a character
            string myString = "Hello World";
            Console.WriteLine(myString.IndexOf("e"));

            int charPos = myString.IndexOf("e"); //get position of chararter
            string subtringText = myString.Substring(charPos);

            Console.WriteLine(subtringText);

            var anInstanceOfMyClass = new MainClass();

            Console.WriteLine(anInstanceOfMyClass.GetName(0));


        }
        public string GetName(int ID)
        {
            if (ID < names.Length)
            {
                return names[ID];
            }
            else
            {
                return String.Empty;
            }
        }

    }
}
