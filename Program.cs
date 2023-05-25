//   Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/// 456 -> 5
//  782 -> 8
//  8 -> 1 
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");

        int number = Convert.ToInt32(Console.ReadLine());
        int secondDigit = GetSecondDigit(number);
        Console.WriteLine("Вторая цифра числа: " + secondDigit);

        static int GetSecondDigit(int number)
        {
            int secondDigit = number / 10 % 10;
            return secondDigit;
        } 

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int thirdDigit = GetThirdDigit(number);

        if (thirdDigit != -1)
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        else
            Console.WriteLine("Третьей цифры нет.");


        static int GetThirdDigit(int number)
        {
            if (number >= 0 && number <= 99999999)
            {
                int thirdDigit = number / 100 % 10;
                return thirdDigit;
            }
            else
            {
                return -1; // Возвращаем -1, если число не является трехзначным
            }

        }
    }
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите цифру, обозначающую день недели (1-7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        bool isWeekend = CheckWeekend(dayNumber);
        if (isWeekend)
            Console.WriteLine("Этот день является выходным.");
        else
            Console.WriteLine("Этот день не является выходным.");

        static bool CheckWeekend(int dayNumber)
        {
            return dayNumber == 6 || dayNumber == 7;
        }
    }
}