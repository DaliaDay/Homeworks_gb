// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Hello! This is a program that calculates the distance of given coordinates between two points ");
Console.WriteLine("Please enter a number for A point coordinates A(XYZ)");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now Please enter a number for B point coordinates A(XYZ)");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double DistancePoint(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result1 = (x2 - x1)*(x2 - x1);
    double result2 = (y2 - y1)*(y2 - y1);
    double result3 = (z2 - z1)*(z2 - z1);
    double result = Math.Sqrt(result1 + result2 + result3);
    return result;
}  
Console.WriteLine(DistancePoint(x1, y1, z1, x2, y2, z2));


