// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;
int[] numbers = new int[len];
int sum = 0;
int count = 0;
while (count < len)
{
    numbers[count] = Convert.ToInt32(num[count].ToString());
    count++;
}
for (int i = 0; i < len; i++)
    sum += numbers[i];

Console.WriteLine(sum);