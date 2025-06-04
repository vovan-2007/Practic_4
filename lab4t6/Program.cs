namespace lab4t6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в 7-ной системе: ");
            string seven = Console.ReadLine();
            int decNum = 0;
            for (int i = 0; i < seven.Length; i++)
            {
                char digitChar = seven[i];
                int digit = digitChar - '0';
                if (digit < 0 || digit > 6)
                {
                    Console.WriteLine("Ошибка: число должно содержать только цифры 0-6");
                    return;
                }
                decNum = decNum * 7 + digit;
            }
            Console.WriteLine($"В десятичной системе: {decNum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
