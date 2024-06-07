using RestoApp.Files;
using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public abstract class  Producto : IProducto
    {
        public enum Tipo
        {
            Bebida,
            Comida
        }        
        private static readonly string IdFilePath = @"C:\Users\Usuario\Desktop\ARCHIVOS\lastId.txt"; // Ruta del archivo donde se guarda el último ID.
        private int _id; // ID único para cada instancia.

        private string _nombre;
        private double _precio;
        private Tipo _tipo;

        public Producto()
        {           
        }
        public Producto(string nombre, Tipo tipo, double precio)
        {
            Nombre = nombre;
            TipoProducto = tipo;
            Precio = precio;
            _id = LoadLastId();
            int next_id = _id + 1;
            SaveLastId(next_id);
        }
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get=>_nombre; set=>_nombre = value; }
        public double Precio { get => _precio; set => _precio=value;  }
        public Tipo TipoProducto { get => _tipo; set => _tipo=value; }      


        private static int LoadLastId()
        {
            if (File.Exists(IdFilePath))
            {
                string lastIdStr = File.ReadAllText(IdFilePath);
                if (int.TryParse(lastIdStr, out int lastId))
                {
                    return lastId;
                }
            }
            return 1; // INICIAMOS ARCHIVO DESDE 1
        }

        private static void SaveLastId(int lastId)
        {
            File.WriteAllText(IdFilePath, lastId.ToString());
        }

        public class ProductoNoEncontradoException : Exception
        {
            public ProductoNoEncontradoException(string message) : base(message)
            {
            }
        }

    }
}
