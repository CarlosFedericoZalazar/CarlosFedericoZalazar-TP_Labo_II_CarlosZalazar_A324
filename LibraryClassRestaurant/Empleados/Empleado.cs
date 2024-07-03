using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using System.Text.Json.Serialization;

namespace LibraryClassRestaurant.Empleados
{
    public class Empleado : IEmpleado
    {
        public enum Perfil
        {
            Encargado,
            Cocinero,
            Mesero,
            Delivery
        }
        public enum Estado
        {
            Activo,
            Inactivo
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double Sueldo { get; set; }
        public Perfil Profile { get; set; }
        public Estado EstadoEmpleado { get; set; }
        public double SueldoBolsillo { get; set; }
        public string NombreCompleto { get => $"{Nombre} {Apellido}"; }

        public Empleado() { }
        public Empleado(string nombre, string apellido, string direccion, string telefono, double sueldoBolsillo, double sueldo, Perfil profile)
        {
            Nombre = nombre.ToUpper();
            Apellido = apellido.ToUpper();
            Direccion = direccion.ToUpper();
            Telefono = telefono;
            SueldoBolsillo = sueldoBolsillo;
            Sueldo = sueldo;
            Profile = profile;
            EstadoEmpleado = Estado.Activo;
        }

        public static List<T> CargarEmpleados<T>(Empleado.Perfil perfil) where T : Empleado
        {
            var listaEmpleados = Encargado.ObtenerEmpleados();
            List<T> listaEmpleadosFiltrados = new List<T>();

            foreach (var item in listaEmpleados)
            {
                if (item.Profile == perfil)
                {
                    var empleado = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.SueldoBolsillo, item.Sueldo);
                    listaEmpleadosFiltrados.Add((T)empleado);
                }
            }

            return listaEmpleadosFiltrados;
        }
    }

}
