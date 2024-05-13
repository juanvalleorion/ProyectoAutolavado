using ProyectoAutolavado.Clases;
using ProyectoAutolavado.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutolavado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Clases.Conexion objetoConexion = new Clases.Conexion();
            objetoConexion.establecerConexion();
            txt_Password.PasswordChar = '*';
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-02M9DT1;Initial Catalog=Autolavado; Integrate Security=True");

        Clases.Conexion con = new Clases.Conexion();
        public void Ingresar(string user, string password)
        {
            try
            {
                Conexion objetoConexion = new Conexion();
                
                SqlCommand cmd = new SqlCommand("SELECT usuario, tipo_Usuario from Usuario where usuario = @usuario and password= @pas",Cadena);
                cmd.Parameters.AddWithValue("usuario", user);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "ADMIN")
                    {
                        new Pantalla_Administrador().Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "USUARIO")
                    {
                        new Pantalla_Vendedor().Show();
                    }
                }
            }
            catch (Exception e) {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            finally
            {
                
            }
            }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            Ingresar(this.txt_Usuario.Text, this.txt_Password.Text);
        }
    }

   

    
} 
