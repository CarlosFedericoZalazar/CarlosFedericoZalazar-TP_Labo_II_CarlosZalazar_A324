using RestoApp.Clases;

namespace AppRestoForm
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
            Application.Run(new FormPrincipal());

            //Encargado encargado = new Encargado("Carlos", "Zalazar");
            //Application.Run(new FormHacerPedido(encargado));
        }
    }
}