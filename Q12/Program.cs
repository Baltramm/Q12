using System;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = Convert.ToInt32(Console.ReadLine());
            var array = new int[count];
            for (int i= 0;i<count;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Все элементы записаны");
        }
    }
}
