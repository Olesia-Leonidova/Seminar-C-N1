// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

// Ввести диапазон от 1 до 7, если выходит за диапазон 10, 12 или -4 - сообщить пользователю,
// а далее проводим проверку значений от 1 до 7 : 6 и 7 - выходной, а ОСТАЛЬНЫЕ нет, будние дни
// Применяем функции (методы)

Console.WriteLine("Write a week-day using a number from 1 to 7, where 1 is Monday and 7 is Sunday to see if it is a day-off:");
int day = Convert.ToInt32(Console.ReadLine());

if(0 < day & day < 8)
{
if(0 < day & day < 6) Console.WriteLine("No, it is not a day off.");
else Console.WriteLine("Yes, it is a day-off.");
}
else Console.WriteLine("Not valid value.");


