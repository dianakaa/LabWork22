namespace LabWork22
{
    internal class Program
    {
        static void GetPower(double a, int x)
        {
            double result = 1;
            for (int i = 0; i < x; i++)
            {
                result *= a;
            }

            if (x < 0)
            {
                for (int i = 0; i < -x; i++)
                {
                    result *= a;
                }
                result = 1 / result;
            }

            Console.WriteLine($"{a}^{x}={result}");
        }

        static async Task Main(string[] args)
        {
            await Task.Run(() => GetPower(2, -3));
            await Task.Run(() => GetPower(3, 4));
            await Task.Run(() => GetPower(4, 5));

            Task task1 = Task.Run(() => GetPower(2, 3));
            Task task2 = Task.Run(() => GetPower(3, 4));
            Task task3 = Task.Run(() => GetPower(4, 5));
            await Task.WhenAll(task1, task2, task3);
        }


    }
}
