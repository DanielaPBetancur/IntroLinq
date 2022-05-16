

namespace IntroLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> Libros = Libro.GetLibros();

            // usando consultas linq
            var titulosLibros = from l in Libros select l.Titulo;

            // usando expresiones lambda

            var titulos = Libros.Select(l => l.Titulo);

            var ISBNs = Libros.Select(s => s.ISBN);

            var fechaSalida = Libros.Where(s => s.FechaSalida > DateTime.Now.AddYears(-2)).Select(x => x.Titulo);

            var tituloCorto = Libros.Where(s => s.Titulo.Length < 10 ).Select(x => x.Titulo);


            var claseAnonima = Libros.Select(x => new
            {
                Titulo2 = x.Titulo,
                FechaAuxiliar = x.FechaSalida
            });

            foreach (var item in claseAnonima)
            {
                Console.WriteLine($"valor titulo2 :{item.Titulo2} valor fecga: {item.FechaAuxiliar}");
            }

            Console.ReadKey();


        }
    }
}