// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumDigits(int A)
{
    int result = 0;
    while (A > 0)
    {
        result = result + (A % 10);
        A = A / 10;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {N} равна {GetSumDigits(N)}.");