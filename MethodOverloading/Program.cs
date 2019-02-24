using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValues(out int value1, out int value2, out int result1);
            Console.WriteLine("The first value is {0} ,the second value is {1} and the sum is {2}", value1, value2, result1);
            Getmeyourname();
            Console.WriteLine("Enter two values");
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());
            Sum(val1,val2);

            Sum(40);

           
          
            int myfinalvaue = Sum(40, 65);
           // Console.WriteLine(myfinalvaue);
           // Console.WriteLine(myfinalvaue);
            Console.ReadKey();

        }

        static string Getmeyourname()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            return name;

        }

        static int Sum(int number1)
        {

            int result = number1 + number1;
            Console.WriteLine(result);
            return result;

        }
        static int Sum(int number1, int number2)
        {

            int result = number1 * number2;
            Console.WriteLine(result);
            return result;

        }


        static int GetValues(out int first,out int second,out int result)
        {
            Console.WriteLine("Enter the first value");
             first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second value");
             second = int.Parse(Console.ReadLine());
             result = first + second;
            return result;
        }





    }

}
