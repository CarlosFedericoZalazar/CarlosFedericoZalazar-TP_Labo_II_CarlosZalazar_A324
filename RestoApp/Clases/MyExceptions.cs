using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public class MyExceptions
    {
        public class ProductoNoEncontradoException : Exception
        {
            public ProductoNoEncontradoException() { }

            public ProductoNoEncontradoException(string message)
                : base(message) { }
        }
    }
}
