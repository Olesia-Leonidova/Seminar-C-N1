
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Через целочисленное деление на 10 и остаток от деления на 10
// И проверяем если 1 число == 5ому и 2ое 4ому
// Для универсального метода нужен разворот числа, делается в цикле и после разворота сравниваем новое и исходное
// числа, если совпадают - значит полиндром.



Console.WriteLine("Enter a 5-digit number to see if it is a palindrom");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrom5(int num)
{
    int digit5 = num % 10;
    int digit4 = num / 10 % 10;
    int digit3 = num / 100 % 10;
    int digit2 = num / 1000 % 10;
    int digit1 = num / 10000;
    int numRevers = digit5*10000 + digit4*1000 + digit3*100 + digit2*10 + digit1;
    return num == numRevers;
}

bool palindrom = Palindrom5 (number);
Console.WriteLine(palindrom ? "YES. It's a palindrom number." : "NO. It is not a palindrom.");



// Наверное надо как-то черз массив это оформлять... унивепсальный метод не получается сделать..пф
// Console.WriteLine("Enter a number");
// int number = Convert.ToInt32(Console.ReadLine());

// int Palindrom(int num)
// {
//      for (int digitPos = 1; digitPos < num.Length; digitPos*10)
// {
//     while(num >= 10)    
//         {
//              digitPos = num % 10; 
//         }
//         return digitPos;
//     }
// }

//    int palindrom = Palindrom(number);
//    Console.Write(palindrom);
   

 