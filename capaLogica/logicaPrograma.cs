using System;
using capaEntidades;
using capaDatos;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Data;


namespace capaLogica
{
    public class logicaPrograma
    {
        // EMPLEADO  ---------------------------------------------------------------------------
        public static bool guardarEmpleado(clsEmpleado obj)
        {
           return guardar.guardarEmpleado(obj);
        }
        public static List<clsEmpleado> listarEmpleado()
        {
            List<clsEmpleado> l = listar.listarEmpleado();
            return l;
        }
        public static DataTable buscarEmpleado(string id)
        {
           
            var tabla = new DataTable();
            tabla = buscar.buscarEmpleado(id);
            return tabla;
        }
        public static void eliminarEmpleado(string id)
        {
            eliminar.eliminarEmpleado(id);
        }
        public static bool modificarEmpleado(clsEmpleado obj)
        {
            eliminar.eliminarEmpleado(obj.Cedula);
            bool g = guardar.guardarEmpleado(obj);
            return g;
        }

        // CLIENTE  ---------------------------------------------------------------------------
        public static void guardarCliente(clsCliente obj)
        {
            bool g = guardar.guardarCliente(obj);
        }
        public static DataTable buscarCliente(string id)
        {
            var tabla = new DataTable();
            tabla = buscar.buscarCliente(id);
            return tabla;
        }
        public static List<clsCliente> listarCliente()
        {
            List<clsCliente> l = listar.listarCliente();
            return l;
        }
        public static bool modificarCliente(clsCliente obj)
        {
            eliminar.eliminarCliente(obj.Cedula);
            bool g = guardar.guardarCliente(obj);
            return g;
        }
        public static void eliminarCliente(string id)
        {
            eliminar.eliminarCliente(id);
        }
        // PRODUCTO -----------------------------------------------------------------------

        public static void guardarProducto(clsProducto obj)
        {
            bool g = guardar.guardarProducto(obj);
        }
        public static DataTable buscarProducto(string id)
        {
            var tabla = new DataTable();
            tabla = buscar.buscarProducto(id);
            return tabla;
        }
        public static List<clsProducto> listarProducto()
        {
            List<clsProducto> l = listar.listarProducto();
            return l;
        }
        public static bool modificarProducto(string id,clsProducto obj)
        {
            eliminar.eliminarProducto(id);
            bool g = guardar.guardarProducto(obj);
            return g;
        }
        public static void eliminarProducto(string id)
        {
            eliminar.eliminarProducto(id);
        }

        // FACTURA -------------------------------------------------------------------------------------------
        public static void guardarFactura(clsFactura obj)
        {
            bool g = guardar.guardarFactura(obj);
        }
        public static List<clsFactura> listarFactura()
        {
            List<clsFactura> l = listar.listarFactura();
            return l;
        }

    }
}
