// 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int A, int B)
{
    int multi = 1;
    int i = 0;
    while (i < B)
    {
        multi = multi * A;
        i++;
    }
    return multi;
}

Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetDegree(A,B));