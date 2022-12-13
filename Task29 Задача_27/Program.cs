// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter a number to see a sum of it's digits.");
int number = Convert.ToInt32(Console.ReadLine());

double SumDigits(int num)
{   
    int sum = 0;
    while(num > 0)
    {
        int digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }  
    return sum;
}

double result = SumDigits(number);

void Print(int num1)
{
   Console.Write(result);
}


SumDigits(number);
Print(number);













// double SumDigits(int num)
// {   
//     int sum = 0;
//     int i = 1;
//     while(num > 0)
//     {
//         num = num / i % 10;
//         sum = sum + num;
//         i * 10;
//     }  
//     return sum;
// }
    



 // while (num > 0)
    // {

    //  num = num % 10;
    //   sum = sum + num1;
    //   if (num1 < 0) 
    //   {
    //     int num2 = num1 / 10;
    // sum = sum + num2;
    //   }
   



// Console.WriteLine("Enter a number to see a sum of it's digits.");
// int number = Convert.ToInt32(Console.ReadLine());

// double SumDigits(int num)
// {
//     int sum = 0;
//     for (int i = 1; i < num; i++)
//         {
//             num = num % 10;
//             sum = sum + num;
//         }
//         return sum;
// }
// SumDigits(number);


