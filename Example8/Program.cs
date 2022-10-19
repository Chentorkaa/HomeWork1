//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите значение а");
int Number1 = int.Parse(Console.ReadLine());
int Number2 = 0;

while (Number2 < Number1-1)
{ 
    Number2 = Number2+2;
    Console.WriteLine(Number2);
}
