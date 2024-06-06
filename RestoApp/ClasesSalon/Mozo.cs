using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestoApp.Clases;

namespace RestoApp.ClasesSalon
{
    public class Mozo : Empleado
    {
        private static int _nextId = 1100;
        private int _id;
        private List<Producto> _productos = new List<Producto>();

        // CONSTRUCTOR
        public Mozo(string nombre, string apellido) : base(nombre, apellido)
        {
            _id = _nextId;
            _nextId++;
        }

        // GETTERS Y SETTERS
        public int Id
        {
            get { return _id; }
        }

    }
}
