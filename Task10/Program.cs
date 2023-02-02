// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

while ((n<100) || (n>=1000))
{
    Console.Write("Вы ошиблись!\nВведите трёхзначное число n: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int result = (n / 10) % 10;
Console.WriteLine($"{n} -> {result} ");
