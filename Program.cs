using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Elevar_al_cuadrado
{
    class Program
    {
        class cuadrado
        {
            public double Num;
            public double Res;
            public cuadrado(double Num)
            {
                this.Num = Num;
            }
            public double calcular()
            {
                return this.Res = Math.Pow(Num, 2);
            }
            public void resultado()
            {
                Console.WriteLine("Elevado al cuadrado es: " + this.Res);
            }
            ~cuadrado()
            {
                Console.WriteLine("Memoria liberada cuadrado");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un numero o una cifra: ");
                double Num = double.Parse(Console.ReadLine());
                cuadrado e1 = new cuadrado(Num);

                Console.Clear();


                e1.calcular();
                e1.resultado();
                Console.WriteLine("Oprima ENTER para continuar");
            }
            catch (Exception error)
            {
                Console.WriteLine("Ha ocurrido un error " + error.Message);
            }
            Console.ReadKey();
        }
    }
}
