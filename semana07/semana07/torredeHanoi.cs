class Program
{
    // Método para resolver las Torres de Hanói iterativamente utilizando una pila
    static void ResolverTorresDeHanoi(int discos, string inicio, string fin, string apoyo)
    {
        // Crear una pila para gestionar los estados del algoritmo
        var pila = new Stack<(int discos, string inicio, string fin, string apoyo)>();

        // Agregar el estado inicial con la información de los discos y torres
        pila.Push((discos, inicio, fin, apoyo));

        // Procesar los estados de la pila mientras no esté vacía
        while (pila.Count > 0)
        {
            // Extraer el estado actual de la pila
            var (n, i, f, ap) = pila.Pop();

            // Si hay un solo disco, moverlo directamente a la torre de destino
            if (n == 1)
            {
                Console.WriteLine($"Mover disco de {i} a {f}");
            }
            else
            {
                // Dividir el problema en pasos más pequeños y apilarlos para su procesamiento

                // 1. Mover los (n-1) discos desde la torre de apoyo a la torre de destino
                pila.Push((n - 1, ap, f, i));

                // 2. Mover el disco más grande desde la torre de inicio a la torre de destino
                pila.Push((1, i, f, ap));

                // 3. Mover los (n-1) discos desde la torre de inicio a la torre de apoyo
                pila.Push((n - 1, i, ap, f));
            }
        }
    }

    static void Main()
    {
        // Configurar el número de discos para resolver el problema
        int discos = 4; // Incrementar a 4 discos para mayor complejidad

        // Definir los nombres de las torres
        string inicio = "Torre Inicial"; // Torre de inicio
        string fin = "Torre Final"; // Torre final
        string apoyo = "Torre de Apoyo"; // Torre de apoyo

        // Imprimir la solución para el número de discos especificado
        Console.WriteLine($"Resolviendo Torres de Hanói para {discos} discos:");
        ResolverTorresDeHanoi(discos, inicio, fin, apoyo);
    }
}