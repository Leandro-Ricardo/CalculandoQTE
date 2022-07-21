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
              
            double altura = Convert.ToDouble(boxA.Text, CultureInfo.InvariantCulture);
            double largura = Convert.ToDouble(boxL.Text, CultureInfo.InvariantCulture);
            double resultadoM2 = largura * altura;            
            textResultado.Text = resultadoM2.ToString(CultureInfo.InvariantCulture);

            string resultadoQtem2 = (1 / resultadoM2).ToString("F2");
            resultadoQteM2.Text = resultadoQtem2;

            double qteAdesivos = Convert.ToDouble(quantidadeAdesivos.Text, CultureInfo.InvariantCulture);
            double resultadoAdesivosQte = ((qteAdesivos * resultadoM2) * 60);
            if (resultadoAdesivosQte <= 60) resultadoSemCorte.Text = "Valor mín R$" + 60.ToString("F2");
            else resultadoSemCorte.Text = "R$" + resultadoAdesivosQte.ToString("F2");
            
            qteAdesivos = Convert.ToDouble(quantidadeAdesivos.Text, CultureInfo.InvariantCulture);
            resultadoAdesivosQte = ((qteAdesivos * resultadoM2) * 90);
            if (resultadoAdesivosQte <= 70) resultadoComCorte.Text = "Valor mín R$" + 70.ToString("F2");
            else resultadoComCorte.Text = "R$" + resultadoAdesivosQte.ToString("F2");

            
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
