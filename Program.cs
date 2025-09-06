// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Day2: Console Calculator===");
        Console.WriteLine("例）12.5 + 3, 10 / 2 など。終了は'q'");

        var ci = CultureInfo.InvariantCulture;

        while (true)
        {
            Console.WriteLine("\n1つ目の数値（終了は'q'):");
            string? aStr = Console.ReadLine();
            if (aStr?.Trim().ToLower() == "q") break;

            Console.WriteLine("演算子 (+, -, *, /):");
            string? op = Console.ReadLine();

            Console.WriteLine("2つ目の数値:");
            string? bStr = Console.ReadLine();

            if (!double.TryParse(aStr, NumberStyles.Float, ci, out double a) || !double.TryParse(bStr, NumberStyles.Float, ci, out double b))
            {
                Console.WriteLine("数値の入力が正しくありません。もう一度入力してください。");
                continue;
            }

            double result;
            switch (op)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("0で割ることはできません。");
                        continue;
                    }
                    result = a / b; break;
                default:
                    Console.WriteLine("対応していない演算子です　(+, -, *, / のいずれか)。");
                    continue;
            }
            Console.WriteLine($"={result.ToString(ci)}");
        }
        Console.WriteLine("\nお疲れ様。またね!");
    }
}
