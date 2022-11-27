// Программа выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру числа
// 56 -- 6, 82--8, 17 -- 7.

int number = new Random().Next(10, 100);
Console.WriteLine($"random number from the segment 10-99 --> {number}");

//Решение без метода
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"The greater digit of the number is  {firstDigit}");
// else Console.WriteLine($"The greater digit of the number is  {secondDigit}");

//ЗАКОММЕНТИРОВАЛА РАНЬШЕ//Console.WriteLine(Math.Max(firstDigit, secondDigit));//Встроенная функция, делает то же самое, что решение выше

int MaxDigit(int num) //int num = number
{
    int firstDigit = num / 10; // num работает только внутри функции
    int secondDigit = num % 10;
    //1/ if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
         
    //2/ int max = firstDigit > secondDigit ? firstDigit : secondDigit; //тернарный оператор, где ? - если, а : - иначе
    // return max;
    
    // либо через if return - 1 вариант, либо  2 вариант через тернарный оператор, либо как 
    //ниже, 3 вариант записать просто через return и написать что возвращаеv без max вообще.
    // 3й вариант - самый компактный:
     return firstDigit > secondDigit ? firstDigit : secondDigit;

}//Здесь, то что мы написали - это метод. Хорош тем, что можно вызывать эту "подпрограмму" из любого мета,
//ниже или выше. Достаточно ! раз написать и пользоваться.


int maxDigit = MaxDigit(number);
Console.WriteLine($"The greater digit of the number is --> {maxDigit}");