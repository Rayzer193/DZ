Console.Write("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if(number1>number2)
    {
    max = number1;
    }
else
    {
    max = number2;
    }
if(max<number3)
    {
    max = number3;
    }
else
    {
    max = max;
    }

Console.WriteLine("Самое большое число: " + max);