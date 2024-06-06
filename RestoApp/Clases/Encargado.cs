using RestoApp.Files;
using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public class Encargado:Empleado, IGenerarPedidos
    {
        private static int _nextId = 1000;
        private int _id;  
        private List<Producto> _productos = new List<Producto>();

        // CONSTRUCTOR
        public Encargado(string nombre, string apellido):base(nombre, apellido)
        {
            _id = _nextId;  
            _nextId++;
        }

        // GETTERS Y SETTERS
        public int Id
        {
            get { return _id; }
        }
        // METODS

        public string GestionarPedido(IProducto producto, int cantidad, Proveedor proveedor)
        {
            ManejadorPedido manejadorPedido = InstanciarManejadorPedido();
            manejadorPedido.IdEncargado = this.Id;
            string stringPedido = manejadorPedido.IniciarPedido(producto, cantidad, proveedor);

            return stringPedido;
        }

        public ManejadorPedido InstanciarManejadorPedido()
        {
            return ManejadorPedido.InstanciarManejadorPedido();
        }

        public void OrdenarBebida(IProducto producto, int quantity, Proveedor proveedor)
        {
            // INSTANCIAMOS MENAJEDOR DE PEDIDOS
            ManejadorPedido manejadorPedido = this.InstanciarManejadorPedido();

            manejadorPedido.OrdenarBebida((ProductoBebible)producto, quantity, proveedor);


            //List<ProductoBebible>bebibles = new List<ProductoBebible>();
            //bebibles.Add((ProductoBebible)product);
            //Serializador.Archivo.SaveJson("ProductoBebible", bebibles);


            List<Pedido> listPedidos = new List<Pedido>();
            Pedido pedido = new Pedido(producto.Id, proveedor);
            //Pedido pedido = new Pedido((ProductoBebible)producto, proveedor);
            listPedidos.Add(pedido);
            Serializador.Archivo.SaveJson("pedidosBebible", listPedidos);
        }

        public void OrdenarComida(IProducto producto, int quantity, Proveedor proveedor)
        {
            ManejadorPedido manejadorPedido = this.InstanciarManejadorPedido();

            manejadorPedido.OrdenarComida((ProductoComestible)producto, quantity, proveedor);

            List<Pedido> listPedidos = new List<Pedido>();
            Pedido pedido = new Pedido(producto.Id, proveedor);
            //Pedido pedido = new Pedido((ProductoComestible)producto, proveedor);
            listPedidos.Add(pedido);
            Serializador.Archivo.SaveJson("pedidosComida", listPedidos);
        }

    }
}