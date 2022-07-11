using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {


            var sentence =
    "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
            // сохраняем в массив char
            var characters = sentence.ToCharArray();

            var symbols = new HashSet<char>();

            var signs = new[] { ',', ' ', '.' };

            // сохраняем числовые символы в массив Char
            var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


            // добавляем во множество. Сохраняются только неповторяющиеся символы
            foreach (var symbol in characters)
            {
                
                symbols.Add(symbol);
            }
            bool containsNumbers = symbols.Overlaps(numbers);
            Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

            // Отбрасываем знаки препинания и заново считаем
            symbols.ExceptWith(signs);
            Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
            // Выводим результат
            Console.WriteLine(symbols.Count);

        }
    }
}