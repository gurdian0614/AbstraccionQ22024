
namespace AbstraccionQ22024
{
    public class Invertebrado : Animal
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
        /// Valor entero que nos indica el número de patas de un animal
        /// </summary>
        public int NumeroPatas { get; set; }

        /// <summary>
        /// Valor booleano que nos indica si el animal tiene concha o no
        /// </summary>
        public bool TieneConcha { get; set; }

        // Constructor
        public Invertebrado()
        {
            TienePatas = false;
            NumeroPatas = 0;
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
            Console.WriteLine($"Tiene concha: {(TieneConcha ? "Sí" : "No")}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Sí" : "No")}");
            Console.WriteLine($"{(TienePatas ? $"Número de patas: {NumeroPatas}" : "")}");
        }
    }
}
