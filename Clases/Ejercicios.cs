using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad1_ED_MariaLimon.Clases
{
    internal class Ejercicios
    {
        //public int TablaMultiplicar(int numero, int contador)
        //{
            
        //}

        public void IntervaloNumeros (int numero1, int numero2)
        {
            if (numero1 != numero2)
            {
                if(numero1 <= numero2)
                {
                    while (numero1 < numero2)
                    {
                        Console.WriteLine($"la secuencia de numeros es {numero1++}");
                    
                    }
                }
                while (numero1 >= numero2)
                {
                    Console.WriteLine($"la secuencia de numero es {numero1--}");
                }
                
            }
            Console.WriteLine ("los numeros son iguales");
            
        }
    }
}
