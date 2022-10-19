//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее (min, max).

Console.WriteLine("Введите значение а");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b");
int Number2 = int.Parse(Console.ReadLine());
int min = 0;
int max = 0;


if (Number1>Number2)
{
    Console.WriteLine($"{Number1} max");
    Console.WriteLine($"{Number2} min");
}
else
{
    Console.WriteLine($"{Number2} max");
    Console.WriteLine($"{Number1} min");
}
