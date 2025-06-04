namespace lab4t23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            int sqr = 0;
            for (int i = 1, x = 1; i <= n; i++, x += 2)
            {
                sqr += x;
            }
            Console.WriteLine($"{n}² = {sqr}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
