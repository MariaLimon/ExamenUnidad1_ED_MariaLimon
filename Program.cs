using ExamenUnidad1_ED_MariaLimon.Clases;

namespace ExamenUnidad1_ED_MariaLimon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Dame un numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Ejercicios ejercicio1 = new Ejercicios();
            //Console.WriteLine(ejercicio1.TablaMultiplicar(numero,0));
            
            
            Console.WriteLine("dame un numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Ejercicios ejercicio2 = new Ejercicios();
            ejercicio2.IntervaloNumeros(numero1, numero2);
            
        
        }
    }
}