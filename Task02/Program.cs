//Написать программу которая удет выдавать день недели по пдпнному номеру 5=пятница, 1=понедельник
// Написать что такого дня недели не существует после проверки если числа не 1,2,3,4,5,6,7

Console.Clear();
Console.WriteLine("Insert an integer from 1 to 7 to see a corresponding day of the week");


string number = Console.ReadLine();
if(number =="1") Console.Write("1st day is Monday");
else if(number =="2") Console.Write("2nd day is Tuesday");
else if(number =="3") Console.Write("3rd day is Wednesday");
else if(number =="4") Console.Write("4th day is Thursday");
else if(number =="5") Console.Write("5th day is Friday");
else if(number =="6") Console.Write("6th day is Saturday");
else if(number =="7") Console.Write("7th day is Sunday");

//int number = Convert.ToInt32(Console.ReadLine());
//if(number ==1) Console.WriteLine("Monday");
//else if(number ==2) Console.WriteLine("Tuesday");
//else if(number ==3) Console.WriteLine("Wednesday");
//else if(number ==4) Console.WriteLine("Thursday");
//else if(number ==5) Console.WriteLine("Friday");
//else if(number ==6) Console.WriteLine("Saturday");
//else if(number ==7) Console.WriteLine("Sunday");

else Console.WriteLine("The inserted number doesn't match any day of the week!");