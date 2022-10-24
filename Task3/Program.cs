//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
//645 -> 5
//78 -> третьей цифры нет
//326792 -> 6

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 100)
    {
        System.Console.WriteLine("Третей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите число:");

if(ValidateNumber(number))
    {
        while(number >= 1000)
        {
           number=number/10;
        }
               
        int Digit = number  % 10;
        System.Console.WriteLine($"Третья цифра равна {Digit}"); 
    }