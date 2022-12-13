//Программа принимает 
// 1.на вход координаты(X, Y)? причем 
// 2. X не=0 Y не=0 и 
// 3. dыдает номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Enter coordinates of a point");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}
string quarter = Quarter(x, y);
string result = quarter > 0
     ? $"The coordinates correspond to quarter number --> {quarter}"
     : "Coordinates are not valid";
Console.WriteLine(result);     