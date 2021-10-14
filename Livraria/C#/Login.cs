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

        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ODU8ATV0\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_livraria");

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

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar os campos de login e senha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where ds_Login = ('" + txtLogin.Text + "') and ds_Senha = ('" + txtSenha.Text + "')";
                    cm.Connection = cn;
                    dt = cm.ExecuteReader();

                    if(dt.HasRows)
                    {
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!", "Credenciais inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
