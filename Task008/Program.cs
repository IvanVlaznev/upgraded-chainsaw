// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int cnt = 0;
while (cnt != n || cnt == 0)
{
    if (n == 0 || n == 1 || n == -1 || n == 2 || n == -2)
    {
        Console.Write("Повторите ввод числ, ноль также является четным: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    else if (cnt % 2 == 1 && n > 0)
    {
        cnt++;
        Console.Write($" {cnt}");
    }
    else if (cnt % 2 == 0 && n > 0)
    {
        cnt++;
    }
    else if (cnt % 2 == -1 && n < 0)
    {
        cnt--;
        Console.Write($" {cnt}");
    }
    else if (cnt % 2 == 0 && n < 0)
    {
        cnt--;
    }
}
Console.WriteLine();
Console.Write("Все четные числа числа");