﻿using System;
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
            double altura = Convert.ToDouble(boxA.Text);
            double largura = Convert.ToDouble(boxL.Text);
            double resultado = largura * altura;

            textResultado.Text = resultado.ToString("F3", CultureInfo.InvariantCulture);
        }
    }
}
