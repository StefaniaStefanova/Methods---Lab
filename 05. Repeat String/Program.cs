using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            string repeatedText = RepeatTextWithoutSpace(text, repeatCount);
            Console.WriteLine(repeatedText);
        }

        static string RepeatTextWithoutSpace(string text, int repeatCount)
        {
            string sanitizedText = text.Replace(" ", ""); // Remove spaces from the input string
            string result = "";

            for (int i = 0; i < repeatCount; i++)
            {
                result += sanitizedText;
            }

            return result;
        }
    }
}
