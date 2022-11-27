// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


//if(number > 5 && number < 10)


Console.WriteLine("Enter a number to find out if it is multiple to 7 & 23:");
int numero = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num)
{
return num % 7 == 0 && num % 23 == 0;
}

bool result = Multiplicity(numero);
Console.WriteLine(result ? "Yes, the number is multiple to 7 & 23." : "Not multiple to 7 & 23");