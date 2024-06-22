using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        CalculatePowerAsync(2, 3);
        CalculatePowerAsync(3, 4);
        CalculatePowerAsync(5, 2);
    }
    static double GetPower(double a, int x)
    {
        double result = 1;
        for (int i = 0; i < x; i++)
        {
            return result *= a;
        }
        return result;
    }

    static Task<double> PowerAsync(int a, int x)
    {
        return Task.Run(() => GetPower(a, x));
    }

    static async void CalculatePowerAsync(int a, int x)
    {
        double result = await PowerAsync(a, x);
        Console.WriteLine($"{a}^{x} = {result}");
    }

    static async Task Expression(int a1, int x1, int a2, int x2, int a3, int x3, int a4, int x4)
    {
        double result1 = await PowerAsync(1, 2);
        double result2 = await PowerAsync(3, 4);
        double result3 = await PowerAsync(5, 6);
        double result4 = await PowerAsync(7, 8);

        if (result3 - result4 != 0)
        {
            double finalResult = (double)(result1 + result2) / (result3 - result4);
            Console.WriteLine($"{a1}^{x1} + {a2}^{x2}) / ({a3}^{x3} - {a4}^{x4}) = {finalResult}");
        }
        else
        {
            Console.WriteLine("Делить на 0 нельзя");
        }
    }
}