using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosTarea
{
    internal class Transaccion
    {
        public Transaccion(int numFactura, DateTime fechaVenta, uint cedulaCliente, List<Producto> productosVendidos, string nombreCliente, string direccionCliente)
        {
            NumFactura = numFactura;
            FechaVenta = fechaVenta;
            CedulaCliente = cedulaCliente;
            ProductosVendidos = productosVendidos;
            NombreCliente = nombreCliente;
            DireccionCliente = direccionCliente;
        }

        public int NumFactura { get; init; }
        public DateTime FechaVenta { get; init; }
        public uint CedulaCliente { get; init; }
        public List<Producto> ProductosVendidos { get; init; }
        public string NombreCliente { get; init; }
        public string DireccionCliente { get; init; }
    }
}
