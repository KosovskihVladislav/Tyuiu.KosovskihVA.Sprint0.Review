using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KosovskihVA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0 Review                                                        *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Review                                                          *");
            Console.WriteLine("*Вариант #0                                                               *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение трех    *");
            Console.WriteLine("* чисел и умножает их на 5.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Место решения задания
            int x = 2, y = 2, z = 4;
            Console.WriteLine(DataService.Calc(x, y, z));
        }
    }
}
