using System;

namespace _9._185
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, d;
            string s;
            char[] txt;
            Console.Write("Введите формулу:");
            s = Console.ReadLine();
            txt = s.ToCharArray();
            b = a = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == ')')
                    if (a == 0)
                    {
                        if (b == 0)
                            b = i + 1;
                        a -= 1;
                    }
                    else
                    {
                        a -= 1;
                    }

                if (txt[i] == '(')
                {
                    a += 1;
                }

            }
            if (a == 0 && b == 0)
                Console.WriteLine("Скобки расставлены верно");
            else
            {
                if (a > 0)
                    Console.WriteLine("Есть {0} лишних левых скобок", a);
                if (b > 0)
                    Console.WriteLine("На {0} позиции лишняя правая скобка", b);
            }
            Console.ReadKey();
        }
    }
}
