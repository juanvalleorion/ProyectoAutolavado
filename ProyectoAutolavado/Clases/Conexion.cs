using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;

namespace ProyectoAutolavado.Clases
{
    class Conexion
    {
        SqlConnection connet = new SqlConnection();
        /*
        static string servidor = "tecproyecto.database.windows.net";
        static string bd = "Lavado_Juarez";
        static string usuario = "tec";
        static string password = "proyecto123@";
        static string puerto = "1433";
        */
        static string servidor = "DESKTOP-02M9DT1";
        static string bd = "Autolavado";
        static string usuario = "sa";
        static string password = "juanvalle";
        static string puerto = "1433";

        string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + 
            "user id=" + usuario + ";" + "password=" + 
            password + ";" + "Initial Catalog=" + bd + 
            ";" + "Persist Security Info=true";

    
    public SqlConnection establecerConexion()
        {

            try
            {
                connet.ConnectionString = cadenaConexion;
                connet.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos");

            }
            catch (SqlException e)
            {

                MessageBox.Show("No se logró conectar a la Base de Datos" + e.ToString());
            }

            return connet;
        }

    }
}
