// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumNumber (int num1, int num2, int sum)
{
    if (num1 > num2) 
    {
        Console.WriteLine($"Сумма натуральных элементов от M до N равняется: {sum}"); 
        return;
    }
    sum = sum + (num1++);
    SumNumber(num1, num2, sum);
}

int sum = 0;
Console.Write("Введите левую границу промежутка: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите правую границу промежутка: ");
int number2 = int.Parse(Console.ReadLine());
SumNumber(number1, number2, sum);