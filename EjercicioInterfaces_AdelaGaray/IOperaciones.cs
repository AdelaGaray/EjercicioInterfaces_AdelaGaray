// En esta interfaz proporcionaremos la interfaz operaciones//
using System;


namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        double CalcularAreaCirculo(double radio);
        double CalcularLongitudCircunferencia(double radio);
        double CalcularVolumenCubo(double lado);
        double CalcularAreaRectangulo(double ancho, double alto);
        double CalcularVolumenCilindro(double radio, double altura);
        void Imprimir(double volumenCilindro);
    }
}

