using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proeyecto13._6
{
    class Program
    {
        public class Operaciones
        {
            private float valor1, valor2;

            public void Cargar()
            {
                Console.Write("Dame el primer valor: ");
                valor1 = float.Parse(Console.ReadLine());

                Console.Write("Dame el segundo valor: ");
                valor2 = float.Parse(Console.ReadLine());
            }

            public void Suma() 
            {
                float suma = valor1 + valor2;
                Console.WriteLine("La suma es "+suma);
            }

            public void Resta()
            {
                float Resta = valor1 - valor2;
                Console.WriteLine("La resta es " + Resta);
            }

            public void Multiplicacion()
            {
                float multiplicacion = valor1 * valor2;
                Console.WriteLine("La multiplicacion es " + multiplicacion);
            }

            public void Division()
            {
                float division = valor1 / valor2;
                Console.WriteLine("La divison es " + division);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Operaciones operacion = new Operaciones();
                operacion.Cargar();
                operacion.Suma();
                operacion.Resta();
                operacion.Multiplicacion();
                operacion.Division();
            }
            catch (Exception)
            {
                Console.ReadLine();                
            }
            Console.ReadKey();
        }
    }
}
