using System;
using System.Collections.Generic;
using System.Linq;

namespace Chromatek
{
    public class Help
    {
        /// <summary>
        /// Рекурсивный метод получения последовательности из списка символов.
        /// </summary>
        /// <param name="listChar">Входной список символов.</param>
        /// <returns>Возвращает список строк.</returns>
        public static IList<string> СalculateTransposition(IEnumerable<char> listChar)
        {
            // Признак окончания рекурсии
            if (listChar.Count() == 0)
            {
                return new string[] { "" };
            }

            // Проходим все символы
            return listChar
                .Select((ch, index) => (Char: ch, Number: index))
                .Distinct(new TupleComparer())
                .Select(pair =>
                {
                    // Убираем символ из множества и отдаём полученное множество на следующую рекурсию
                    return СalculateTransposition(listChar.Where((ch, index) => index != pair.Number))
                            .Select(str => pair.Char + str); // Получение строки
                })
                // Деструктурируем список списков
                .Aggregate(new List<String>(), (listAcc, listIn) =>
                {
                    listAcc.AddRange(listIn);
                    return listAcc;
                });
        }

        class TupleComparer : IEqualityComparer<(char Char, int Number)>
        {
            public bool Equals((char Char, int Number) b1, (char Char, int Number) b2) => b1.Char == b2.Char;

            public int GetHashCode((char Char, int Number) bx) => bx.Char.GetHashCode();
        }
    }
}