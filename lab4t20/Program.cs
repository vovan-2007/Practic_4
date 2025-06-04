namespace lab4120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 0;
            double totalPath = 0;
            for (int i = 1; i <= 100; i++)
            {
                totalPath += 1.0 / i;
                if (i % 2 == 1)
                    distance += 1.0 / i;
                else
                    distance -= 1.0 / i;
            }
            Console.WriteLine($"После 100 этапов: ");
            Console.WriteLine($"Расстояние от дома: {distance} км");
            Console.WriteLine($"Весь путь: {totalPath} км");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
            
        }
    }
}
