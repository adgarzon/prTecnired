using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using capaEntidades;

namespace capaDatos
{
    public class guardar
    {

        public static bool guardarEmpleado(clsEmpleado obj)
        {
            bool respuesta = true;
            SQLiteConnection cadConexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            cadConexion.Open();
            string query = "insert into empleado(cedula,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,salario,celular) values(@cedula,@primer_nombre,@segundo_nombre,@primer_apellido,@segundo_apellido,@salario,@celular)";

            SQLiteCommand cmd = new SQLiteCommand(query, cadConexion);
            cmd.Parameters.Add(new SQLiteParameter("@cedula", obj.Cedula));
            cmd.Parameters.Add(new SQLiteParameter("@primer_nombre", obj.PNombre));
            cmd.Parameters.Add(new SQLiteParameter("@segundo_nombre", obj.SNombre));
            cmd.Parameters.Add(new SQLiteParameter("@primer_apellido", obj.PApellido));
            cmd.Parameters.Add(new SQLiteParameter("@segundo_apellido", obj.SApellido));
            cmd.Parameters.Add(new SQLiteParameter("@salario", obj.Salario));
            cmd.Parameters.Add(new SQLiteParameter("@celular", obj.Celular));
            cmd.CommandType = System.Data.CommandType.Text;

            if (cmd.ExecuteNonQuery() < 1)
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool guardarCliente(clsCliente obj)
        {
            bool respuesta = true;
            SQLiteConnection cadConexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            cadConexion.Open();
            string query = "insert into cliente(cedula,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,direccion,celular) values(@cedula,@primer_nombre,@segundo_nombre,@primer_apellido,@segundo_apellido,@direccion,@celular)";

            SQLiteCommand cmd = new SQLiteCommand(query, cadConexion);
            cmd.Parameters.Add(new SQLiteParameter("@cedula", obj.Cedula));
            cmd.Parameters.Add(new SQLiteParameter("@primer_nombre", obj.PNombre));
            cmd.Parameters.Add(new SQLiteParameter("@segundo_nombre", obj.SNombre));
            cmd.Parameters.Add(new SQLiteParameter("@primer_apellido", obj.PApellido));
            cmd.Parameters.Add(new SQLiteParameter("@segundo_apellido", obj.SApellido));
            cmd.Parameters.Add(new SQLiteParameter("@direccion", obj.Direccion));
            cmd.Parameters.Add(new SQLiteParameter("@celular", obj.Celular));
            cmd.CommandType = System.Data.CommandType.Text;

            if (cmd.ExecuteNonQuery() < 1)
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool guardarProducto(clsProducto obj)
        {
            bool respuesta = true;
            SQLiteConnection cadConexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            cadConexion.Open();
            string query = "insert into producto(nombre,descripcion,precioCompra,precioVenta,cantidad) values(@nombre,@descripcion,@precioCompra,@precioVenta,@cantidad)";

            SQLiteCommand cmd = new SQLiteCommand(query, cadConexion);
            cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@descripcion", obj.Descripcion));
            cmd.Parameters.Add(new SQLiteParameter("@precioCompra", obj.PCompra));
            cmd.Parameters.Add(new SQLiteParameter("@precioVenta", obj.PVenta));
            cmd.Parameters.Add(new SQLiteParameter("@cantidad", obj.Cantidad));
            cmd.CommandType = System.Data.CommandType.Text;

            if (cmd.ExecuteNonQuery() < 1)
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool guardarFactura(clsFactura obj)
        {
            bool respuesta = true;
            SQLiteConnection cadConexion = new SQLiteConnection("Data Source = C:/Users/PC/Documents/UPC/VI_SEMESTRE/ING_SOFTWARE_II/proyecto/prTecnired/tecnired.db");
            cadConexion.Open();
            string query = "insert into factura(fecha,cliente,empleado,total) values(@fecha,@cliente,@empleado,@total)";

            SQLiteCommand cmd = new SQLiteCommand(query, cadConexion);
            cmd.Parameters.Add(new SQLiteParameter("@fecha", obj.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@cliente", obj.Cliente));
            cmd.Parameters.Add(new SQLiteParameter("@empleado", obj.Empleado));
            cmd.Parameters.Add(new SQLiteParameter("@total", obj.Total));
            cmd.CommandType = System.Data.CommandType.Text;

            if (cmd.ExecuteNonQuery() < 1)
            {
                respuesta = false;
            }
            return respuesta;
        }


    }
}
