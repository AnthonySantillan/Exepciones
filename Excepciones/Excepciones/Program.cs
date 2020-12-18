using System;
using System.Collections.Generic;

namespace Excepciones
{
    class Program
    {

        public static List<String> MiLista;
        static void Main(string[] args)
        {
           //MiLista = new List<string>();
            //acciona realizar
            try
            {
                MiLista.Add("Objeto 1");
                Console.WriteLine("Objeta agregado");

            }
            //accion en caso de que no funcione
            catch (Exception) 
            {

                Console.WriteLine("Algo sale mal");
            }
            Console.ReadLine();
        }
        
    }
}
