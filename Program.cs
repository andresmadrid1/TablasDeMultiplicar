using System;

namespace TablasDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroTablas, Tabla, Cantidad, Resultado, i;
            Cantidad = 1;
            i = 10;
            Console.WriteLine("Hola cuantas tablas de multiplicar deseas calcular?");
            NumeroTablas = int.Parse(Console.ReadLine());
            while(Cantidad<=NumeroTablas)
            {
                Console.WriteLine("Ingrese el valor numerico que desea calcular tabla de multiplicacion");
                Tabla = int.Parse(Console.ReadLine());
                Cantidad++;
                for (i=10; i >= 1; i--)
                {
                    Resultado = Tabla * i;
                    Console.WriteLine("El resultado es {0} * {1} = {2} ", Tabla, i, Resultado);
                }
                
            }
        }
    }
}
