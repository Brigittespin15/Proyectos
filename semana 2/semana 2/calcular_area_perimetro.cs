// Clase que representa un Círculo
public class Circulo
{
 // Propiedad para almacenar el radio del círculo
 private double radio;
 // Constructor para inicializar el radio
 public Circulo(double radio)
 {
 this.radio = radio;
 }
 // Método para calcular el área del círculo
 // El área de un círculo se calcula como: Área = π * radio^2
 public double CalcularArea()
 {
 return Math.PI * Math.Pow(radio, 2);
 }
 // Método para calcular el perímetro del círculo
 // El perímetro (circunferencia) se calcula como: Perímetro = 2 * π * radio
 public double CalcularPerimetro()
 {
 return 2 * Math.PI * radio;
 }
}
// Clase que representa un Rectángulo
public class Rectangulo
{
 // Propiedades para almacenar la base y la altura del rectángulo
 private double baseRectangulo;
 private double altura;
 // Constructor para inicializar la base y la altura
 public Rectangulo(double baseRectangulo, double altura)
 {
 this.baseRectangulo = baseRectangulo;
 this.altura = altura;
 }
 // Método para calcular el área del rectángulo
 // El área de un rectángulo se calcula como: Área = base * altura
 public double CalcularArea()
 {
 return baseRectangulo * altura;
 }
 // Método para calcular el perímetro del rectángulo
 // El perímetro se calcula como: Perímetro = 2 * (base + altura)
 public double CalcularPerimetro()
 {
 return 2 * (baseRectangulo + altura);
 }
}
// Ejemplo de uso
public class Programa
{
 public static void Main(string[] args)
 {
 // Crear una instancia de Círculo con un radio de 5 unidades
 Circulo circulo = new Circulo(5);
 Console.WriteLine("Círculo:");
 Console.WriteLine("Área: " + circulo.CalcularArea());
 Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());
 // Crear una instancia de Rectángulo con una base de 4 unidades y
una altura de 7 unidades
 Rectangulo rectangulo = new Rectangulo(4, 7);
 Console.WriteLine("\nRectángulo:");
 Console.WriteLine("Área: " + rectangulo.CalcularArea());
 Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
 }
}
