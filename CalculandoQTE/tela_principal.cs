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
    public partial class ProgramaPrincipal : Form
    {
        public ProgramaPrincipal()
        {
            DateTime d = new DateTime(2022, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            if (d <= DateTime.Now)
            {
                MessageBox.Show("O tempo expirou, favor entrar em contato com o desenvolvedor!");
                this.Close();
            }
            else
            {

            }

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
                double altura = Convert.ToDouble(BoxAltura.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double largura = Convert.ToDouble(BoxLargura.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double resultadoM2 = largura * altura;
                TextoResultadoM2Produto.Text = resultadoM2.ToString(CultureInfo.InvariantCulture) + " mm";

                //Exibe a quantidade de adesivos no metro quadrado
                string resultadoQtem2 = (1 / resultadoM2).ToString("F0");
                TextoResultadoQtdM2.Text = resultadoQtem2 + " un";

                //Exibe a quantidade máxima de adesivos no valor mínimo
                resultadoQtem2 = (0.7777 / resultadoM2).ToString("F0");
                TextoResultadoQtdMin.Text = resultadoQtem2 + " un";


                //Escolhe a quantidade de adesivos            
                double qteAdesivos = Convert.ToDouble(BoxQuantidadeAdesivos.Text.Replace(" ", "0"), CultureInfo.InvariantCulture);

                double resultadoAdesivosQte = 0.0;
                //Calcula o valor dos adesivos sem o corte
                if (qteAdesivos != 0)
                {
                    resultadoAdesivosQte = ((qteAdesivos * resultadoM2) * 60);
                    if (resultadoAdesivosQte <= 60) TextoResultadoSemCorte.Text = "Valor mín R$" + 60.ToString("F2");
                    else TextoResultadoSemCorte.Text = "R$" + resultadoAdesivosQte.ToString("F2");

                    //Calcula o valor dos adesivos com corte
                    resultadoAdesivosQte = ((qteAdesivos * resultadoM2) * 90);
                    if (resultadoAdesivosQte <= 70) TextoResultadoComCorte.Text = "Valor mín R$" + 70.ToString("F2");
                    else TextoResultadoComCorte.Text = "R$" + resultadoAdesivosQte.ToString("F2");

                    //Calcula o valor do adesivo retroverso                
                    resultadoAdesivosQte = ((qteAdesivos * resultadoM2) * 182);
                    if (resultadoAdesivosQte <= 80) TextoRresultadoRetroverso.Text = "Valor mín R$" + 80.ToString("F2");
                    else TextoRresultadoRetroverso.Text = "R$" + resultadoAdesivosQte.ToString("F2");

                    //Calcula o valor da lona c/ tubete e corda
                    double tubeteCorda = resultadoM2 * 60;
                    if (tubeteCorda <= 40) TextoResultadoTubeteCorda.Text = "Valor mín R$" + 40.ToString("F2");
                    else TextoResultadoTubeteCorda.Text = "R$" + tubeteCorda.ToString("F2");

                    //Calcula o valor da lona c/ ilhós
                    double ilhos = resultadoM2 * 80;
                    if (ilhos <= 60) TextoResultadoIlhos.Text = "Valor mín R$" + 60.ToString("F2");
                    else TextoResultadoIlhos.Text = "R$" + ilhos.ToString("F2");


                }
                else if (BoxQuantidadeAdesivos.Text == "0" || BoxQuantidadeAdesivos.Text == null)
                {
                    TextoResultadoSemCorte.Text = "R$ " + (0 * resultadoAdesivosQte).ToString("F2");
                    TextoResultadoComCorte.Text = "R$ " + (0 * resultadoAdesivosQte).ToString("F2");
                    TextoRresultadoRetroverso.Text = "R$ " + (0 * resultadoAdesivosQte).ToString("F2");
                }
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

        private void ilhos_Click(object sender, EventArgs e)
        {

        }

        private void resultadoTubeteCorda_Click(object sender, EventArgs e)
        {

        }

        private void resultadoIlhos_Click(object sender, EventArgs e)
        {

        }

        private void adesivoRetroverso_Click(object sender, EventArgs e)
        {

        }

        private void resultadoRetroverso_Click(object sender, EventArgs e)
        {

        }

        private void textAltura_Click(object sender, EventArgs e)
        {

        }

        private void textM2_Click(object sender, EventArgs e)
        {

        }

        private void TextoQuantidadeAdesivos_Click(object sender, EventArgs e)
        {

        }

        private void TextoQuantidadeMaxMinM2_Click(object sender, EventArgs e)
        {

        }

        private void TextoResultadoQtdMin_Click(object sender, EventArgs e)
        {

        }

        private void tabAdesivos_Click(object sender, EventArgs e)
        {

        }

        private void TextoSemCorte_Click(object sender, EventArgs e)
        {

        }

        private void tabLona_Click(object sender, EventArgs e)
        {

        }

        private void BoxQuantidadeAdesivos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
