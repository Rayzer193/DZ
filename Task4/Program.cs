//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 1 || number > 7)
    {
        System.Console.WriteLine("Нет дня недели с таким номером");
        return false;
    }
    return true;
}
int number = Prompt("Введите число дня недели:");

if(ValidateNumber(number))
    {
        if(number>=6)
        {
            System.Console.WriteLine("Да"); 
        }
        else
        {
            System.Console.WriteLine("Нет");
        } 
    }