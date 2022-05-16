
using System.Linq;

namespace IntroLinq


{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> Libros = Libro.GetLibros();

            // usando consultas linq
            var librosListado = from l in Libros ;
        }
    }
}