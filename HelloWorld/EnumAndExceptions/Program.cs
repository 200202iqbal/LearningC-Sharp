using System;

namespace EnumAndExceptions
{
    public enum Months
    {
        January, //0
        February, //1
        March, //2
        April, //3
        May, //4
        June, //5
        July //6
    }

    
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Months.January);
            int myMonth = (int)Months.January;
            Console.WriteLine(myMonth);

            int[] myNumbers = { 1, 2, 3 };
            try
            {
                Console.WriteLine(myNumbers[10]);
                Console.WriteLine(Months.April);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            checkAge(20);

            void checkAge(int age)
            {
                if(age < 18 )
                {
                    throw new Exception("Access Denied - You must be at least 18 years old");
                }
                else
                {
                    Console.WriteLine("Access granted - You're old enough ");
                }

            }
        }
    }
}
