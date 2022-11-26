// Задача 8
//Принимает 1 число N, а на вывод от 1 до И все ЧЁТНЫЕ числа, напимер 
// N = 9-> 2, 4, 6, 8.
//N = 6 -> 2, 4, 6

Console.WriteLine("Enter a number to see a sequence of even numbers from 1 to the entered number.");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if(N <= 1)
{
        Console.WriteLine("There is no diapazone of even numbers for entered value.");
}  
while(count <=  N)
{
    Console.Write($"{count} ");
    count += 2;    
}







