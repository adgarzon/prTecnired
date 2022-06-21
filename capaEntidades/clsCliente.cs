using System;

namespace capaEntidades
{
    public class clsCliente
    {
        private string cedula;
        private string pNombre;
        private string sNombre;
        private string pApellido;
        private string sApellido;
        private string direccion;
        private string celular;

        public string Cedula { get => cedula; set => cedula = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string PApellido { get => pApellido; set => pApellido = value; }
        public string SApellido { get => sApellido; set => sApellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}
