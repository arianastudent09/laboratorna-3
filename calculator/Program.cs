using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Calculate calculator = new Calculate();
            Console.ReadLine();

        }
    }
    class Calculate
    {
        public static string vvid, diaB = "", diaA = "", znak;
        public static double chislo, chislo1, chislo2, zbir;
        public Calculate()
        {
            Console.WriteLine("Введіть арифметичну дію: ");
            vvid = Convert.ToString(Console.ReadLine());
            char[] MassiveOfNeedElements = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+', '-', '*', '.', ',' };
            foreach (char n in vvid)
            {
                for (int i = 0; i < MassiveOfNeedElements.Length; i++)
                {
                    if (n == MassiveOfNeedElements[i])
                    {
                        zbir++;
                        if (n == '.')
                        {
                            if (chislo1 != 0)
                            {
                                diaA = diaA + ",";
                            }
                            else
                            {
                                diaB = diaB + ",";
                            }
                            continue;
                        }
                        if (n == '+' || n == '-' || n == '*')
                        {
                            chislo1 = Convert.ToDouble(diaB);
                            znak = Convert.ToString(n);
                            continue;
                        }
                        else
                        {
                            diaB = diaB + Convert.ToString(n);
                        }
                        if (znak == "+" || znak == "-" || znak == "*")
                        {
                            diaA = diaA + Convert.ToString(n);
                        }
                    }
                }
            }
            chislo2 = Convert.ToDouble(diaA);
            if (znak == "+")
            {
                SUMA();
            }
            else if (znak == "-")
            {
                VIDNIM();
            }
            else if (znak == "*")
            {
                MNOZH();
            }
        }
        public static void SUMA()
        {
            chislo = chislo1 + chislo2;
            Console.WriteLine("Ответ: " + chislo);
        }
        public static void VIDNIM()
        {
            chislo = chislo1 - chislo2;
            Console.WriteLine("Ответ: " + chislo);
        }
        public static void MNOZH()
        {
            chislo = chislo1 * chislo2;
            Console.WriteLine("Відповідь: " + chislo);
        }
    }

}
