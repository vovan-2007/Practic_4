namespace lab4t13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите количество повторов: ");
            int r = int.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
