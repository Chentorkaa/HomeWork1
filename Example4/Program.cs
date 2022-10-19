Console.WriteLine("Введите значение а");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b");
int Number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение c");
int Number3 = int.Parse(Console.ReadLine());

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int max = Max(Number1, Number2, Number3);
Console.WriteLine($"{max} max");