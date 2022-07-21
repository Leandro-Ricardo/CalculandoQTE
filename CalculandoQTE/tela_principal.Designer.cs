
namespace CalculandoQTE
{
    partial class ProgramaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramaPrincipal));
            this.textLargura = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.Label();
            this.boxL = new System.Windows.Forms.TextBox();
            this.boxA = new System.Windows.Forms.TextBox();
            this.textM2 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.ListaResultado = new System.Windows.Forms.Label();
            this.quantidadeItens = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.resultadoQteM2 = new System.Windows.Forms.Label();
            this.semCorte = new System.Windows.Forms.Label();
            this.comCorte = new System.Windows.Forms.Label();
            this.resultadoSemCorte = new System.Windows.Forms.Label();
            this.resultadoComCorte = new System.Windows.Forms.Label();
            this.qteAdesivos = new System.Windows.Forms.Label();
            this.quantidadeAdesivos = new System.Windows.Forms.TextBox();
            this.resultadoLona = new System.Windows.Forms.Label();
            this.tubeteCorda = new System.Windows.Forms.Label();
            this.ilhos = new System.Windows.Forms.Label();
            this.resultadoTubeteCorda = new System.Windows.Forms.Label();
            this.resultadoIlhos = new System.Windows.Forms.Label();
            this.adesivoRetroverso = new System.Windows.Forms.Label();
            this.resultadoRetroverso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLargura
            // 
            this.textLargura.AutoSize = true;
            this.textLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLargura.Location = new System.Drawing.Point(47, 47);
            this.textLargura.Name = "textLargura";
            this.textLargura.Size = new System.Drawing.Size(57, 16);
            this.textLargura.TabIndex = 1;
            this.textLargura.Text = "Largura:";
            this.textLargura.Click += new System.EventHandler(this.textLargura_Click);
            // 
            // textAltura
            // 
            this.textAltura.AutoSize = true;
            this.textAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.Location = new System.Drawing.Point(53, 100);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(45, 16);
            this.textAltura.TabIndex = 2;
            this.textAltura.Text = "Altura:";
            // 
            // textX
            // 
            this.textX.AutoSize = true;
            this.textX.ForeColor = System.Drawing.Color.Red;
            this.textX.Location = new System.Drawing.Point(68, 84);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(12, 13);
            this.textX.TabIndex = 3;
            this.textX.Text = "x";
            // 
            // boxL
            // 
            this.boxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxL.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.boxL.Location = new System.Drawing.Point(47, 64);
            this.boxL.MaxLength = 10;
            this.boxL.Name = "boxL";
            this.boxL.Size = new System.Drawing.Size(53, 22);
            this.boxL.TabIndex = 4;
            this.boxL.Text = "0.0";
            this.boxL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxL.TextChanged += new System.EventHandler(this.boxL_TextChanged);
            // 
            // boxA
            // 
            this.boxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxA.Location = new System.Drawing.Point(47, 116);
            this.boxA.MaxLength = 10;
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(53, 22);
            this.boxA.TabIndex = 5;
            this.boxA.Text = "0.0";
            this.boxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxA.TextChanged += new System.EventHandler(this.boxA_TextChanged);
            // 
            // textM2
            // 
            this.textM2.AutoSize = true;
            this.textM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textM2.ForeColor = System.Drawing.Color.Red;
            this.textM2.Location = new System.Drawing.Point(169, 20);
            this.textM2.Name = "textM2";
            this.textM2.Size = new System.Drawing.Size(86, 16);
            this.textM2.TabIndex = 6;
            this.textM2.Text = "M² Produto = ";
            // 
            // textResultado
            // 
            this.textResultado.AutoSize = true;
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.ForeColor = System.Drawing.Color.Red;
            this.textResultado.Location = new System.Drawing.Point(246, 20);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(15, 16);
            this.textResultado.TabIndex = 7;
            this.textResultado.Text = "0";
            this.textResultado.Click += new System.EventHandler(this.textResultado_Click);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.AccessibleDescription = "";
            this.botaoCalcular.AccessibleName = "";
            this.botaoCalcular.Location = new System.Drawing.Point(310, 294);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(75, 23);
            this.botaoCalcular.TabIndex = 8;
            this.botaoCalcular.Text = "calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // ListaResultado
            // 
            this.ListaResultado.AutoSize = true;
            this.ListaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaResultado.Location = new System.Drawing.Point(155, 55);
            this.ListaResultado.Name = "ListaResultado";
            this.ListaResultado.Size = new System.Drawing.Size(133, 16);
            this.ListaResultado.TabIndex = 9;
            this.ListaResultado.Text = "Resultado Adesivos:";
            this.ListaResultado.UseMnemonic = false;
            // 
            // quantidadeItens
            // 
            this.quantidadeItens.AutoSize = true;
            this.quantidadeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeItens.Location = new System.Drawing.Point(155, 71);
            this.quantidadeItens.Name = "quantidadeItens";
            this.quantidadeItens.Size = new System.Drawing.Size(122, 16);
            this.quantidadeItens.TabIndex = 10;
            this.quantidadeItens.Text = "Quantidade por M²:";
            // 
            // resultadoQteM2
            // 
            this.resultadoQteM2.AutoSize = true;
            this.resultadoQteM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoQteM2.ForeColor = System.Drawing.Color.Red;
            this.resultadoQteM2.Location = new System.Drawing.Point(271, 71);
            this.resultadoQteM2.Name = "resultadoQteM2";
            this.resultadoQteM2.Size = new System.Drawing.Size(15, 16);
            this.resultadoQteM2.TabIndex = 11;
            this.resultadoQteM2.Text = "0";
            this.resultadoQteM2.Click += new System.EventHandler(this.resultadoQteM2_Click);
            // 
            // semCorte
            // 
            this.semCorte.AutoSize = true;
            this.semCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semCorte.Location = new System.Drawing.Point(155, 97);
            this.semCorte.Name = "semCorte";
            this.semCorte.Size = new System.Drawing.Size(75, 16);
            this.semCorte.TabIndex = 12;
            this.semCorte.Text = "Sem corte: ";
            // 
            // comCorte
            // 
            this.comCorte.AutoSize = true;
            this.comCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCorte.Location = new System.Drawing.Point(155, 116);
            this.comCorte.Name = "comCorte";
            this.comCorte.Size = new System.Drawing.Size(72, 16);
            this.comCorte.TabIndex = 13;
            this.comCorte.Text = "Com corte:";
            // 
            // resultadoSemCorte
            // 
            this.resultadoSemCorte.AutoSize = true;
            this.resultadoSemCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoSemCorte.ForeColor = System.Drawing.Color.Red;
            this.resultadoSemCorte.Location = new System.Drawing.Point(221, 97);
            this.resultadoSemCorte.Name = "resultadoSemCorte";
            this.resultadoSemCorte.Size = new System.Drawing.Size(35, 16);
            this.resultadoSemCorte.TabIndex = 14;
            this.resultadoSemCorte.Text = "R$ 0";
            this.resultadoSemCorte.Click += new System.EventHandler(this.resultadoSemCorte_Click);
            // 
            // resultadoComCorte
            // 
            this.resultadoComCorte.AutoSize = true;
            this.resultadoComCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoComCorte.ForeColor = System.Drawing.Color.Red;
            this.resultadoComCorte.Location = new System.Drawing.Point(221, 116);
            this.resultadoComCorte.Name = "resultadoComCorte";
            this.resultadoComCorte.Size = new System.Drawing.Size(35, 16);
            this.resultadoComCorte.TabIndex = 15;
            this.resultadoComCorte.Text = "R$ 0";
            // 
            // qteAdesivos
            // 
            this.qteAdesivos.AutoSize = true;
            this.qteAdesivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteAdesivos.Location = new System.Drawing.Point(31, 154);
            this.qteAdesivos.Name = "qteAdesivos";
            this.qteAdesivos.Size = new System.Drawing.Size(89, 16);
            this.qteAdesivos.TabIndex = 16;
            this.qteAdesivos.Text = "Qte Adesivos";
            // 
            // quantidadeAdesivos
            // 
            this.quantidadeAdesivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeAdesivos.Location = new System.Drawing.Point(47, 171);
            this.quantidadeAdesivos.Name = "quantidadeAdesivos";
            this.quantidadeAdesivos.Size = new System.Drawing.Size(53, 22);
            this.quantidadeAdesivos.TabIndex = 17;
            this.quantidadeAdesivos.Text = "0";
            this.quantidadeAdesivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidadeAdesivos.TextChanged += new System.EventHandler(this.quantidadeAdesivos_TextChanged);
            // 
            // resultadoLona
            // 
            this.resultadoLona.AutoSize = true;
            this.resultadoLona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLona.Location = new System.Drawing.Point(155, 186);
            this.resultadoLona.Name = "resultadoLona";
            this.resultadoLona.Size = new System.Drawing.Size(106, 16);
            this.resultadoLona.TabIndex = 18;
            this.resultadoLona.Text = "Resultado Lona:";
            // 
            // tubeteCorda
            // 
            this.tubeteCorda.AutoSize = true;
            this.tubeteCorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tubeteCorda.Location = new System.Drawing.Point(155, 208);
            this.tubeteCorda.Name = "tubeteCorda";
            this.tubeteCorda.Size = new System.Drawing.Size(105, 16);
            this.tubeteCorda.TabIndex = 19;
            this.tubeteCorda.Text = "Tubete e Corda:";
            // 
            // ilhos
            // 
            this.ilhos.AutoSize = true;
            this.ilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilhos.Location = new System.Drawing.Point(157, 228);
            this.ilhos.Name = "ilhos";
            this.ilhos.Size = new System.Drawing.Size(39, 16);
            this.ilhos.TabIndex = 20;
            this.ilhos.Text = "Ilhós:";
            this.ilhos.Click += new System.EventHandler(this.ilhos_Click);
            // 
            // resultadoTubeteCorda
            // 
            this.resultadoTubeteCorda.AutoSize = true;
            this.resultadoTubeteCorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTubeteCorda.ForeColor = System.Drawing.Color.Red;
            this.resultadoTubeteCorda.Location = new System.Drawing.Point(254, 208);
            this.resultadoTubeteCorda.Name = "resultadoTubeteCorda";
            this.resultadoTubeteCorda.Size = new System.Drawing.Size(35, 16);
            this.resultadoTubeteCorda.TabIndex = 21;
            this.resultadoTubeteCorda.Text = "R$ 0";
            this.resultadoTubeteCorda.Click += new System.EventHandler(this.resultadoTubeteCorda_Click);
            // 
            // resultadoIlhos
            // 
            this.resultadoIlhos.AutoSize = true;
            this.resultadoIlhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoIlhos.ForeColor = System.Drawing.Color.Red;
            this.resultadoIlhos.Location = new System.Drawing.Point(254, 228);
            this.resultadoIlhos.Name = "resultadoIlhos";
            this.resultadoIlhos.Size = new System.Drawing.Size(35, 16);
            this.resultadoIlhos.TabIndex = 22;
            this.resultadoIlhos.Text = "R$ 0";
            this.resultadoIlhos.Click += new System.EventHandler(this.resultadoIlhos_Click);
            // 
            // adesivoRetroverso
            // 
            this.adesivoRetroverso.AutoSize = true;
            this.adesivoRetroverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adesivoRetroverso.Location = new System.Drawing.Point(155, 143);
            this.adesivoRetroverso.Name = "adesivoRetroverso";
            this.adesivoRetroverso.Size = new System.Drawing.Size(131, 16);
            this.adesivoRetroverso.TabIndex = 23;
            this.adesivoRetroverso.Text = "Adesivo Retroverso:";
            this.adesivoRetroverso.Click += new System.EventHandler(this.adesivoRetroverso_Click);
            // 
            // resultadoRetroverso
            // 
            this.resultadoRetroverso.AutoSize = true;
            this.resultadoRetroverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoRetroverso.ForeColor = System.Drawing.Color.Red;
            this.resultadoRetroverso.Location = new System.Drawing.Point(280, 143);
            this.resultadoRetroverso.Name = "resultadoRetroverso";
            this.resultadoRetroverso.Size = new System.Drawing.Size(35, 16);
            this.resultadoRetroverso.TabIndex = 24;
            this.resultadoRetroverso.Text = "R$ 0";
            this.resultadoRetroverso.Click += new System.EventHandler(this.resultadoRetroverso_Click);
            // 
            // ProgramaPrincipal
            // 
            this.AcceptButton = this.botaoCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 329);
            this.Controls.Add(this.resultadoRetroverso);
            this.Controls.Add(this.adesivoRetroverso);
            this.Controls.Add(this.resultadoIlhos);
            this.Controls.Add(this.resultadoTubeteCorda);
            this.Controls.Add(this.ilhos);
            this.Controls.Add(this.tubeteCorda);
            this.Controls.Add(this.resultadoLona);
            this.Controls.Add(this.quantidadeAdesivos);
            this.Controls.Add(this.qteAdesivos);
            this.Controls.Add(this.resultadoComCorte);
            this.Controls.Add(this.resultadoSemCorte);
            this.Controls.Add(this.comCorte);
            this.Controls.Add(this.semCorte);
            this.Controls.Add(this.resultadoQteM2);
            this.Controls.Add(this.quantidadeItens);
            this.Controls.Add(this.ListaResultado);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textM2);
            this.Controls.Add(this.boxA);
            this.Controls.Add(this.boxL);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.textLargura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qteM² by Leandro Ricardo";
            this.Load += new System.EventHandler(this.NomePrograma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textLargura;
        private System.Windows.Forms.Label textAltura;
        private System.Windows.Forms.Label textX;
        private System.Windows.Forms.TextBox boxL;
        private System.Windows.Forms.TextBox boxA;
        private System.Windows.Forms.Label textM2;
        private System.Windows.Forms.Label textResultado;
        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.Label ListaResultado;
        private System.Windows.Forms.Label quantidadeItens;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label resultadoQteM2;
        private System.Windows.Forms.Label semCorte;
        private System.Windows.Forms.Label comCorte;
        private System.Windows.Forms.Label resultadoSemCorte;
        private System.Windows.Forms.Label resultadoComCorte;
        private System.Windows.Forms.Label qteAdesivos;
        private System.Windows.Forms.TextBox quantidadeAdesivos;
        private System.Windows.Forms.Label resultadoLona;
        private System.Windows.Forms.Label tubeteCorda;
        private System.Windows.Forms.Label ilhos;
        private System.Windows.Forms.Label resultadoTubeteCorda;
        private System.Windows.Forms.Label resultadoIlhos;
        private System.Windows.Forms.Label adesivoRetroverso;
        private System.Windows.Forms.Label resultadoRetroverso;
    }
}

