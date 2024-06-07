using RestoApp.Files;
using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public class ManejadorPedido
    {
        //bool proveedorExistente = false;
        private readonly IProveedor? _beverageProvider;
        private readonly IProveedor? _foodProvider;
        private int _idEncargado;

        private ManejadorPedido()
        {
        }

        public int IdEncargado { set=>_idEncargado=value; }

        public string IniciarPedido(IProducto producto, int cantidad, Proveedor proveedor)
        {
            if (producto is ProductoBebible)
            {
                OrdenarBebida(producto, cantidad, proveedor);
            }
            else 
            {
                OrdenarComida(producto, cantidad, proveedor);
            }
            
            return "";
        }

        public void OrdenarBebida(IProducto producto, int cantidad, Proveedor proveedor)
        {
            List<ProductoBebible> bebibles = new List<ProductoBebible>();
            try
            {
                bebibles = Serializador.Archivo.ReadJson<ProductoBebible>("ProductoBebible").ToList();
            }
            catch (Exception)
            {
                throw;
            }
            bebibles.Add((ProductoBebible)producto);
            Serializador.Archivo.SaveJson<ProductoBebible>("ProductoBebible", bebibles);
            Pedido pedido = new Pedido(producto.Id, proveedor);
            //Pedido pedido = new Pedido((ProductoBebible)producto.Id, proveedor);
            Pedido.Save(pedido);
        }

        public void OrdenarComida(IProducto producto, int cantidad, Proveedor proveedor)
        {
            List<ProductoComestible> comestibles = new List<ProductoComestible>();

            try
            {
                comestibles = Serializador.Archivo.ReadJson<ProductoComestible>("ProductoComestible").ToList();
            }
            catch (Exception)
            {

                throw;
            }      
            
            comestibles.Add((ProductoComestible)producto);
            Serializador.Archivo.SaveJson("ProductoComestible", comestibles);
            Pedido pedido = new Pedido(producto.Id, proveedor);
            //Pedido pedido = new Pedido((ProductoComestible)producto, proveedor);
            Pedido.Save(pedido);

        }
        public static ManejadorPedido InstanciarManejadorPedido()
        {
            return new ManejadorPedido();
        }

    }
}
