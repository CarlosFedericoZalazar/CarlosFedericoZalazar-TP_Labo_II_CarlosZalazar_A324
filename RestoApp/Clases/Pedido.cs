using RestoApp.Files;
using RestoApp.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestoApp.Clases
{
    public class Pedido:ISerializar
    {
        public enum Estado
        {
            Pendiente,
            Recibido,
            Agotado
        }
        private static int _idPedido=0;
        private int _idProducto;
        private Proveedor _proveedor;
        private DateTime _fechaPedido;
        private Estado _estado;

        public Pedido(int idProducto, Proveedor proveedor)
        {
            _idPedido++;
            _idProducto = idProducto;
            _proveedor = proveedor;
            _fechaPedido = DateTime.Now;
            _estado = Estado.Pendiente;
        }

        public Pedido() { }
        public int IdPedido { get=> _idPedido; set=> _idPedido=value; }
        public int IdProducto { get =>_idProducto; set =>_idProducto = value; }
        public Proveedor Proveedor{ get => _proveedor; set => _proveedor=value; }
        public DateTime FechaPedido { get => _fechaPedido; set => _fechaPedido = value; }
      
        public Estado EstadoPedido { get =>_estado; set => _estado = value; }       
        
        public static void Save(Pedido pedido) 
        {
            Serializador.Save(pedido, "pedido");
            //List<Pedido> lista = ReadPedido();
            //lista.Add(pedido);
            //Save(lista);
        }
        public static void Save(List<Pedido> listaPedido)
        {
            Serializador.Save(listaPedido, "pedido");
            //Serializador.Archivo.SaveJson<Pedido>("pedido", listaPedido);
        }
        public static List<Pedido> ReadPedido()
        {
            return Serializador.Archivo.ReadJson<Pedido>("pedido").ToList();
        }
    }
}
