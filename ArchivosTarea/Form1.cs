using System.Text;
using System.Text.RegularExpressions;

namespace ArchivosTarea
{
    public partial class Form1 : Form
    {
        string separador = ";";
        List<Transaccion> registroVentas;
        public Form1()
        {
            registroVentas = new List<Transaccion>();
            InitializeComponent();
            Producto manzana = new Producto("Manzana", 5, 1, true);
            Producto harinaMaiz = new Producto("Harina de maíz", 2, 2, false);
            Producto harinaTrigo = new Producto("Harina de trigo", 1, 3.5, false);
            Producto papa = new Producto("Papa", 7, 2.3, true);
            Producto sopaInstantanea = new Producto("Sopa instantánea", 9, 4, false);
            Producto aguacate = new Producto("Aguacate", 3, 4.6, true);
            Producto jabonRopa = new Producto("Jabón de ropa", 2, 13, false);
            Producto pasta = new Producto("Pasta larga", 5, 1.3, false);
            Producto carbonParrilla = new Producto("Bolsa de carbón para parrilla", 1, 35, true);
            Producto mayonesa = new Producto("Mayonesa", 2, 7, false);

            registroVentas.Add(new Transaccion(1, new DateTime(2022, 12, 18), 30266948, new List<Producto>() { manzana, harinaMaiz, sopaInstantanea }, "Andrés", "Villa Crepuscular"));
            registroVentas.Add(new Transaccion(1235343, new DateTime(2021, 06, 15), 27340232, new List<Producto>() { mayonesa, pasta }, "Julio", "Santa Elena"));
            registroVentas.Add(new Transaccion(2904, new DateTime(2010, 1, 4), 23443442, new List<Producto>() { carbonParrilla }, "Eva", "La Concordia"));
            registroVentas.Add(new Transaccion(2904, new DateTime(2014, 2, 5), 43500, new List<Producto>() { jabonRopa, pasta, aguacate, harinaMaiz, harinaTrigo }, "John", "El Ujano"));
            registroVentas.Add(new Transaccion(744282, new DateTime(2015, 3, 6), 17720958, new List<Producto>() { carbonParrilla }, "Eduviges", "Tintorero"));
            registroVentas.Add(new Transaccion(7442, new DateTime(2013, 11, 29), 6345020, new List<Producto>() { harinaTrigo }, "Carlos", "Los Ángeles"));
            registroVentas.Add(new Transaccion(182098483, new DateTime(2022, 3, 12), 3450444, new List<Producto>() { papa }, "Pepe", "Quíbor"));
            registroVentas.Add(new Transaccion(99044344, new DateTime(2022, 1, 1), 2990, new List<Producto>() { harinaTrigo, harinaMaiz, mayonesa }, "Ronardo", "Portugal"));
        }

        private void respaldarTodo()
        {
            string ruta = @"C:\Users\andre\Desktop\Andres\transacciones.csv";
            FileStream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write);

            StreamWriter escritor = new StreamWriter(archivo);

            foreach (Transaccion transaccion in registroVentas)
            {
                escritor.WriteLine(serializarTransaccion(transaccion));
            }
            escritor.Close();
            archivo.Close();
        }

        private void recuperar()
        {
            string ruta = @"C:\Users\andre\Desktop\Andres\transacciones.csv";
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);

            StreamReader leedor = new StreamReader(archivo);

            string? linea = leedor.ReadLine();

            while (linea != null) {
                string[] serialTransaccion = linea.Split(separador);
                int numFactura = int.Parse(serialTransaccion[0]);
                DateTime fechaVenta = DateTime.Parse(serialTransaccion[1]);
                uint cedulaCliente = uint.Parse(serialTransaccion[2]);
                string nombreCliente = serialTransaccion[3];
                string direccionCliente = serialTransaccion[4];
                List<Producto> productosVendidos = new List<Producto>();


                for (int i = 0; i < int.Parse(serialTransaccion[serialTransaccion.Length - 1]); i++)
                {
                    linea = leedor.ReadLine();
                    string[] serialProducto = linea.Split(separador);
                    string nombreProducto = serialProducto[0];
                    uint cantidadProducto = uint.Parse(serialProducto[1]);
                    double precioUnidad = double.Parse(serialProducto[2]);
                    bool exentoImpuestos = bool.Parse(serialProducto[3]);
                    productosVendidos.Add(new Producto(nombreProducto, cantidadProducto, precioUnidad, exentoImpuestos));
                }
                
                linea = leedor.ReadLine() ;
            }
            leedor.Close();
            archivo.Close();
        }
        private string serializarTransaccion(Transaccion transaccion)
        {
            StringBuilder salida = new StringBuilder();
            string linea = string.Empty;
            //string productosString = $"\"{serializarProductosVendidos(transaccion.ProductosVendidos)}\"";

            linea += transaccion.NumFactura + separador;
            linea += transaccion.FechaVenta + separador;
            linea += transaccion.CedulaCliente + separador;
            
            linea += transaccion.NombreCliente + separador;
            linea += transaccion.DireccionCliente + separador;
            linea += transaccion.ProductosVendidos.Count;

            for (int i = 0; i < transaccion.ProductosVendidos.Count; i++)
            {
                linea += $"\n{serializarProducto(transaccion.ProductosVendidos[i])}";
            }

            return linea;
        }

        private string serializarProducto(Producto producto)
        {
            string linea = string.Empty;

            linea += producto.NombreProducto + separador;
            linea += producto.CantidadProducto + separador;
            linea += producto.PrecioUnidad + separador;
            linea += producto.ExentoImpuestos;

            return linea;
        }

        private void buttonRespaldarTodo_Click(object sender, EventArgs e)
        {
            respaldarTodo();
        }

        private void buttonRecuperarAuxiliar_Click(object sender, EventArgs e)
        {
            List<Transaccion> Auxiliar = new List<Transaccion>();

            string ruta = @"C:\Users\andre\Desktop\Andres\transacciones.csv";
            try
            {
                labelSalida.Text = "";
                FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                StreamReader leedor = new StreamReader(archivo);

                string? linea = leedor.ReadLine();

                for (int numRegistros = 0; linea != null; numRegistros++)
                {
                    string[] serialTransaccion = linea.Split(separador);
                    int numFactura = int.Parse(serialTransaccion[0]);
                    DateTime fechaVenta = DateTime.Parse(serialTransaccion[1]);
                    uint cedulaCliente = uint.Parse(serialTransaccion[2]);
                    string nombreCliente = serialTransaccion[3];
                    string direccionCliente = serialTransaccion[4];
                    List<Producto> productosVendidos = new List<Producto>();

                    labelSalida.Text += $"\n TRANSACCION NÚMERO {numRegistros + 1}\n Nombre: {nombreCliente}, Cédula: {cedulaCliente}, Dirección: {direccionCliente}";
                    labelSalida.Text += $"\n Fecha de Venta: {fechaVenta}, Número de Factura: {numFactura}\n";
                    labelSalida.Text += $"PRODUCTOS\n";

                    for (int i = 0; i < int.Parse(serialTransaccion[serialTransaccion.Length - 1]); i++)
                    {
                        linea = leedor.ReadLine();
                        string[] serialProducto = linea.Split(separador);
                        string nombreProducto = serialProducto[0];
                        uint cantidadProducto = uint.Parse(serialProducto[1]);
                        double precioUnidad = double.Parse(serialProducto[2]);
                        bool exentoImpuestos = bool.Parse(serialProducto[3]);
                        productosVendidos.Add(new Producto(nombreProducto, cantidadProducto, precioUnidad, exentoImpuestos));
                    }

                    foreach (Producto producto in productosVendidos)
                    {

                        labelSalida.Text += $"Nombre del Producto: {producto.NombreProducto}, Cantidad: {producto.CantidadProducto}, Precio: {producto.PrecioUnidad}, Exento: {producto.ExentoImpuestos}\n";
                    }

                    if (numRegistros == 2) break;
                    linea = leedor.ReadLine();
                }
                leedor.Close();
                archivo.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("No se puede abrir un auxiliar sin haber respaldado los datos anteriormente", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }
    }

    
}