//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

while ((n < 1) || (n >= 8))
{
    Console.Write("Вы ошиблись!\nВведите цифру, обозначающую день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n < 6)
    Console.WriteLine($"{n} -> нет ");
else
    Console.WriteLine($"{n} -> да ");
