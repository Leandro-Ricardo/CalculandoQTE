
namespace CalculandoQTE
{
    partial class NomePrograma
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
            this.qteM2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // qteM2
            // 
            this.qteM2.AutoSize = true;
            this.qteM2.Location = new System.Drawing.Point(218, 9);
            this.qteM2.Name = "qteM2";
            this.qteM2.Size = new System.Drawing.Size(34, 13);
            this.qteM2.TabIndex = 0;
            this.qteM2.Text = "qteM²";
            this.qteM2.Click += new System.EventHandler(this.qteM2_Click);
            // 
            // textLargura
            // 
            this.textLargura.AutoSize = true;
            this.textLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLargura.Location = new System.Drawing.Point(33, 47);
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
            this.textAltura.Location = new System.Drawing.Point(39, 100);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(45, 16);
            this.textAltura.TabIndex = 2;
            this.textAltura.Text = "Altura:";
            // 
            // textX
            // 
            this.textX.AutoSize = true;
            this.textX.ForeColor = System.Drawing.Color.Red;
            this.textX.Location = new System.Drawing.Point(54, 84);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(12, 13);
            this.textX.TabIndex = 3;
            this.textX.Text = "x";
            // 
            // boxL
            // 
            this.boxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxL.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.boxL.Location = new System.Drawing.Point(33, 64);
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
            this.boxA.Location = new System.Drawing.Point(33, 116);
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
            this.textM2.Location = new System.Drawing.Point(129, 47);
            this.textM2.Name = "textM2";
            this.textM2.Size = new System.Drawing.Size(89, 16);
            this.textM2.TabIndex = 6;
            this.textM2.Text = "M² Adesivo = ";
            // 
            // textResultado
            // 
            this.textResultado.AutoSize = true;
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.ForeColor = System.Drawing.Color.Red;
            this.textResultado.Location = new System.Drawing.Point(212, 47);
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
            this.botaoCalcular.Location = new System.Drawing.Point(20, 221);
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
            this.ListaResultado.Location = new System.Drawing.Point(289, 46);
            this.ListaResultado.Name = "ListaResultado";
            this.ListaResultado.Size = new System.Drawing.Size(73, 16);
            this.ListaResultado.TabIndex = 9;
            this.ListaResultado.Text = "Resultado:";
            this.ListaResultado.UseMnemonic = false;
            // 
            // quantidadeItens
            // 
            this.quantidadeItens.AutoSize = true;
            this.quantidadeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeItens.Location = new System.Drawing.Point(111, 70);
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
            this.resultadoQteM2.Location = new System.Drawing.Point(231, 70);
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
            this.semCorte.Location = new System.Drawing.Point(289, 70);
            this.semCorte.Name = "semCorte";
            this.semCorte.Size = new System.Drawing.Size(75, 16);
            this.semCorte.TabIndex = 12;
            this.semCorte.Text = "Sem corte: ";
            // 
            // comCorte
            // 
            this.comCorte.AutoSize = true;
            this.comCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCorte.Location = new System.Drawing.Point(289, 100);
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
            this.resultadoSemCorte.Location = new System.Drawing.Point(355, 70);
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
            this.resultadoComCorte.Location = new System.Drawing.Point(354, 100);
            this.resultadoComCorte.Name = "resultadoComCorte";
            this.resultadoComCorte.Size = new System.Drawing.Size(35, 16);
            this.resultadoComCorte.TabIndex = 15;
            this.resultadoComCorte.Text = "R$ 0";
            // 
            // qteAdesivos
            // 
            this.qteAdesivos.AutoSize = true;
            this.qteAdesivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteAdesivos.Location = new System.Drawing.Point(17, 154);
            this.qteAdesivos.Name = "qteAdesivos";
            this.qteAdesivos.Size = new System.Drawing.Size(89, 16);
            this.qteAdesivos.TabIndex = 16;
            this.qteAdesivos.Text = "Qte Adesivos";
            // 
            // quantidadeAdesivos
            // 
            this.quantidadeAdesivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeAdesivos.Location = new System.Drawing.Point(33, 171);
            this.quantidadeAdesivos.Name = "quantidadeAdesivos";
            this.quantidadeAdesivos.Size = new System.Drawing.Size(53, 22);
            this.quantidadeAdesivos.TabIndex = 17;
            this.quantidadeAdesivos.Text = "0";
            this.quantidadeAdesivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidadeAdesivos.TextChanged += new System.EventHandler(this.quantidadeAdesivos_TextChanged);
            // 
            // NomePrograma
            // 
            this.AcceptButton = this.botaoCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 256);
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
            this.Controls.Add(this.qteM2);
            this.Name = "NomePrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qteM² by Leandro Ricardo";
            this.Load += new System.EventHandler(this.NomePrograma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qteM2;
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
    }
}

