using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTemperatura
{
    internal class ClsProgram
    {
        /// <summary>
        /// 21/02/2023
        /// jaider Andres Oquendo Zapata
        /// Programa para segun la temperatura ingresada pasar la temperatura de grados celsius a farenheit y viceversa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args )
        {
            Console.WriteLine( "Por favor segun sea el tipo de temperatura ingrese el numero indicado: " );
            Console.WriteLine( "1: grados celsius." );
            Console.WriteLine( "2: grados farenheit." );
            int TipoTemperatura = Convert.ToInt16( Console.ReadLine() );
            Console.WriteLine( "Por favor ingrese la temperatura " );
            double temperatura = Convert.ToDouble( Console.ReadLine() );

            //estructura de desicion logica para saber que metodo utilizar segun la temperatura ingresada.
            if (TipoTemperatura==1)
            {
               
                Console.WriteLine( "La temperatura en grados farenheit es: " +  Celsius_Farenheit( temperatura ) ); ;

            }
            else if (TipoTemperatura==2)
            {
                
                Console.WriteLine( "La temperatura en grados celsius es: " + Farenheit_Celsius( temperatura ) ); ;

            }

            
            Console.ReadKey();

        }
        
            //metodos
        static double Celsius_Farenheit(double temperatura)
        {
            double Farenheit = (temperatura * 9 / 5) + 32;
            return Farenheit;
        }
        static double Farenheit_Celsius(double temperatura)
        {
            double Celsius = (temperatura - 32 ) * 5/9;

            return Celsius;
        }
    }
}
