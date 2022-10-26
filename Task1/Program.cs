//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
//14212 -> нет
//12821 -> да
//23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 10000 || number >= 100000)
    {
        System.Console.WriteLine("Число не является пятизначным");
        return false;
    }
    return true;
}
int number = Prompt("Введите пятизначное число:");

if(ValidateNumber(number))
    {
        int Digit1 = number / 10000;
        int Digit2 = number / 1000 % 10;
        int Digit4 = number / 10 % 10;
        int Digit5 = number % 10;
        if(Digit1==Digit5 & Digit2==Digit4)
        {
            System.Console.WriteLine("Да"); 
        }
        else
        {
            System.Console.WriteLine("Нет"); 
        }    
    }