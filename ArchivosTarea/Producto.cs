using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosTarea
{
    internal class Producto
    {
        public Producto(string nombreProducto, uint cantidadProducto, double precioUnidad, bool exentoImpuestos) {
            NombreProducto = nombreProducto;
            CantidadProducto = cantidadProducto;
            PrecioUnidad = precioUnidad;
            ExentoImpuestos = exentoImpuestos;
        }

        public string NombreProducto { get; init;}
        public uint CantidadProducto { get; init; }
        public double PrecioUnidad { get; init; }
        public bool ExentoImpuestos { get; init; }
    }
}
