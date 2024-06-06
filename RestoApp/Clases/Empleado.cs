using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    abstract public class Empleado
    {
        string _nombre;
        string _apellido;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public Empleado(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

    }
}
