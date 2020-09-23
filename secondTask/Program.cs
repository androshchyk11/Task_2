using System;


/*2.Розробка консольного додатка з різними типами даних Розробити консольний додаток де оголошуються 
 * три змінні a, b, c відповідних типів Int, double, long. Ввести ці змінні з клавіатури, 
 * та вести на екран в форматі "a = {a}; b = {b}; с = {c}". Опрацювати помилки та вивести на екран повідомлення. 
 * Додаток зберігається в проекті Task_2 в репозиторії на GitHub*/

namespace secondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть змінну типу Int ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введіть змінну типу double ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть змінну типу long ");
            long c = Int64.Parse(Console.ReadLine());

            Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c);
        }
    }
}
