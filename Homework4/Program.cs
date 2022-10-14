//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
int i = 1;
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());
while(i<N)
{
    if(i%2 == 0)
    {
        Console.Write(i);
    }
    if(i%2 == 0 & i<N-2)
    {
        Console.Write(",");
    }
    i = i + 1;
}
