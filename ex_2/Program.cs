// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



// double x1 = new Random().Next(-100, 100);
// double y1 = new Random().Next(-100, 100);
// double z1 = new Random().Next(-100, 100);

// double x2 = new Random().Next(-100, 100);
// double y2 = new Random().Next(-100, 100);
// double z2 = new Random().Next(-100, 100);

Console.WriteLine("Введите координаты для точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты для точки В: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));

Console.WriteLine($"Расстояние между А и В = {Math.Round(distans, 3)}");