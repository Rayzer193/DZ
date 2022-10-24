//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
//456 -> 5
//782 -> 8
//918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 100 || number >= 1000)
    {
        System.Console.WriteLine("Число не является трехзначным");
        return false;
    }
    return true;
}
int number = Prompt("Введите трехзначеное число:");

if(ValidateNumber(number))
    {
        int Digit = number / 10 % 10;
        System.Console.WriteLine($"Вторая цифра {number} равна {Digit}"); 
    }