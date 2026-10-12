namespace CuartoProyecto.Zoo;
// Defino mi clase
public class Animal {
  public string Nombre;
  public int Edad;
  public string Color;
  public string Tamaño;

  // Método constructor
  public Animal(string nombre, int edad, string color, string tamaño) {
    Nombre = nombre;
    Edad = edad;
    Color = color;
    Tamaño = tamaño;
  }
  // Metódos
  public void Caminar() {
    Console.WriteLine($"El {Nombre} está caminado!");
  }

  public void EsDomestico(bool domestico) {
    if (domestico) {
      Console.WriteLine($"El {Nombre} es doméstico");
    }
    else {
      Console.WriteLine($"El {Nombre} NO es doméstico");
    }
  }
}

