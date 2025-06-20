namespace Login.Config
{
    using System;
    using System.Data.SqlClient;
    class Conexion
    {
        //sqlconnection    Sirve para abrir o cerrar la conexión a la base de datos
        //sqlDataReader    Leer los datos
        //sqlCommand       Ejecuta las consultas

        /* private string uid = "sa";
        private string pwd = "123";
        private string server = "";
        private string database = "Cuarto_MaySep2025"; */

        private readonly string cadenaConexion = "server=(local);database=Cuarto_MaySep2025;uid=Login;pwd=1234;Trusted_Connection=True";
        private SqlConnection conexion;
        

        public SqlConnection AbrirConexion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(cadenaConexion);
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            return conexion;
        }

        public void CerrarConexion ()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }

        }

    }
}
