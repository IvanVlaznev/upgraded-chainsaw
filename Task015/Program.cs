// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, которая обозначает день недели: ");
int Number_of_the_day = Convert.ToInt32(Console.ReadLine());

void Which_day (int Number_of_the_day) {
  if (Number_of_the_day == 6 || Number_of_the_day == 7) {
  Console.WriteLine("(это выходной день) -> да");
  }
  else if (Number_of_the_day < 1 || Number_of_the_day > 7) {
    Console.WriteLine("Такого дня недели не существует");
  }
  else Console.WriteLine("(этот не выходной день) -> нет");
}

Which_day(Number_of_the_day);