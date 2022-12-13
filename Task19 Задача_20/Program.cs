// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double n = 12345;
// double res = Math.Sqrt(n);

// double n1 = 5.099985645;
// double nRound = Math.Round(n1, 2, MidpodoubleRounding.ToZero);
// Console.WriteLine(nRound);


Console.WriteLine("Enter coordinates of the 1st point");
Console.Write("Xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinates of the 2nd point");
Console.Write("Xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa1, int ya1, int xb1, int yb1)
{
double xc1 = (xa1 - xb1) * (xa1 - xb1);
double yc1 = (ya1 - yb1) * (ya1 - yb1);
double result = Math.Sqrt(xc1 + yc1);
return result;
}

double res = Distance(xa, ya, xb, yb); //неверный порядок координат давал ошибку
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);

// Сбросил Виктор в чат, считает правильно
// Console.Write("Введите точку XA: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку YA: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку XB: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку YB: ");
// int yb = Convert.ToInt32(Console.ReadLine());

// double Distance(int xa, int ya, int xb, int yb)
// {
// double xc = (xa - xb) * (xa - xb);
// double yc = (ya - yb) * (ya - yb);
// double result = Math.Sqrt(xc + yc);
// return result;
// }

// double res = Distance(xa, ya, xb, yb);
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);