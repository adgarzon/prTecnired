using System;
using System.Collections.Generic;
using System.Text;

namespace capaEntidades
{
    public class clsFactura
    {
        private string codigo;
        private string fecha;
        private string cliente;
        private string empleado;
        private string total;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Empleado { get => empleado; set => empleado = value; }
        public string Total { get => total; set => total = value; }
    }
}
