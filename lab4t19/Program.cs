namespace lab4t19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество предметов: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Введите массу {i}-го предмета: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Средняя масса: {sum / n}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
