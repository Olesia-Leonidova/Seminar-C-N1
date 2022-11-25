// промежуток от -N до N при вводе N



Console.WriteLine("Insert an integer:");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 0)
{
    int count = -N;
    {
        while (count <= N - 1)
        {
            Console.Write($"{count}, ");
            count++;
        }
            {
              Console.Write($"{count}.");
                
            }
    }
}
//else
//{
//    int count = N;
//    {
//       while (count <= -N - 1)
//        {
//            Console.Write($"{count}, ");
//            count++;
//          
//        }
//            {
//              Console.Write($"{count}.");   
//            }      
//        
//    }
//}