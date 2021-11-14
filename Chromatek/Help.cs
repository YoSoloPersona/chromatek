using System;
using System.Collections.Generic;
using System.Linq;

namespace Chromatek
{
    public class Help 
{
    /// <summary>
        /// Рекурсивный метод получения перестановки из списка символов.
        /// </summary>
        /// <param name="listChar">Входной список символов.</param>
        /// <returns>Возвращает список строк.</returns>
        public static IList<string> СalculateTransposition(IEnumerable<char> listChar)
        {
                // Через рекурсию получаем необходимые результаты
                return Calculate(
                    listChar.Distinct() // Оставляем уникальные символы
                    );
        }

        /// <summary>
        /// Рекурсивный метод.
        /// </summary>
        /// <param name="listChar"></param>
        /// <returns></returns>
        private static IList<string> Calculate(IEnumerable<char> listChar)
        {
            // Признак окончания рекурсии
            if (listChar.Count() == 0)
            {
                return new string[] { "" };
            }

            // Проходим все символы
            return listChar.Select(ch =>
            {
                // Убираем символ из множества и отдаём полученное множество на следующую рекурсию
                return Calculate(listChar.Except(new char[] { ch }))
                        // Получение строки
                        .Select(str => ch + str);
            }
            )
                // Деструктурируем список списков
                .Aggregate(new List<String>(), (listAcc, listIn) =>
                {
                    listAcc.AddRange(listIn);
                    return listAcc;
                });
        }
}
}