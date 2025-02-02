using System;

class Estudiante {
    public string Cedula, Nombre, Apellido, Correo;
    public int Nota;
    public Estudiante Siguiente;

    public Estudiante(string cedula, string nombre, string apellido, string correo, int nota) {
        Cedula = cedula;
        Nombre = nombre;
        Apellido = apellido;
        Correo = correo;
        Nota = nota;
        Siguiente = null;
    }
}

class ListaEnlazada {
    private Estudiante cabeza;

    public void AgregarEstudiante(string cedula, string nombre, string apellido, string correo, int nota) {
        Estudiante nuevo = new Estudiante(cedula, nombre, apellido, correo, nota);
        if (nota >= 6) { 
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
        } else { 
            if (cabeza == null) cabeza = nuevo;
            else {
                Estudiante temp = cabeza;
                while (temp.Siguiente != null) temp = temp.Siguiente;
                temp.Siguiente = nuevo;
            }
        }
    }

    public Estudiante BuscarEstudiante(string cedula) {
        Estudiante temp = cabeza;
        while (temp != null) {
            if (temp.Cedula == cedula) return temp;
            temp = temp.Siguiente;
        }
        return null;
    }

    public bool EliminarEstudiante(string cedula) {
        Estudiante temp = cabeza, previo = null;
        while (temp != null && temp.Cedula != cedula) {
            previo = temp;
            temp = temp.Siguiente;
        }
        if (temp == null) return false;
        if (previo == null) cabeza = temp.Siguiente;
        else previo.Siguiente = temp.Siguiente;
        return true;
    }

    public (int aprobados, int reprobados) ContarEstudiantes() {
        int aprobados = 0, reprobados = 0;
        Estudiante temp = cabeza;
        while (temp != null) {
            if (temp.Nota >= 6) aprobados++;
            else reprobados++;
            temp = temp.Siguiente;
        }
        return (aprobados, reprobados);
    }

    public void InvertirLista() {
        Estudiante prev = null, current = cabeza, next = null;
        while (current != null) {
            next = current.Siguiente;
            current.Siguiente = prev;
            prev = current;
            current = next;
        }
        cabeza = prev;
    }

    public void MostrarLista() {
        Estudiante temp = cabeza;
        while (temp != null) {
            Console.WriteLine($"{temp.Cedula} - {temp.Nombre} {temp.Apellido} - Nota: {temp.Nota}");
            temp = temp.Siguiente;
        }
    }
}

class Program {
    static void Main() {
        ListaEnlazada lista = new ListaEnlazada();
        lista.AgregarEstudiante("12345", "Juan", "Pérez", "juan@example.com", 8);
        lista.AgregarEstudiante("67890", "Ana", "Gómez", "ana@example.com", 5);
        lista.AgregarEstudiante("54321", "Carlos", "Ruiz", "carlos@example.com", 9);
        
        Console.WriteLine("Lista original:");
        lista.MostrarLista();
        
        Console.WriteLine("Lista invertida:");
        lista.InvertirLista();
        lista.MostrarLista();
    }
}
