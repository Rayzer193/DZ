//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
{
    Console.Write("Перове число (" + number1 + ")" + " больше второго числа (" + number2 + ")"); //Вывод если первое чилсо больше
}
if(number1 < number2)
{
    Console.Write("Второче число (" + number2 + ")" + " больше первого числа (" + number1 + ")"); //Вывод если второе чилсо больше
}
if(number1 == number2)
{
    Console.Write("Числа равны (" + number1 + ")=(" + number2 + ")"); //Вывод если чилса равны
}