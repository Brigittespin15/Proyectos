  class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nElige una opción:");
            Console.WriteLine("1. Mostrar números del 1 al 10 en orden inverso.");
            Console.WriteLine("2. Eliminar letras en posiciones múltiplos de 3 del abecedario.");
            Console.WriteLine("3. Verificar si una palabra es un palíndromo.");
            Console.WriteLine("4. Contar las vocales en una palabra.");
            Console.WriteLine("5. Mostrar el menor y mayor precio de una lista.");
            Console.WriteLine("6. Salir.");
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    var numeros = Enumerable.Range(1, 10).Reverse();
                    Console.WriteLine("Números en orden inverso: " + string.Join(", ", numeros));
                    break;

                case "2":
                    var abecedario = "abcdefghijklmnopqrstuvwxyz".ToList();
                    var resultado = abecedario.Where((letra, indice) => (indice + 1) % 3 != 0);
                    Console.WriteLine("Abecedario sin posiciones múltiplos de 3: " + string.Join(", ", resultado));
                    break;

                case "3":
                    Console.Write("Ingresa una palabra: ");
                    var palabra = Console.ReadLine();
                    var esPalindromo = palabra == new string(palabra.Reverse().ToArray());
                    Console.WriteLine(esPalindromo ? "Es un palíndromo." : "No es un palíndromo.");
                    break;

                case "4":
                    Console.Write("Ingresa una palabra: ");
                    var palabraVocales = Console.ReadLine().ToLower();
                    var vocales = "aeiou";
                    foreach (var vocal in vocales)
                    {
                        int conteo = palabraVocales.Count(c => c == vocal);
                        Console.WriteLine($"La vocal '{vocal}' aparece {conteo} veces.");
                    }
                    break;

                case "5":
                    var precios = new[] { 50, 75, 46, 22, 80, 65, 8 };
                    Console.WriteLine($"El menor precio es: {precios.Min()}");
                    Console.WriteLine($"El mayor precio es: {precios.Max()}");
                    break;

                case "6":
                    Console.WriteLine("Saliendo del programa...");
                    return;

                default:
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    break;
            }
        }
    }
}