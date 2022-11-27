// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


//Самостоятельное решение, косячное, что-то не работает //Program.cs(18,11): error CS0019: 
//Оператор "+" невозможно применить к операнду типа "bool" и "int".
// Console.WriteLine("Enter 2 integers to see if the 1st one is a multiple of the 2nd and to find out remainder in case if it is not multiple.");
// Console.WriteLine("Enter first number:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number:");
// int b = Convert.ToInt32(Console.ReadLine());

// bool Multiplicity(int num1, int num2)
// {
//    if (num1 % num2 == 0) return true;
//    return false + num1 % num2; 
// }

// bool result = Multiplicity(a, b);
// Console.WriteLine(Multiplicity);




//Решение из вэбинара, Работает, вариант через Бул - верно, ложно. 
//Console.WriteLine("Enter 2 integers to see if the 1st one is a multiple of the 2nd and to find out remainder in case if it is not multiple.");
//  Console.WriteLine("Enter first number:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number:");
// int b = Convert.ToInt32(Console.ReadLine());

// bool Multiplicity(int num1, int num2)
// {
//    if (num1 % num2 == 0) return true;
//    return false;
// }

// bool result = Multiplicity(a, b);
// Console.WriteLine(result ? "Multiple" : $"Not multiple, remainder = {a % b};");

Console.WriteLine("Enter 2 integers to see if the 1st one is a multiple of the 2nd and to find out remainder in case if it is not multiple.");
 Console.WriteLine("Enter first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int b = Convert.ToInt32(Console.ReadLine());

 bool Multiplicity(int num1, int num2)
{
    return num1 % num2 == 0; //Вернет также либо правда, когда 0, либо ложь, если не 0.
}

int Multiplicity2(int num1, int num2)
{
   return num1 % num2;
}

bool result = Multiplicity(a, b);
Console.WriteLine(result ? "Multiple" : $"Not multiple, remainder = {a % b};");

// int result2 = Multiplicity2(a, b);
// Console.WriteLine(result2 ==0 ? "Multiple" : $"Not multiple, remainder = {result2};");