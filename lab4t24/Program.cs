namespace lab4t24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int x = 1;
            for (int num = 1; num <= 10; num++)
            {
                total += x;
                x += 2 * num + 1;
            }
            Console.WriteLine($"Сумма квадратов чисел от 1 до 10: {total}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
