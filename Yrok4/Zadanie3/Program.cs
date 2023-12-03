//  Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

public class Program
{

    public static void Main (string[] args)
    {

        int[] numbers = {1, 2, 7, 9, 9, 3, 2};
        int size = numbers.Length;

        Console.WriteLine("Исходный массив: ");
        foreach (int number in numbers)
        {
            Console.Write (number + " ");
        }
        for (int i = 0; i < size/2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[size - i - 1];
            numbers[size - i - 1] = temp;
        }
        Console.WriteLine("\nПеревернутый массив:");
        foreach (int element in numbers)
        {
            Console.Write(element + " ");
        }
    }
}