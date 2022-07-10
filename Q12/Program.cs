using System;
using System.IO;
using System.Collections;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = new[]
            {
              "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
              1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
            };
            var arraylist = new ArrayList();

            foreach (var number in numbers)
            {
                // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
                arraylist.Add(months[number - 1]);

                // добавляем его порядковый номер
                arraylist.Add(number);
            }

            foreach (var value in arraylist)
                Console.WriteLine(value);
        }

    }
}