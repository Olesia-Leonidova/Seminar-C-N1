// Программа показывает возможный диапазон координат X & Y
//по заданному номеру четверти

Console.WriteLine("Enter a quarter's number to see a range of coordinates X & Y: ");
string quarter = Console.ReadLine();

string Coordinates(string quarter1)
{
if (quarter1 == "1") return "x > 0 ; y > 0";
if (quarter1 == "2") return "x < 0 ; y > 0";
if (quarter1 == "3") return "x < 0 ; y < 0";
if (quarter1 == "4") return "x > 0 ; y < 0";
return "Not valid range.";
}

string coordinates = Coordinates(quarter);
Console.WriteLine(coordinates);