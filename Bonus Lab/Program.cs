using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string Prompt = "Enter an integer: ";
            string S1 = "";
            string S2 = "";
            bool CaseSensitive = true;
            int Min = 0;
            int Max = 100;

            int IntegerInput = GetInt();
            int IntegerInputRange = GetIntWithinRange(Min, Max);
            double DoubleInput = GetDouble();
            double DoubleInputRange = GetDoubleWithinRange(0, 100);
            string ChoiceString = GetChoiceString(Prompt, S1, S2);
            string ChoiceStringCase = GetChoiceString(Prompt, S1, S2, CaseSensitive);

        }
        public static int GetInt()
        {
            int IntegerInput;
            while (true)
            {
                Console.Write("Please enter an integer: ");
                if (!int.TryParse(Console.ReadLine(), out IntegerInput))
                {
                    Console.WriteLine("Error, invalid input!\n");
                    continue;
                }
                return IntegerInput;
            }
        }
        public static int GetIntWithinRange(int Min, int Max)
        {
            int IntegerInputRange;
            while (true)
            {
                IntegerInputRange = GetInt();
                if (IntegerInputRange < Min || IntegerInputRange > Max)
                {
                    Console.WriteLine("Error, input not between {0} and {1}\n", Min, Max);
                    continue;
                }
                return IntegerInputRange;
            }
        }
        public static double GetDouble()
        {
            double DoubleInput;
            while (true)
            {
                Console.Write("Please enter an double: ");
                if (!double.TryParse(Console.ReadLine(), out DoubleInput))
                {
                    Console.WriteLine("Error, invalid input!\n");
                    continue;
                }
                return DoubleInput;
            }
        }
        public static double GetDoubleWithinRange(int Min, int Max)
        {
            double DoubleInputRange;
            while (true)
            {
                DoubleInputRange = GetDouble();
                if (DoubleInputRange < Min || DoubleInputRange > Max)
                {
                    Console.WriteLine("Error, input not between {0} and {1}\n", Min, Max);
                    continue;
                }
                return DoubleInputRange;
            }
        }
        public static string GetChoiceString(string Prompt, string S1, string S2)
        {
            return "hello";
        }
        public static string GetChoiceString(string Prompt, string S1, string S2, bool CaseSensitive)
        {
            return "hello";
        }
    }
}
