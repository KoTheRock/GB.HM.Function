// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
    bool isSumEven = false;

    while(!isSumEven)
        {
            Console.WriteLine("Ввидете целое число");
            string input = Console.ReadLine();

            if (input.ToLower() != "q")
            {
                if (int.TryParse(input, out int number))
                {
                    int sum = 0;
                    int tempNumber = number;

                    while (tempNumber != 0)
                    {
                        sum += tempNumber % 10;
                        tempNumber /= 10;
                    }
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"Сумма числа четная: {sum} ");
                        isSumEven = true;
                    }
                    else
                    {
                        Console.WriteLine($"Сумма числа нечетная: {sum} ");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            else
            {
                Console.WriteLine("Программа завершена.");
                return;
            }
        }
    }
}

