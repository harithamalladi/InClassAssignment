using System;

namespace InClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the sum of two numbers:");
            string str = Console.ReadLine();
            string[] value = str.Split('+');
            int num1 = int.Parse(value[0]);
            int num2 = int.Parse(value[1]);
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
