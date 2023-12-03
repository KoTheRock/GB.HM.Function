// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

public class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int size = 10;
        int[] array = new int[size];
        int countInRange = 0;

        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(99, 999);
            if (array[i] % 2 == 0)
            {
                countInRange++;
            }
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine($"Колличество четных чисел: {countInRange} ");
    }   
}  