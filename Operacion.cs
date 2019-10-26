using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricoAbs2
{
    //Se crea la clase abstracta la cual sera la clase padre donde se utilizaran los datos y metodos creados y obligaran
    //a la herencia.
   public abstract class Operacion
    {
        //Se crean los atributos y metodos abstractos para que se utilizen en las clases a las que hereden. 
        public abstract double ladoa { get; set; }
        public abstract double LadoB { get; set; }
        public abstract void Calcular(double a);
        public abstract void Calcular(double a, double b);
    }
}
