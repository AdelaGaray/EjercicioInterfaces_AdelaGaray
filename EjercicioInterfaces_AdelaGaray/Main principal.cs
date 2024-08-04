//Aqui se estara ejecutando la clase del main principal/// 
// Realizaremos el main que sera donde se imprime la informacion ///
using System;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperaciones operaciones = new Operaciones();

            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado del cubo:");
            double lado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho del rectángulo:");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el alto del rectángulo:");
            double alto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el radio del cilindro:");
            double radioCilindro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del cilindro:");
            double alturaCilindro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Calcular y mostrar resultados
            double areaCirculo = operaciones.CalcularAreaCirculo(radio);
            operaciones.Imprimir(areaCirculo);

            double longitudCircunferencia = operaciones.CalcularLongitudCircunferencia(radio);
            operaciones.Imprimir(longitudCircunferencia);

            double volumenCubo = operaciones.CalcularVolumenCubo(lado);
            operaciones.Imprimir(volumenCubo);

            double areaRectangulo = operaciones.CalcularAreaRectangulo(ancho, alto);
            operaciones.Imprimir(areaRectangulo);

            double volumenCilindro = operaciones.CalcularVolumenCilindro(radioCilindro, alturaCilindro);
            operaciones.Imprimir(volumenCilindro);

            Console.ReadLine(); // Mantener la ventana abierta
        }
    }
}



