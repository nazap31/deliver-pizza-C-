int cantidadPizzas;
Console.WriteLine("Escriba la cantidad de cajas de pizzas que desea: ");
cantidadPizzas = Int32.Parse(Console.ReadLine());

int tamañoPizza;
Console.WriteLine("Escriba las porciones de pizza que desea: 4, 6, 8, 10, 12...");
tamañoPizza =Int32.Parse(Console.ReadLine());
if (tamañoPizza % 2 != 0)
{
    Console.Write("Porfavor ingrese solo porciones de pizza validas");
}

else
{
    int cantidadPersonas;
    Console.WriteLine("Escriba la cantidad de personas a repartir: ");
    cantidadPersonas = Int32.Parse(Console.ReadLine());

    int repartirPizza;
    repartirPizza= (cantidadPizzas * tamañoPizza / cantidadPersonas);

    int sobran = (cantidadPizzas * tamañoPizza % cantidadPersonas);
    Console.Write("Sobran ");
    Console.Write(sobran);
    Console.Write(" porciones de pizza");

    Console.Write("\n Se reparten equitativamente ");
    Console.Write(repartirPizza);
    Console.Write(" porciones de pizza para cada persona");
}
Console.WriteLine("\n Fin del programa!");
