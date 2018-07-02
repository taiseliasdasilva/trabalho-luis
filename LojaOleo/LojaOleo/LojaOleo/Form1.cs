using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaOleo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.Email = txtEmail.Text;
            obj.Senha = txtSenha.Text;

            try
            {
                var usuario = UsuarioDAO.Logar(obj);

                if (!usuario.Senha.Equals(txtSenha.Text))
                {
                    txtSenha.Clear();

                    MessageBox.Show("Senha Inválida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSenha.Focus();
                }
                else
                {
                    MessageBox.Show("Logado com sucesso!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERRO: " + er.Message);
            }
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
