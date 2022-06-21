using System;
using System.Collections.Generic;
using System.Text;

namespace capaEntidades
{
    public class clsProducto
    {
        private string id;
        private string nombre;
        private string descripcion;
        private string pCompra;
        private string pVenta;
        private string cantidad;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string PCompra { get => pCompra; set => pCompra = value; }
        public string PVenta { get => pVenta; set => pVenta = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
    }
}
