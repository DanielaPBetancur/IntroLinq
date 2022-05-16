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
                                let ganancias = (l.Precio * s.Ventas)
                                select new
                                {
                                    TituloSeleccionado = l.Titulo,
                                    Ganancias = ganancias

                                };


            foreach (var item in TitulosLibros)
            {
                Console.WriteLine($" titulo :{item.TituloSeleccionado} paginas: {item.Ganancias}");
            }

            Console.ReadKey();

        }
    }
}