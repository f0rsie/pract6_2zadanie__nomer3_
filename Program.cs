using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Math;
using static System.Console;

namespace pract6_2zadanie__nomer3_
{
    class Program
    {
        static void Main()
        {
            try
            {
                var f = new StreamWriter("text.txt");
                WriteLine("\n\t\t\tЗапись символов в файл");
                var g = new object[10];
                for (int i = 0; i < g.Length; i++)
                {
                    Write($"Введите {i+1} символ: ");
                    g[i] = ReadLine();
                    f.Write(g[i]);
                }
                WriteLine("\n\t\t\t\tЦифры в файле: ");
                f.Close();
                var n = new StreamReader("text.txt");
                for (int i = 0; i < g.Length; i++)
                {
                    char k = (char)n.Read();
                    if (Char.IsNumber(k) == true)
                    {
                        WriteLine(k);
                    }
                }
                n.Close();
                ReadKey();
            }
            catch
            {
                WriteLine("Произошла ошибочка");
            }
        }
    }
}