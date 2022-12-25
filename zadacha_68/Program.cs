// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AckermanFunction(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else if ((number1 != 0) && (number2 == 0))
    {
        return AckermanFunction(number1 - 1, 1);
    }
    else
    {
        return AckermanFunction(number1 - 1, AckermanFunction(number1, number2 - 1));
    }
}

int EnterNUmber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberM = EnterNUmber("Введите значение M: ");
int numberN = EnterNUmber("Введите значение N: ");
int result = AckermanFunction(numberM, numberN);
System.Console.WriteLine($"Функция Аккерамана для чисел ({numberM},{numberN}) равна {result}");