//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
//456 -> 46
//782 -> 72
//918 -> 98

    int number = new Random().Next(100, 1000);
    int Digit3 = number % 10;
    int Digit1 = number / 100;
    System.Console.WriteLine($"Выпало числол {number}"); 
    System.Console.WriteLine($"Число без второй цифры {Digit1}{Digit3}"); 