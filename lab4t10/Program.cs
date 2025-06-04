namespace lab4t10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int atmpt = 0;
            int num;
            do
            {
                num = r.Next(1, 11);
                Console.WriteLine(num);
                atmpt++;
            } while (num != 7);
            Console.WriteLine($"Потребовалось попыток: {atmpt}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
