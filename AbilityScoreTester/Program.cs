using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;                             
            }
        }

        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [ " + lastUsedValue + "]");
            string value = Console.ReadLine();
            if (int.TryParse(value, out int result))
            {
                Console.WriteLine("using value " + result);
                return result;
            }
            else
            {
                Console.WriteLine("using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
        static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [ " + lastUsedValue + "]");
            string value = Console.ReadLine();
            if (double.TryParse(value, out double result))
            {
                Console.WriteLine("using value " + result);
                return result;
            }
            else
            {
                Console.WriteLine("using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
