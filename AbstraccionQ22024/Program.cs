using AbstraccionQ22024;

procesoVertebrado();
procesoInvertebrado();

// Flujo para ingresar un animal vertebrado
void procesoVertebrado()
{
    Vertebrado vertebrado = new Vertebrado();
    string resDomestico, resHerbivoro, resCarnivoro;
    Console.WriteLine("******* Animal vertebrado *******");
    Console.WriteLine("Escriba el nombre:");
    vertebrado.Nombre = Console.ReadLine();

    Console.WriteLine("Escriba el color:");
    vertebrado.Color = Console.ReadLine();

    Console.WriteLine("Escriba el tamaño:");
    vertebrado.Tamano = Console.ReadLine();

    Console.WriteLine("Escriba la familia que pertenece el animal:");
    vertebrado.Familia = Console.ReadLine();

    Console.WriteLine("Escriba el tipo de animal vertebrado:");
    vertebrado.Tipo = Console.ReadLine();

    Console.WriteLine("¿El animal es doméstico?:");
    resDomestico = Console.ReadLine();

    Console.WriteLine("¿El animal es herbívoro?:");
    resHerbivoro = Console.ReadLine();

    Console.WriteLine("¿El animal es carnívoro?:");
    resCarnivoro = Console.ReadLine();

    vertebrado.EsDomestico = resDomestico == "Si";
    vertebrado.EsHerbivoro = resHerbivoro == "Si";
    vertebrado.EsCarnivoro = resCarnivoro == "Si";
    vertebrado.Imprimir();
}

// Flujo para ingresar un animal vertebrado
void procesoInvertebrado()
{
    Invertebrado invertebrado = new Invertebrado();
    string resTienePatas, resTieneConcha;
    Console.WriteLine("******* Animal invertebrado *******");
    Console.WriteLine("Escriba el nombre:");
    invertebrado.Nombre = Console.ReadLine();

    Console.WriteLine("Escriba el color:");
    invertebrado.Color = Console.ReadLine();

    Console.WriteLine("Escriba el tamaño:");
    invertebrado.Tamano = Console.ReadLine();

    Console.WriteLine("Escriba la familia que pertenece el animal:");
    invertebrado.Familia = Console.ReadLine();

    Console.WriteLine("Escriba el tipo de animal vertebrado:");
    invertebrado.Tipo = Console.ReadLine();

    Console.WriteLine("¿El animal tiene patas?:");
    resTienePatas = Console.ReadLine();

    if (resTienePatas == "Si")
    {
        Console.WriteLine("Número de patas:");
        invertebrado.NumeroPatas = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("¿El animal tiene concha?:");
    resTieneConcha = Console.ReadLine();

    invertebrado.TienePatas = resTienePatas == "Si";
    invertebrado.TieneConcha = resTieneConcha == "Si";
    invertebrado.Imprimir();
}
