using System;

namespace пр4_з_7
{
    class Program

    {
        public static void Main(string[] args)
        {

            try
            {

                int number, i = 1, a = 0, result = 0;
                Console.WriteLine("Введите количество чисел в сумме: "); 
                number = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("\nЧисла, удовлетворяющие условиям задачи: "); 
                while (i <= number)
                {   
                    a = i;            
                    i++;
                    if (a % 5 == 2 || a % 3 == 1)
                    { 
                      
                        result += a;         
                        Console.Write(a + ", "); 
                    }
                }
                Console.WriteLine("\n"); 

                Console.WriteLine("Сумма выведенных чисел = " + result); 
            }
            catch
            {
                Console.WriteLine("Ошибка! Надо ввести натуральное число!");
            }
        }
    }
}