// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Enter a number to get a result of a sum off all numbers from one up to your number:");
int number = Convert.ToInt32(Console.ReadLine());

int SumNums(int num)
{
    int sum = 0; //либо int sum = default
    for (int i = 1; i <= num; i++)
    {
       sum = sum + i; 
    }
    return sum;
}

if(number > 0)
{
int sumNums = SumNums(number);
}
else Console.WriteLine("Not valid value.");