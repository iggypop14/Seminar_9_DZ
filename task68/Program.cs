// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//-----------------------------------------Задание функций--------------------------------
int Ackermann(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackermann(m - 1, 1);
  else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//------------------------------------------Решение-----------------------------------------
int numberM = ReadInt("Введите число m: ");
int numberN = ReadInt("Введите число n: ");

int AkkermanResult = Ackermann(numberM, numberN);
Console.Write($"Результат вычисления функции Аккермана = {AkkermanResult} ");