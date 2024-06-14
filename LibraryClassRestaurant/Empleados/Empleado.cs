using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using System.Text.Json.Serialization;

namespace LibraryClassRestaurant.Empleados
{
    public class Empleado: IEmpleado
    {
        public enum Perfil
        {
            Mesero,
            Cocinero,
            Delivery,
            Encargado
        }

        public enum Estado
        {
            Activo,
            Inactivo
        }

        string _nombre;
        string _apellido;
        string _direccion;
        string _telefono;
        double _sueldo;
        Perfil _profile;
        Estado _estadoEmpleado;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido=value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set=>_telefono=value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }
        public Perfil Profile { get => _profile; set => _profile = value; }
        public Estado EstadoEmpleado { get=> _estadoEmpleado; set=> _estadoEmpleado=value; }
        public Empleado() { }
        public Empleado(string nombre, string apellido, string direccion, string telefono, double sueldo, Perfil profile)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Sueldo = sueldo;
            Profile = profile;
            EstadoEmpleado = Estado.Activo;
        }        

        //public abstract void MostrarInformacion();
    }
}
