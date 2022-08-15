using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PERTENECEN A LA FAMILIA PERSONA
            //Persona > Lider > Developer > Tester 
            //Creo una lista de developer. 
            Persona p1 = new Persona();
            Developer d1 = new Developer();
            Developer d2 = new Developer();
            Developer d3 = new Developer();
            d1.Nombre = "Pepe";
            d2.Nombre = "Jorge";
            d3.Nombre = "Maria";
            

            List<Developer> listaDevelopers = new List<Developer>();
            listaDevelopers.Add(d1);
            listaDevelopers.Add(d2);
            listaDevelopers.Add(d3);
            Console.WriteLine("La cantidad de developers son: " + listaDevelopers.Count);
            listaDevelopers[1].Nombre = "Soledad";
            d2.Nombre = "Raul";
            Console.WriteLine("El nombre es: " + listaDevelopers[1].Nombre);

            Console.ReadKey();

        }
    }
}
