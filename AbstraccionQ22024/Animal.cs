using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraccionQ22024
{
    public abstract class Animal
    {
        /// <summary>
        /// Nombre del Animal
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Color del Animal
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Tamaño del Animal
        /// </summary>
        public string Tamano { get; set; }

        /// <summary>
        /// Familia del Animal
        /// </summary>
        public String Familia { get; set; }

        /// <summary>
        /// Método abstracto para visualizar datos
        /// </summary>
        public abstract void Imprimir();

    }
}
