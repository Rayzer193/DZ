//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int x1 = Prompt("Введите координату X первой точки: ");
int y1 = Prompt("Введите координату Y первой точки: ");
int z1 = Prompt("Введите координату Z первой точки: ");
int x2 = Prompt("Введите координату X второй точки: ");
int y2 = Prompt("Введите координату Y второй точки: ");
int z2 = Prompt("Введите координату Z второй точки: ");
int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;
double rast = Math.Sqrt(x*x+y*y+z*z);
Console.WriteLine($"Растояние между точками равно {rast:f2}");