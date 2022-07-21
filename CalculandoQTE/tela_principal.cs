using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculandoQTE
{
    public partial class NomePrograma : Form
    {
        public NomePrograma()
        {
            InitializeComponent();
            
            
        }

        private void qteM2_Click(object sender, EventArgs e)
        {

        }

        private void textResultado_Click(object sender, EventArgs e)
        {

        }

        private void boxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxL_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Calcula o metro quadrado do obj
                double altura = Convert.ToDouble(boxA.Text, CultureInfo.InvariantCulture);
            double largura = Convert.ToDouble(boxL.Text, CultureInfo.InvariantCulture);
            double resultadoM2 = largura * altura;
            textResultado.Text = resultadoM2.ToString(CultureInfo.InvariantCulture);

            //Exibe a quantidade de adesivos no metro quadrado
            string resultadoQtem2 = (1 / resultadoM2).ToString("F2");
            resultadoQteM2.Text = resultadoQtem2;

            //Escolhe a quantidade de adesivos            
            double qteAdesivos = Convert.ToDouble(quantidadeAdesivos.Text, CultureInfo.InvariantCulture);

            //Calcula o valor dos adesivos sem o corte
            double resultadoAdesivosQte = ((qteAdesivos * resultadoM2) * 60);
            if (resultadoAdesivosQte <= 60) resultadoSemCorte.Text = "Valor mín R$" + 60.ToString("F2");
            else resultadoSemCorte.Text = "R$" + resultadoAdesivosQte.ToString("F2");
            
            //Calcula o valor dos adesivos com corte
            resultadoAdesivosQte = ((qteAdesivos * resultadoM2) * 90);
            if (resultadoAdesivosQte <= 70) resultadoComCorte.Text = "Valor mín R$" + 70.ToString("F2");
            else resultadoComCorte.Text = "R$" + resultadoAdesivosQte.ToString("F2");
            }

            catch (SystemException erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            };
            
        }


        private void textLargura_Click(object sender, EventArgs e)
        {

        }

        private void NomePrograma_Load(object sender, EventArgs e)
        {

        }

        private void resultadoQteM2_Click(object sender, EventArgs e)
        {

        }

        private void resultadoSemCorte_Click(object sender, EventArgs e)
        {

        }

        private void quantidadeAdesivos_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
