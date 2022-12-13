// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


//  Решал Денис, все работает...
// int n = -1;
// while (n < 1)
// {
//     Console.WriteLine("Enter a number");
//     n = Convert.ToInt32(Console.ReadLine());
//     if (n < 1) Console.WriteLine("Not valid value is entered.");
// }
// void Quarter(int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         Console.WriteLine($"Number:{count} and it's square:{count*count}");
//         count++;
//     }
// }
// Quarter(n);

// Решали Владимир, Лазарева и ещё была Ирина
Console.WriteLine("Enter a number to see a squares from 1 to this number");
int num = Convert.ToInt32(Console.ReadLine());

void Square(int n)
{
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}   {i*i}");
}
}

Square(num);


//Решение Замараева Алексея, всё работает, это более универсальн вариант, т.к. тип string может работать 
//на сайте, и еще где-то, а не только в терминале как void
// int n = -1;
// while (n < 1)
// {
//     Console.WriteLine("Enter a number");
//     n = Convert.ToInt32(Console.ReadLine());
//     if (n < 1) Console.WriteLine("Not valid value is entered.");
// }
// string SqrTable(int n1)
// {
//     int count = 1;
//     string table = "";
//     while(count <=n1)
//     {
//         table = table + $"{count}|{count*count} \n"; // \n ) управляющ символ - переводит на нов строку
//         count++;
//     }
//     return table;
// }

// string sqrTable = SqrTable(n);
// Console.WriteLine(sqrTable);