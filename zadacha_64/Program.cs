// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Recursion(int number, int count)
{
    if (number > 1)
    {
        Recursion(number - 1, count + 1);
    }
    System.Console.Write(count + " ");
}
int count = 1;
Console.Write("Введите число А: ");
int number = int.Parse(Console.ReadLine());
Recursion(number, count);
