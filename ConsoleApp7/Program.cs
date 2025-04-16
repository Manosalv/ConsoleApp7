using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
          double n1, n2, n3, n4, prom;
            Console.Write("ingrese primera nota T1(10%):");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("ingrese segunda nota: T2(20%)");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese tercera nota T3(30):");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese cuarta nota EF(40%):");
            n4 = float.Parse(Console.ReadLine());
            prom = (n1 * 0.10) + (n2 * 0.20) + (n3 * 0.30) + (n4 * 0.40);

            Console.Write("promedio:" + prom);

            if (prom >= 11.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("el alumno esta aprovado");
            }
                else
                {
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("el alumno esta desaprovado");

                }
            Console.ForegroundColor = ConsoleColor.Gray;
            }


        }

    }
    
