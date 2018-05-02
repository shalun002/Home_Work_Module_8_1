using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Module;


/// <summary>
/// 1.	Создать индексатор для одномерного массива который при установке значения будет возводить в квадрат передаваемое значение переменной
/// и устанавливать его для указанного индекса. При получении элемента массива по индексу будет возвращаться его текущее значение.
/// </summary>


namespace Module_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Index index = new Index(3);
            index[0] = 4;
            index[1] = 8;
            index[2] = 10;

            for (int i = 0; i < index.Size; i++)
            {
                Console.Write(index[i] + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}