using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = RaiseToPower(baseNumber, power);
            Console.WriteLine(result);
        }

        static int RaiseToPower(int baseNum, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}
