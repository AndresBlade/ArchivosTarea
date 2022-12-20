namespace ArchivosTarea
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            

            List<Transaccion> registroVentas = new List<Transaccion>();
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

            registroVentas.Add(new Transaccion(1, new DateTime(2022, 12, 18), 30266948, new List<Producto>() { manzana, harinaMaiz, sopaInstantanea}, "Andrés", "Villa Crepuscular"));
            registroVentas.Add(new Transaccion(1235343, new DateTime(2021, 06, 15), 27340232, new List<Producto>() { mayonesa, pasta}, "Julio", "Santa Elena"));
            registroVentas.Add(new Transaccion(2904, new DateTime(2010, 1, 4), 23443442, new List<Producto>() { carbonParrilla}, "Eva", "La Concordia"));
            registroVentas.Add(new Transaccion(2904, new DateTime(2014, 2, 5), 43500, new List<Producto>() { jabonRopa, pasta, aguacate, harinaMaiz, harinaTrigo}, "John", "El Ujano"));
            registroVentas.Add(new Transaccion(744282, new DateTime(2015, 3, 6), 17720958, new List<Producto>() { carbonParrilla}, "Eduviges", "Tintorero"));
            registroVentas.Add(new Transaccion(7442, new DateTime(2013, 11, 29), 6345020, new List<Producto>() { harinaTrigo}, "Carlos", "Los Ángeles"));
            registroVentas.Add(new Transaccion(182098483, new DateTime(2022, 3, 12), 3450444, new List<Producto>() { papa}, "Pepe", "Quíbor"));
            registroVentas.Add(new Transaccion(99044344, new DateTime(2022, 1, 1), 2990, new List<Producto>() { harinaTrigo, harinaMaiz, mayonesa}, "Ronardo", "Portugal"));
            


        }
    }
}