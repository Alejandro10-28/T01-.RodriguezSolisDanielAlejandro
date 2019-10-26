using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricoAbs2
{
    //Se le hereda la clase Operacion para de esa forma utilizar los atributos y metodos de la clase abstracta
    public class Cuadrado : Operacion
    {
        //Se utiliza override para extender o poder modificar la implementacion de los metodos y atributos 
        //creados en la clase abstracta en una clase que la hereda.
        public override double ladoa { get ; set ; }
        public override double LadoB { get ; set ; }

        public override void Calcular(double a, double b)
        {
            double P = a * 4;
            Console.WriteLine("El resultado del perimetro es:" + P);
            Console.ReadKey();

        }

        public override void Calcular(double a)
        {
            double A = a * a;
            Console.WriteLine("El resultado del area es :" + A);
            Console.ReadKey();

           
        }

    }
}
