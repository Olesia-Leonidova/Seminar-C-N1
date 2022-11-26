// Задача 6
// На вход принимает 1 число. Выдает, является ли оно чётным

Console.WriteLine("Enter an nteger to see if it is even or odd");
int N = Convert.ToInt32(Console.ReadLine());

if(N % 2 == 0)
{
    Console.WriteLine($"Yes, the integer {N} is even");
}
else
{
    Console.WriteLine($"No.The integer {N} is not even, it's odd.");
}