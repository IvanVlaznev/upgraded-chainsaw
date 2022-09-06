int num = new Random().Next(10, 100);
int firstDigit = num / 10;
int secondDigit = num % 10;

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {num} -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {num} -> {secondDigit}");