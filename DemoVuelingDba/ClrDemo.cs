using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void ClrDemo()
    {
        SqlContext.Pipe.Send("Hello world.\n");
        string cadSql = string.Empty;

        try
        {
            using (SqlConnection conexion = new SqlConnection("context connection=true"))
            {
                conexion.Open();
                SqlContext.Pipe.Send("La conexion ha sido abierta");

                cadSql = "select Nombre from Alumnos";
                using (SqlCommand comando = new SqlCommand(cadSql, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SqlContext.Pipe.Send($"Alumno con Nombre: " + reader.GetString(0));
                        }
                    }
                }

            }
        }
        catch
        {
            throw;
        }
    }
}
