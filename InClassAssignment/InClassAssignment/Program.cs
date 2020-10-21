using System;

namespace InClassAssignment1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Calculate the sum of n numbers:");
            string str = Console.ReadLine();
            string[] values = str.Split('+');
            int sum = 0, sum1 = 0;
            try
            {
                foreach (string i in values)
                {
                    if (int.TryParse(i, out int num1))
                        sum += num1;
                    else if (int.TryParse(i, out int num2))
                        sum1 += num2;
                    else throw new Exception();
                }
                Console.WriteLine("The Sum is : {0}", sum + sum1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Donot enter null characters", e.Message);
            }
        }
    }
}