using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._102_Zotochkina_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine(); // Ввод строки

            string result = NewStr(input);  // Обращение к функции NewStr

            Console.WriteLine("Результат: " + result); // Вывод результата
        }

        public static string NewStr(string s)
        {
            // Удаляем начальные и конечные пробелы из строки
            return s.Trim();
        }
    }
}
