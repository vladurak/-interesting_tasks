using System;

namespace выхи_охранника
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Охранник на предприятии должен отработать за апрель 6 суток (с 00:00 по 23:59). 
             Выведите все способы расстановки этих 6 суток в формате 00100111000, где 1 – 
            выходной, 0 – рабочий день. Охранник может работать и 6 суток подряд.
             В Апреле любого года всегда 30 дней.
            */
            Console.WriteLine("-----------------------------------------------");
            int weekend_first = 0, weekend_second = 1, weekend_third = 2, weekend_fourth = 3, weekend_fifth = 4, weekend_sixth = 5;

            while (true)
            {
                char[] str = new char[30] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', };
                str[weekend_first] = '0';
                str[weekend_second] = '0';
                str[weekend_third] = '0';
                str[weekend_fourth] = '0';
                str[weekend_fifth] = '0';
                str[weekend_sixth] = '0';

                weekend_sixth++;
                if (weekend_sixth == 30)
                {
                    weekend_fifth++;
                    weekend_sixth = weekend_fifth + 1;
                }

                if (weekend_fifth ==29)
                {
                    weekend_fourth++;
                    weekend_fifth = weekend_fourth + 1;
                    weekend_sixth = weekend_fifth + 1;
                }
                if (weekend_fourth == 28)
                {
                    weekend_third++;
                    weekend_fourth = weekend_third + 1;
                    weekend_fifth = weekend_fourth + 1;
                    weekend_sixth = weekend_fifth + 1;
                }

                if (weekend_third == 27)
                {
                    weekend_second++;
                    weekend_third = weekend_second + 1;
                    weekend_fourth = weekend_third + 1;
                    weekend_fifth = weekend_fourth + 1;
                    weekend_sixth = weekend_fifth + 1;
                }

                
                if (weekend_second == 26)
                {

                    weekend_first++;
                    weekend_second = weekend_first + 1;
                    weekend_third = weekend_second + 1;
                    weekend_fourth = weekend_third + 1;
                    weekend_fifth = weekend_fourth + 1;
                    weekend_sixth = weekend_fifth + 1;
                }
                
                for (int i = 0; i<str.Length;i++)
                {
                    Console.Write(str[i] + " ");
                }

                if(str[29] == '0' && str[28] == '0' && str[27] == '0' && str[26] == '0' && str[25] == '0' && str[24] == '0')
                {
                    break;
                }
                

                Console.WriteLine();
            }
        }
    }
}