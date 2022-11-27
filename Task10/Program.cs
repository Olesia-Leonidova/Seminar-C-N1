//11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого 
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.WriteLine("This program is supposed to show a random 3 digits number and to remove 2nd digit.");
int number = new Random().Next(100, 1000);
Console.WriteLine($"Random 3 digit number  --> {number}");

int RemoveSecondDigit(int num)
{   int firstDigit = num / 100; // num работает только внутри функции
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}
int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Number after 2nd digit removal --> {removeSecondDigit}");