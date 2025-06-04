namespace lab4t5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в двоичной системе: ");
            string bin = Console.ReadLine();
            int decNum = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                char digitChar = bin[i];
                if (digitChar != '0' && digitChar != '1')
                {
                    Console.WriteLine("Ошибка: число должно содержать только 0 и 1!");
                    return;
                }
                int digit = digitChar - '0';
                decNum = decNum * 2 + digit;
            }
            Console.WriteLine($"В десятичной системе: {decNum}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
