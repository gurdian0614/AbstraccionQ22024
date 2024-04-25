
namespace AbstraccionQ22024
{
    public class Vertebrado : Animal
    {
        /// <summary>
        /// Tipo de Animal
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Valor booleano que nos indica si el animal tiene patas o no
        /// </summary>
        public bool TienePatas { get; set; }

        /// <summary>
        /// Valor booleano que nos indica si el animal es doméstico o no
        /// </summary>
        public bool EsDomestico { get; set; } //True: Es domestico // False: No es domestico

        /// <summary>
        /// Valor booleano que nos indica si el animal es herbívoro o no
        /// </summary>
        public bool EsHerbivoro { get; set; } //Bool: Valor booleano: verdadero o falso

        /// <summary>
        /// Valor booleano que nos indica si el animal es carnívoro o no
        /// </summary>
        public bool EsCarnivoro { get; set; }

        // Constructor
        public Vertebrado()
        {
            TienePatas = true;
            EsCarnivoro = true;
        }

        /// <summary>
        /// Imprime cada uno de los atributos de la clase
        /// </summary>
        public override void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Sí" : "No")}");
            Console.WriteLine($"Es Doméstico: {(EsDomestico ? "Sí" : "No")}");
            Console.WriteLine($"Es Herbívoro: {(EsHerbivoro ? "Sí" : "No")}");
            Console.WriteLine($"Es Carnívoro: {(EsCarnivoro ? "Sí" : "No")}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
