using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisT
{
    class Productos
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Precio { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Imagen { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\nPrecio:{2}\nContacto:\n\n{3}\n{4}", Nombre, Descripcion, Precio, Email, Telefono);
        }
    }
}
