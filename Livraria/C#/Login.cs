using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // biblioteca SQL


namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Estabelecendo conexão com o banco de dados SQLServer

        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ODU8ATV0\SQLEXPRESS;integrated security=SSPI;Catalog=db_livraria");

        SqlCommand cm = new SqlCommand(); // envia instruções para o db
        SqlDataReader dt; // só funciona com "select"

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            if (txtSenha.UseSystemPasswordChar == false)
            {
                btnEsconderSenha.BringToFront();
            }
         }

        private void btnVerSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            if (txtSenha.UseSystemPasswordChar == true)
            {
                btnVerSenha.BringToFront();
            }

        }

        
    }
}
