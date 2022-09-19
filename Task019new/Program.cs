// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
 
void PalindromOrNot(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int reminder1 = number % 10;
 
            if(division1 == reminder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int reminder2 = number % 10;
                if(division2 == reminder2)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
    Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
PalindromOrNot(number);