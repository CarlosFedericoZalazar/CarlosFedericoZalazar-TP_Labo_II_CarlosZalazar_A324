using RestoApp.Clases;
using RestoApp.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.ClasesSalon
{
    public class Cocinero:Empleado
    {
        public Cocinero(string nombre, string apellido) : base(nombre, apellido)
        {
        }

        List<ProductoComestible> listProductos = new List<ProductoComestible>();
        List<Plato>listaOrdenesComensal=new List<Plato>();

        private void CheckAlimentosStock() 
        {
            List<Producto>ListaStockDisponible = new List<Producto>();
            listProductos = Serializador.Archivo.ReadJson<ProductoComestible>("ProductoComestible").ToList();

            foreach (Producto producto in listProductos) 
            {
                
            }        
        }

        private void CrearPlato(List<Plato>OrdenesPedidas) 
        {
            List<Pedido> listaProductos = Pedido.ReadPedido();
            var listaAuxiliar = listaProductos;

            // TODO: AQUI HACEMOS LA LOGICA DONDE DESCONTAMOS DEL STOCK LOS PRODUCTOS

            foreach (var plato in OrdenesPedidas)
            {
                //int cantidadIngredientes = plato.ingredientesPlato.Count;
                //int coincidencias = 0;                
                //List<int>ingredientes = new List<int>();
                //bool stockIngredientesOk=false;

                //foreach (var producto in listaProductos)
                //{
                //    if (plato.ingredientesPlato.ContainsKey(producto.Producto.Nombre))
                //    {
                //        coincidencias++;
                //        ingredientes.Add(listaAuxiliar.IndexOf(producto));
                //        if (coincidencias == cantidadIngredientes)
                //        {
                //            stockIngredientesOk = true;                
                //            break;
                //            // hasta aca existen ingredientes
                //        }
                //    }
                //}
                //if(stockIngredientesOk) 
                //{
                //    foreach (var item in ingredientes)
                //    {
                //        double cantidadEnStock = plato.Ingredientes[listaProductos[item].Producto.Nombre];
                //        //listaProductos[item].Producto. -= cantidadEnStock;
                //    }
                //}
            }

        }

        private void DescontarMercaderia(List<ProductoComestible> listaProductos, List<Plato> listaPlatos)
        {
            foreach (var plato in listaPlatos)
            {
                foreach (var producto in listaProductos)
                {
                    if (plato.ingredientesPlato.ContainsKey(producto.Nombre))
                    {

                        double resultado = producto.Cantidad - (plato.ingredientesPlato[producto.Nombre]) / 1000;

                        producto.Cantidad -= (plato.ingredientesPlato[producto.Nombre]) / 1000; // solucionar esto
                    }

                }
            }
            Serializador.Archivo.SaveJson<ProductoComestible>("ProductoComestible", listaProductos);
        }

    }
}
