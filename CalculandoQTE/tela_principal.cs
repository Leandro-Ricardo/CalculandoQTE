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
                MessageBox.Show("                       " +
                    "O tempo expirou, \n" +
                    "favor entrar em contato com o desenvolvedor! \n\n   " +
                    "(21) 97253-6323 / leandroricardo@live.com"); ;
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

                //CALCULA O METRO QUADRADO DO OBJ                
                double Largura = Convert.ToDouble(BoxLargura.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double Altura = Convert.ToDouble(BoxAltura.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double ResultDoMetroQuadrado = (Largura * Altura);
                double ResultDoMetroQuadradoLona = Largura * Altura;



                //TEXTO DO METRO QUADRADO
                ResultMetroQuadradoAdesivo.Text = $"{ResultDoMetroQuadrado} mm";


                //EXIBE A QUANTIDADE DE ADESIVOS NO METRO QUADRADO                
                string QtdeNoMetroQuadrado = (1 / ResultDoMetroQuadrado).ToString("F0");
                TextoResultQtdePorMetroQuadrado.Text = $"{QtdeNoMetroQuadrado} un";


                //EXIBE A QUANTIDADE MÁXIMA DE ADESIVOS NO VALOR MÍNIMO                
                string MinQtdeMetroQuadrado = (0.6666 / ResultDoMetroQuadrado).ToString("F0");
                //VERIFICADOR PARA O IF
                double VerificadorMinQtdeMetroQuadrado = Convert.ToDouble(MinQtdeMetroQuadrado);
                TextoResultadoQtdMin.Text = $"{MinQtdeMetroQuadrado} un";


                //BOX DA QUANTIDADE DE ADESIVOS
                double BoxQtdeAdesivos = Convert.ToDouble(BoxQuantidadeAdesivos.Text.Replace(" ", "0"));



                double AuxQtdeAdesivos = 0;
                if (BoxQtdeAdesivos != 0)
                {

                    //CALCULA O VALOR DOS ADESIVOS SEM O CORTE
                    AuxQtdeAdesivos = ((BoxQtdeAdesivos * ResultDoMetroQuadrado) * 60);
                    if (VerificadorMinQtdeMetroQuadrado >= BoxQtdeAdesivos) TextoResultadoSemCorte.Text = "Valor mín R$" + 40.ToString("F2");
                    else TextoResultadoSemCorte.Text = "R$" + AuxQtdeAdesivos.ToString("F2");


                    //CALCULA O VALOR DOS ADESIVOS COM CORTE                    
                    AuxQtdeAdesivos = ((BoxQtdeAdesivos * ResultDoMetroQuadrado) * 90);
                    if (VerificadorMinQtdeMetroQuadrado >= BoxQtdeAdesivos) TextoResultadoComCorte.Text = "Valor mín R$" + 70.ToString("F2");
                    else TextoResultadoComCorte.Text = "R$" + AuxQtdeAdesivos.ToString("F2");


                    //CALCULA O VALOR DO ADESIVO RETROVERSO               
                    AuxQtdeAdesivos = ((BoxQtdeAdesivos * ResultDoMetroQuadrado) * 182);
                    if (VerificadorMinQtdeMetroQuadrado >= BoxQtdeAdesivos) TextoResultadoRetroverso.Text = "Valor mín R$" + 80.ToString("F2");
                    else TextoResultadoRetroverso.Text = "R$" + AuxQtdeAdesivos.ToString("F2");

                    /*
                    //CALCULA O VALOR DA LONA C/ TUBETE E CORDA                    
                    double TubeteCorda = (ResultDoMetroQuadradoLona * 60);
                    if (TubeteCorda <= 40) TextoResultadoTubeteCorda.Text = "Valor mín R$" + 40.ToString("F2");
                    else TextoResultadoTubeteCorda.Text = "R$" + TubeteCorda.ToString("F2");


                    //CALCULA O VALOR DA LONA C/ ILHÓS                    
                    double Ilhos = (ResultDoMetroQuadradoLona * 80);
                    if (Ilhos <= 60) TextoResultadoIlhos.Text = "Valor mín R$" + 60.ToString("F2");
                    else TextoResultadoIlhos.Text = "R$" + Ilhos.ToString("F2");
                    */
                }

                else if (BoxQuantidadeAdesivos.Text == "0" || BoxQuantidadeAdesivos.Text == null)
                {
                    //RETORNA O VALOR DE ZERO AOS VALORES
                    TextoResultadoSemCorte.Text = "R$ 0,00";
                    TextoResultadoComCorte.Text = "R$ 0,00";
                    TextoResultadoRetroverso.Text = "R$ 0,00";
                }
            }
            catch (SystemException erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            };

        }

        private object textAltura_Click(object sender)
        {
            throw new NotImplementedException();
        }

        private string textLargura_Click(object sender)
        {
            throw new NotImplementedException();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextoResultadoAdesivos_Click(object sender, EventArgs e)
        {

        }

        private void TextoQuantidadeAdesivosM2_Click(object sender, EventArgs e)
        {

        }

        private void TextoComCorte_Click(object sender, EventArgs e)
        {

        }

        private void TextoResultadoComCorte_Click(object sender, EventArgs e)
        {

        }

        private void TextoResultadoLona_Click(object sender, EventArgs e)
        {

        }

        private void TextoTubeteCorda_Click(object sender, EventArgs e)
        {

        }

        private void un_Click(object sender, EventArgs e)
        {

        }

        private void TextoQuantidadeAdesivos_Click_1(object sender, EventArgs e)
        {

        }

        private void TextoX_Click(object sender, EventArgs e)
        {

        }

        private void mm1_Click(object sender, EventArgs e)
        {

        }

        private void mm2_Click(object sender, EventArgs e)
        {

        }

        private void ResultMetroQuadradoAdesivo_Click(object sender, EventArgs e)
        {

        }
    }
}
