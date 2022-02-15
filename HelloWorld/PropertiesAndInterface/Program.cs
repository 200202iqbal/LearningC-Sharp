using System;

namespace PropertiesAndInterface
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person myObj = new Person();
            Console.Write("Insert your name : ");
            myObj.Name = Console.ReadLine();
            Console.WriteLine(myObj.Name);
            myObj.run();
            myObj.sound();

            Car myObj2 = new Car();
            Console.Write("Insert your name's car : ");
            myObj2.Name = Console.ReadLine();
            Console.WriteLine(myObj2.Name);
            myObj2.run();
            myObj2.sound();
            Console.ReadKey();
        }
    }

    class Person : InterfaceActivity
    {
        private string name; //field

        public string Name //property
        {
            get { return name; } //get method
            set { name = value; } //set method
        }
        public void run() //method's interface
        {
            Console.WriteLine($"{this.Name} is running ");
        }
        public void sound() //method's interface
        {
            Console.WriteLine("Hello....");
        }
    }

    class Car : InterfaceActivity
    {
        public string Name//property
        { get; set; }

        public void run() //method's interface
        {
            Console.WriteLine($"{this.Name} is moving");
        }
        public void sound() //method's interface
        {
            Console.WriteLine("Broomm....");
        }
    }
}
