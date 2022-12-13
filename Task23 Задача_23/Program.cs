// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125 


int number = 0;
while (number < 1)
{
Console.WriteLine("Enter an integer");
number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Not valid value. Try again.");
}

int CubeTable(int num) //не смогла сдлелать метод через string, пришлось через int, иначе не работало
{
    int count = 1;
        while(count <= num)
    {
        Console.WriteLine($"{count} | {count * count * count}");
        count++;
        
    }
    return count; // почему-то у меня лишняя цифра выходит...
   
}

int cubeTable = CubeTable(number);
Console.WriteLine(cubeTable);

// Переделала "по шаблону" решение Замараева Алексея, все понятно, когда читаешь, но не запоминается что к  чему
// и  потому самостоятельно так написать не могу. Идея с table интересная, но пока я не усвоила этот 
//вариант записи переменной к тому же непонятно почему складывается значение table

//int number = 0;
// while (number < 1)
// {
//     Console.WriteLine("Enter an integer");
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number < 1) Console.WriteLine("Not valid value is entered.");
// }

// string CubeTable(int num) //лучше стринг (потом может быть пойму, почему...)
// {
//     int count = 1;
//     string table = ""; //"" - это пустота, куда мы можем помещать значение из цикла снизу - запомнить
//     while(count <= num)
//     {
//         table = table + $"{count}|{count*count*count} \n"; // \n - переводит на нов строку - запомнить
//         count++;
//     }
//     return table;
// }

// string cubeTable = CubeTable(number);
// Console.WriteLine(cubeTable);