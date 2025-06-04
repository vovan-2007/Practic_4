namespace lab4t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            string int5 = "";
            while (N > 0)
            {
                int5 = (N % 5) + int5;
                N /= 5;
            }
            Console.WriteLine($"В 5-ной системе: {int5}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
