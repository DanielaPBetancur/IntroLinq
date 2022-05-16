namespace IntroLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> Libros = Libro.GetLibros();
            List<LibroStats> libroStats = LibroStats.GetLibros();


            var TitulosLibros = from l in Libros
                                join s in libroStats on l.ISBN equals s.ISBN
                                select new
                                {
                                    TituloSeleccionado = l.Titulo,
                                    PaginasLibro = s.Paginas

                                };


            foreach (var item in TitulosLibros)
            {
                Console.WriteLine($" titulo :{item.TituloSeleccionado} paginas: {item.PaginasLibro}");
            }

            Console.ReadKey();

        }
    }
}