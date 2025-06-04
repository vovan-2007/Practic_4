namespace lab4t18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Введите {i}-ю оценку: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Средняя оценка: {sum / 10}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
