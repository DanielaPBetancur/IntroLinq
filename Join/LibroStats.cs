using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinq
{
    public class LibroStats
    {
        public int Ventas { get; set; }
        public int Paginas { get; set; }
        public int  Rank { get; set; }
        public string ISBN { get; set; }


        public static List<LibroStats> GetLibros()
        {

            List<LibroStats> libros = new List<LibroStats>();

            libros.Add(new LibroStats
            {
               ISBN ="111111111",
               Paginas = 287,
               Rank = 5,
               Ventas= 2345

            });

            libros.Add(new LibroStats
            {
                ISBN = "9999999999",
                Paginas = 344,
                Rank = 6,
                Ventas = 88

            });
            libros.Add(new LibroStats
            {
                ISBN = "333333333333",
                Paginas = 678,
                Rank = 1,
                Ventas = 3434

            });
            libros.Add(new LibroStats
            {
                ISBN = "888888888888888",
                Paginas = 0097,
                Rank = 4,
                Ventas = 6767

            });
            libros.Add(new LibroStats
            {
                ISBN = "333333333333",
                Paginas = 111,
                Rank = 2,
                Ventas = 345

            });
            libros.Add(new LibroStats
            {
                ISBN = "7777777777",
                Paginas = 999,
                Rank = 4,
                Ventas = 6778

            });
            libros.Add(new LibroStats
            {
                ISBN = "6666666",
                Paginas = 888,
                Rank = 1,
                Ventas = 232323

            });

            return libros;

        }
    }
}
