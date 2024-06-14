using LibraryClassRestaurant.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Interfaces
{
    public  interface ISerializador
    {
        public void Save<T>(string path, T item);
        public List<T> ReadJson<T>(string path);
        public void Save<T>(string path, List<T> listaItem);
    }
}
