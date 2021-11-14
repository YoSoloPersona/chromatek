using System;
using System.Collections.Generic;

namespace Chromatek
{
    /// <summary>
    /// Напишите консольное приложение на C#. В консоль вводится произвольная строка. Задача - вывести в консоль все комбинации символов из введённой строки БЕЗ ПОВТОРОВ (предыдущее значение не запоминается). В конце вывести количество найденных комбинаций.
    ///    abc
    ///    acb
    ///    bac
    ///    bca
    ///    cab
    ///    cba
    ///    Количество: 6
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Считываем строку и получаем перестановки
            IList<string> listString = Help.СalculateTransposition(Console.ReadLine());

            // Выводим результат в консоль
            foreach (string str in listString)
            {
                Console.WriteLine(str);
            }

            // Выводим количество
            Console.WriteLine($"Количество: {listString.Count}");
            Console.ReadKey();
        }
    }
}