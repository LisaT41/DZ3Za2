// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)

{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + (Math.Pow(yb - ya, 2)) + (Math.Pow(zb - za, 2)),2));
}


Console.WriteLine("Input X coordinate for point A: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y coordinate for point A: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z coordinate for point A: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input X coordinate for point B: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y coordinate for point B: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z coordinate for point B: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between point A and point B -> {FindDistance(xa, ya, za, xb, yb, zb)}");







