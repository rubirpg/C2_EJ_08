using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ej_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me dices tu nombre: ");
            string nombre = Console.ReadLine(); //leemos el nombre y lo guardamos en la variable nombre
            Console.WriteLine("Me dices tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine()); //leemos la ciudad y lo guardamos en la variable edad

            //mostramos por pantalla 
            Console.WriteLine();
            Console.WriteLine("Te llamas {0} y tienes {1} años.", nombre, edad);
        }
    }
}