using System;
using System.Collections.Generic;
using System.Text;
using capaEntidades;
using System.Data.SQLite;
using System.Data;

namespace capaDatos
{
    public class buscar
    {
        public static DataTable buscarEmpleado(string id)
        {
            clsEmpleado emple = new clsEmpleado();

            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "select *from empleado where cedula = "+id;
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            var da = new SQLiteDataAdapter(cmd);

            var tabla = new DataTable();
            da.Fill(tabla);
            da.Dispose();
            return tabla;
        }
        public static DataTable buscarCliente(string id)
        {
            clsEmpleado emple = new clsEmpleado();

            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "select *from cliente where cedula = " + id;
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            var da = new SQLiteDataAdapter(cmd);

            var tabla = new DataTable();
            da.Fill(tabla);
            da.Dispose();
            return tabla;
        }
        public static DataTable buscarProducto(string id)
        {
            clsProducto emple = new clsProducto();

            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "select *from producto where id_producto = " + id;
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            var da = new SQLiteDataAdapter(cmd);

            var tabla = new DataTable();
            da.Fill(tabla);
            da.Dispose();
            return tabla;
        }
    }

}
