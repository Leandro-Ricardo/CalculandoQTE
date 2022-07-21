using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace CalculandoQTE
{
    
    public partial class tela_login : Form
    {
        Thread nt;
        public tela_login()
        {
            InitializeComponent();
            
        }

        private void botaoConectar_Click(object sender, EventArgs e)
        {
            if (boxSenha.Text == "226592")
            {

                this.Close();

                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                NomePrograma nm = new NomePrograma();
                nm.Show();
                nm.Visible = true;


            }
            else
            {
                MessageBox.Show("Senha errada!");
                
            }
            
        }

        private void novoForm()
        {
            Application.Run(new NomePrograma());
        }

        private void boxSenha_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void tela_login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
