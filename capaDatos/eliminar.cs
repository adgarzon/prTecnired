using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace capaDatos
{
    public class eliminar
    {
        public static void eliminarEmpleado(string id)
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "delete from empleado where cedula = " + id;
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.ExecuteNonQuery();
        }
        public static void eliminarCliente(string id)
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "delete from cliente where cedula = " + id;
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.ExecuteNonQuery();
        }
        public static void eliminarProducto(string id)
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            conexion.Open();
            string query = "delete from producto where id_producto = " + id;
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.ExecuteNonQuery();
        }
    }
}
