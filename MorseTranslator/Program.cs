using System;
using System.Text;

namespace MorseTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Put in the sentence you want to translate");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            StringBuilder morse = new StringBuilder();
            foreach (int i in chars) {
                switch (chars[i])
                {
                    case 'a':
                        morse.Append(".-");
                        i++;
                        break;
                    case 'b':
                        morse.Append("-...");
                        i++;
                        break;
                } 
            }
            Console.WriteLine(morse);
        }
    }
}