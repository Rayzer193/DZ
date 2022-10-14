Console.Write("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
{
    Console.Write("Перове число (");
    Console.Write(number1);
    Console.Write(")");
    Console.Write(" больше второго числа (");
    Console.Write(number2);
    Console.Write(")");
}
if(number1 < number2)
{
    Console.Write("Второче число (");
    Console.Write(number2);
    Console.Write(")");
    Console.Write(" больше первого числа (");
    Console.Write(number1);
    Console.Write(")");    
}
if(number1 == number2)
{
    Console.Write("Числа равны");
}
