using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricoAbs2
{
    public class Principal
    {
        //Instancie de forma global cada clase para asi utilizar los metodos existentes en cada uno de ellos
        //a excepcion de la clase operaciones debido a que no se puede instanciar una clase abstracta mas que 
        //la que les herendan.
        Cuadrado cuadrado = new Cuadrado();
        Rectangulo rectangulo = new Rectangulo();
        Triangulo triangulo = new Triangulo();
        //Se crea el metodo bienvenida para el usuario.
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenida");
            Menu();
        }
        //El menu para que el usuario pueda elegir la figura la cual sacara su perimetro y area.
        private void Menu()
        {
            Console.WriteLine(">>>Elija una opcion:");
            Console.WriteLine("\n1-.Triangulo\n2-.Cuadrado\n3-.Rectangulo");
            switch (Console.ReadLine())
            {
                case "1":
                  //Se llaman a los metodos para realizar los pases de parametros correspondientes
                    ObtenerDatosTriangulo();
                    triangulo.Calcular(triangulo.ladoa,triangulo.LadoB);
                    triangulo.Calcular(triangulo.ladoa);
                    Console.Clear();
                    break;
                case "2":
                  
                    ObtenerDatosCuadrado();
                    cuadrado.Calcular(cuadrado.ladoa);
                    cuadrado.Calcular(cuadrado.ladoa, cuadrado.LadoB);

                    Console.Clear();
                    break;

                case "3":
                    
                    ObtenerDatosRectangulo();
                   rectangulo.Calcular(rectangulo.ladoa,rectangulo.LadoB);
                    Console.Clear();
                    break;
            }
            Menu();
        }
        //Se realizan los metodos para pedir la informacion necesaria al usuario y mantener el case limpio.
        public void ObtenerDatosCuadrado()
        {
            Console.WriteLine("Ingresa lado a");
            cuadrado.ladoa = Convert.ToDouble(Console.ReadLine());
            cuadrado.LadoB = 0;

        }
        public void ObtenerDatosRectangulo()
        {
            Console.WriteLine("Ingresa base:");
            rectangulo.ladoa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa Altura:");
            rectangulo.LadoB = Convert.ToDouble(Console.ReadLine());
        }
       
        public void ObtenerDatosTriangulo()
        {
            Console.WriteLine("Ingresa base:");
            triangulo.ladoa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa Altura:");
            triangulo.LadoB = Convert.ToDouble(Console.ReadLine());
        }
    }
}
