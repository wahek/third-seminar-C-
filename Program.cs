
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Последовательно введите координаты точки 1: ");
// int x0 = int.Parse(Console.ReadLine());
// int y0 = int.Parse(Console.ReadLine());
// int z0 = int.Parse(Console.ReadLine());
// Console.WriteLine("Последовательно введите координаты точки 2: ");
// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int z1 = int.Parse(Console.ReadLine());

// if (x0 == 0 && y0 == 0 && z0 == 0 && x1 == 0 && y1 == 0 && z1 == 0) Console.Write("Обе точки вначале координат");

// else{
// double distance = Math.Sqrt((Math.Pow(x1 - x0, 2)) + Math.Pow(y1 - y0, 2) + Math.Pow(z1 - z0, 2));
// Console.Write($"Расстояние между точками = {distance}");
// }
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < num; i++ ){
    double sqr = Math.Pow(i, 3);
    Console.Write(sqr+" ");
}