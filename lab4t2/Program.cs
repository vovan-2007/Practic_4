namespace lab4t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную сумму: ");
            double sum = double.Parse(Console.ReadLine());
            int months = 0;
            while (sum < 100000)
            {
                sum *= 1.02; //Рост на 2%
                months++;
            }
            Console.WriteLine($"Потребуется месяцев: {months}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
