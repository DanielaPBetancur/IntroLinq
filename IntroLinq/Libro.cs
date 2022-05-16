using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinq
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaSalida { get; set; }


        public static List<Libro> GetLibros()
        {

            List<Libro> libros = new List<Libro>();

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "222222",
                Precio = 13.22M,
                Titulo = "LOTR"

            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "3333333333",
                Precio = 2.22M,
                Titulo = "Hobbit"

            });


            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "5555555",
                Precio = 22M,
                Titulo = "SDSD"

            });

            return libros;

        }
    }
}
