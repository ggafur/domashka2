// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

string getDistance()
{
Console.Write("Введите X координату первой точки ");
int firstX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату первой точки ");
int firstY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату первой точки ");
int firstZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X координату второй точки ");
int secondX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату второй точки ");
int secondY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату второй точки ");
int secondZ = Convert.ToInt32(Console.ReadLine());
double distance = Math.Round(Math.Sqrt(Math.Pow(firstX-secondX, 2)+Math.Pow(firstY-secondY, 2)+Math.Pow(firstZ-secondZ, 2)), 2);
return $"расстояние между двумя точками в 3D пространстве {distance}";
}
try
{
Console.WriteLine(getDistance());
}
catch
{
Console.WriteLine("Необходимо вводить коортинаты целыми числами");
}
