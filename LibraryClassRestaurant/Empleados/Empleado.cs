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
    }

}
