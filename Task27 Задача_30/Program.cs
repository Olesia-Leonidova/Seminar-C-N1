// int [] array = new int [8];
// int [] array1 = {1, 4, 5, 6};


// Random rnd = new Random(); // теперь метод случайных чисел содержится в ОБЪЕКТЕ rnd , который мы создали.
// //Можно var rnd = new Random(); тк очевидно какой тип данных справа - Random
// {
//     array[i] = rnd.Next(); // заменили это: new Random().Next() на rnd.Next()
// }

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Program starts.");
int[] array = new int[8];

void RandomArray(int[] arr)
{
    Random rnd = new Random();//Обязательно вынести за цикл создание рандомных чисел, иначе будут одинаковые
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = rnd.Next(0, 2); 
    }
}

void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"{arr1[i]}");
    }
}

RandomArray(array);
PrintArray(array);