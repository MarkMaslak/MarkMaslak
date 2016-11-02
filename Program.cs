using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{
    class Program
    {

        static Pen pen;

        static void Main(string[] args)
        {
            var car = new Coche();
            car.NueumaticoCambiado += Objeto_AlgoCambiado;

            pen = new Pen();
            pen.CanaCambiada += Objeto_AlgoCambiado;
            

            for (int i = 0; i < 4; i++)
            {
                pen.Cana = i + 8;
                //car.CambioNeumatico();
            }

            Console.Read();

        }

       

        private static void Objeto_AlgoCambiado(object sender, EventArgs e)
        {
            if (e is PenEventArgs)
            {
                var arg = (PenEventArgs)e;

                //if (pen.Cana > 2)
                //    pen.Cana = 2;

                Console.WriteLine("Cana ha cambiado " + arg.Cana);
            }
            else
            {
                Console.WriteLine("Algo ha cambiado");
            }

        }
    }




 
}
