using System;
using System.Collections.Generic;
using System.Text;

namespace capaEntidades
{
    public class clsEmpleado
    {
        private string cedula;
        private string pNombre;
        private string sNombre;
        private string pApellido;
        private string sApellido;
        private string celular;
        private string salario; 

        public string Cedula { get => cedula; set => cedula = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string PApellido { get => pApellido; set => pApellido = value; }
        public string SApellido { get => sApellido; set => sApellido = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Salario { get => salario; set => salario = value; }
    }   
}
