namespace lab4t22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = 100;
            double yield = 20;
            double total = 0;
            for (int year = 1; year <= 8; year++)
            {
                if (year >= 2 && year <= 8)
                    Console.WriteLine($"{year} год: Урожайность = {yield:F2} ц/га");
                if (year >= 4 && year <= 7)
                    Console.WriteLine($"{year} год: Площадь = {area:F2} га");
                if (year <= 6)
                    total += area * yield;

                area *= 1.05;
                yield *= 1.02;
            }
            Console.WriteLine($"Урожай за 6 лет: {total:F2} ц");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
