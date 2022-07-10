using System;
using System.IO;
using System.Collections;
using System.Text;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList()
           {
               1,
               "Андрей ",
               "Сергей ",
               300,
           };
            int sum = 0;
            StringBuilder text = new StringBuilder();
            foreach (var element in arrayList)
            {
                //   если целое число - увеличиваем счётчик
                if (element is int)
                {
                    sum += (int)element;
                }

                // если строка - добавляем текст из неё
                if (element is string s)
                {
                    text.Append(element);
                }
            }

            // результат
            var result = new ArrayList() { sum, text.ToString() };

            // вывод
            foreach (var elem in result)
            {
                Console.WriteLine(elem);
            }
        }

       

    }
}