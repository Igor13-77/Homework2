// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int d = n;
if (n < 100)
    Console.WriteLine($"{n} -> третьей цифры нет ");
else
{
    while (n > 999)
    {
        n = n / 10;
    }
    int result = n % 10;
    Console.WriteLine($"{d} -> {result} ");
}
