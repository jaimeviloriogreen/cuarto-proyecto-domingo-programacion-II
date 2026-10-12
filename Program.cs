using CuartoProyecto.Zoo;

// Instancia de la clase
var animal1 = new Animal("perro", 5, "negro", "pequeño"); // Objeto 1
var animal2 = new Animal("gato", 7, "blanco", "mediano"); // Objeto 2
var animal3 = new Animal("león", 6, "amarillo", "grande"); // Objeto 3

Console.WriteLine(animal1.Nombre);
Console.WriteLine(animal2.Nombre);
Console.WriteLine(animal3.Nombre);

animal1.Caminar();
animal2.Caminar();
animal3.Caminar();

animal1.EsDomestico(true);
animal2.EsDomestico(true);
animal3.EsDomestico(false);