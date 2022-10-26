//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int i = 1;
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());
while(i<=N)
{
    {
        Console.Write(i*i*i);
    }
        if(i<N)
        {
          Console.Write(", ");
        }
    i = i + 1;
}
