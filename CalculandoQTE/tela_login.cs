using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculandoQTE
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
            
        }

        private void botaoConectar_Click(object sender, EventArgs e)
        {
            if (boxSenha.Text == "226592")
            {
                

                NomePrograma nm = new NomePrograma();
                nm.Show();
                nm.Visible = true;


            }
            else
            {
                MessageBox.Show("Senha errada!");
                Close();
            }
            
        }

        private void boxSenha_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void tela_login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
