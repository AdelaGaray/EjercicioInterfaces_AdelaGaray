// Realizaremos la primera clase operaciones//
using System;

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularLongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double CalcularVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public double CalcularAreaRectangulo(double ancho, double alto)
        {
            return ancho * alto;
        }

        public double CalcularVolumenCilindro(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        public void Imprimir(double resultado)
        {
            Console.WriteLine($"El resultado de la operación es: {resultado}");
        }
    }
}

