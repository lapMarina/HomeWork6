using System;

namespace HomeWord6
{
    class Program
    {
        static void FirstTask() 
        {
            Console.WriteLine("Введите 10 целых чисел");
            var input_string = Console.ReadLine();
            var separators = new char[2] { ' ', ',' };
            var str_elements = input_string.Split(separators);
            var count_positive_numbers = 0;
            foreach (var element in str_elements) 
            {
                var number = int.Parse(element);
                if (number > 0)
                    count_positive_numbers++;
            }
            Console.WriteLine($"Количество чисел больше 0: {count_positive_numbers}");
        }

        static void Main(string[] args)
        {
            FirstTask();
        }
    }
}
