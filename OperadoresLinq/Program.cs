namespace IntroLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Libro> Libros = Libro.GetLibros();


            //Operadores matematicos
            var count = Libros.Count();
            var suma = Libros.Sum(x => x.Precio);
            var maximo = Libros.Max(x => x.Precio);
            var minimo = Libros.Min(x => x.Precio);
            var media = Libros.Average(x => x.Precio);

            //Operadores miembro

            var toma = Libros.Take(2); // toma tantos elements como le digamos
            var salta = Libros.Skip(5); // se usa para paginados
            var tomaYsalta = Libros.Skip(2).Take(3);
            var vuelta = Libros.Reverse<Libro>(); // como esté ordenado se da la vuelta
            Console.WriteLine(Libros.Reverse<Libro>());
            var primero = Libros.First();
            var primerooNulo = Libros.FirstOrDefault();
            var elementoPosicion = Libros.ElementAt(4);
            var ultimo = Libros.Last();
            var single = Libros.Single(x => x.ISBN.Contains("22")); // trae el primer elemento que encuentre que contenga el 22
            var alguno = Libros.Any(); // devuelve boleano
            var condicionTodos = Libros.All(x => x.Titulo.Length > 0);

            //comprueba si existen objetos y sino los crea
            var contiene = Libros.Contains(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "111111",
                Precio = 12.2m,
                Titulo = "asdkjkd"
            });





        }
    }
}