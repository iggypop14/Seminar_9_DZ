// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
void Recurse(int M, int N)
{
    if (M > N)
    {
        System.Console.Write($"\nСумма натуральных чисел равна: {sum} \t");
        return;
    }
    System.Console.Write($"{M} ");
    sum = sum + M;
    Recurse(M + 1, N);
}
//////////////////////////////////////////////////////////////////////////////

int numberM = ReadInt("Введите число: ");
int numberN = ReadInt("Введите число: ");

if (numberM < numberN)
{
    Recurse(numberM, numberN);
}
else
{
    Recurse(numberN, numberM);
}