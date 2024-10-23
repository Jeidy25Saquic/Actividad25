class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> listNombres = new LinkedList<string>();
        string opcion = "";
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1. Ingrese un nombre");
                Console.WriteLine("2. Buscar nombre");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese un nombre: ");
                        string nombre = Console.ReadLine();
                        listNombres.AddFirst(nombre);
                        Console.WriteLine("Nombre ingresado correctamente.");
                        break;

                    case "2":
                        Console.Write("Ingrese el nombre que desea buscar: ");
                        string buscar = Console.ReadLine().ToLower();
                        Console.WriteLine(Buscar(buscar, listNombres));
                        
                        break;

                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }


                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != "3");


        static string Buscar(string nombre, LinkedList<string> Nombres)
        {
            foreach (var item in Nombres)
            {
                if (item == nombre)
                {
                    return $"El nombre '{nombre}' fue encontrado en la lista.";
                }
            }
            return $"El nombre '{nombre}' no se encontró en la lista.";
        }

    }
}