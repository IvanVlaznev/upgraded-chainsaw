// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int any_Num = Convert.ToInt32(Console.ReadLine());
string any_Num_Text = Convert.ToString(any_Num);
if (any_Num_Text.Length > 2){
  Console.WriteLine("третья цифра -> " + any_Num_Text[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}