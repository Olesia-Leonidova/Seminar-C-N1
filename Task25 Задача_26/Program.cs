// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//Моё решение:
Console.WriteLine("Enter a number to see it's quantity of digits");
int number = Convert.ToInt32(Console.ReadLine());

int DigitQuantity(int num)
{
    int count = 1;
    while (num >= 10) // Вероятно,я сделала не очень читаемо,т.к. непонятно откуда 10. А может и понятно...
    {
        num = num / 10;
        count++;
    }
    return count;
}

if(number < 0) number = -number; //приводим к модулю число, то есть делаем его положительным.
int digitQuantity = DigitQuantity(number);
Console.WriteLine(digitQuantity);


//Так решили ребята в основном зале:

// int NumLength(int num)
// {
// int n = 1;
// for (int i = 0; i < 10; i++)
// {
//     num = num / 10;
//     if(num != 0) n++;
// else break;
// }
// return n;
// }
// int numLength = NumLength (number);
// Console.WriteLine(numLength);

// Здесь счетчик for не работает в его классическом варианте, и переменная i не учитывается, плюс тут
// break принудительно останавливает итерации,  через брейк выходит из цикла. Так делать нельзя. Счтчик i 
// внутри нигде не учавствует. и смысла в нем никакого получается нету. В данном случае цикл бесконечный, тк
// i не меняется, к тому же ограничен 10Ю итерациями, в общем здесь 10 - это магическое число получилось!
// Не совсем логично здесь всё, но в общем оно все равно работает, даже такое решение!!


// Так решили в 3ем зале:
// Тарас: // Напишите программуБ которая принимает на вход число и выдает количество цифр.

// Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0)
// {
//     Console.WriteLine(Digits(number));
// }
// else
//     Console.Write("число меньше 0 ");

// int Digits(int num)
// {
//     int result = 0;
//     if (num > 0)
//     {
//         while (num > 0) { num = num / 10; result++; }
//     }
//     return result;
// }