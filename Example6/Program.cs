//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите значение ");
int Number1 = int.Parse(Console.ReadLine());

if (Number1%2==0)
{ 
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}