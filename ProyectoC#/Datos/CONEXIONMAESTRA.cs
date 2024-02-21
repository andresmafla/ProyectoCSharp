using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoC_.Datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = @"Data Source=LAPTOP-2LN2IJAQ\SQLEXPRESS;Initial Catalog=ASM1.0;Integrated Security=True";
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void Abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
