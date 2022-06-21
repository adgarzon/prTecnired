using System;
using System.Collections.Generic;
using System.Data.SQLite;
using capaEntidades;

namespace capaDatos
{
    public class listar
    {
        public static List<clsEmpleado> listarEmpleado()
        {
            List<clsEmpleado> lista = new List<clsEmpleado>();

            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "select *from empleado";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.CommandType = System.Data.CommandType.Text;
            SQLiteDataReader datos = cmd.ExecuteReader();
            
            while (datos.Read())
            {
                clsEmpleado emple = new clsEmpleado();
                emple.Cedula = datos["cedula"].ToString();
                emple.PNombre = datos["primer_nombre"].ToString();
                emple.SNombre = datos["segundo_nombre"].ToString();
                emple.PApellido = datos["primer_apellido"].ToString();
                emple.SApellido = datos["segundo_apellido"].ToString();
                emple.Salario = Convert.ToString(datos["salario"]);
                emple.Celular = datos["celular"].ToString();
                lista.Add(emple);
                    
            }
            return lista;
        }
        public static List<clsCliente> listarCliente()
        {
            List<clsCliente> lista = new List<clsCliente>();

            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "select *from cliente";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.CommandType = System.Data.CommandType.Text;
            SQLiteDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                clsCliente cliente = new clsCliente();
                cliente.Cedula = datos["cedula"].ToString();
                cliente.PNombre = datos["primer_nombre"].ToString();
                cliente.SNombre = datos["segundo_nombre"].ToString();
                cliente.PApellido = datos["primer_apellido"].ToString();
                cliente.SApellido = datos["segundo_apellido"].ToString();
                cliente.Direccion = datos["direccion"].ToString();
                cliente.Celular = datos["celular"].ToString();
                lista.Add(cliente);

            }
            return lista;
        }
        public static List<clsProducto> listarProducto()
        {
            List<clsProducto> lista = new List<clsProducto>();

            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "select *from producto";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.CommandType = System.Data.CommandType.Text;
            SQLiteDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                clsProducto producto = new   clsProducto();
                producto.Id = datos["id_producto"].ToString();
                producto.Nombre = datos["nombre"].ToString();
                producto.Descripcion = datos["descripcion"].ToString();
                producto.PCompra = datos["precioCompra"].ToString();
                producto.PVenta = datos["precioVenta"].ToString();
                producto.Cantidad = datos["cantidad"].ToString();
                lista.Add(producto);

            }
            return lista;
        }
        public static List<clsFactura> listarFactura()
        {
            List<clsFactura> lista = new List<clsFactura>();

            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "select *from factura";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.CommandType = System.Data.CommandType.Text;
            SQLiteDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                clsFactura factura = new clsFactura();
                factura.Codigo = datos["cod_factura"].ToString();
                factura.Fecha = datos["fecha"].ToString();
                factura.Cliente = datos["cliente"].ToString();
                factura.Empleado = datos["empleado"].ToString();
                factura.Total = datos["total"].ToString();
                lista.Add(factura);

            }
            return lista;
        }
    }
    
}
