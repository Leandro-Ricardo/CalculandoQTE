
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramaPrincipal));
            this.TextoLargura = new System.Windows.Forms.Label();
            this.TextoAltura = new System.Windows.Forms.Label();
            this.TextoX = new System.Windows.Forms.Label();
            this.BoxLargura = new System.Windows.Forms.TextBox();
            this.BoxAltura = new System.Windows.Forms.TextBox();
            this.TextoM2produto = new System.Windows.Forms.Label();
            this.TextoResultadoM2Produto = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.TextoResultadoAdesivos = new System.Windows.Forms.Label();
            this.TextoQuantidadeAdesivosM2 = new System.Windows.Forms.Label();
            this.TextoResultadoQtdM2 = new System.Windows.Forms.Label();
            this.TextoSemCorte = new System.Windows.Forms.Label();
            this.TextoComCorte = new System.Windows.Forms.Label();
            this.TextoResultadoSemCorte = new System.Windows.Forms.Label();
            this.TextoResultadoComCorte = new System.Windows.Forms.Label();
            this.TextoQuantidadeAdesivos = new System.Windows.Forms.Label();
            this.BoxQuantidadeAdesivos = new System.Windows.Forms.TextBox();
            this.TextoResultadoLona = new System.Windows.Forms.Label();
            this.TextoTubeteCorda = new System.Windows.Forms.Label();
            this.TextoIlhos = new System.Windows.Forms.Label();
            this.TextoResultadoTubeteCorda = new System.Windows.Forms.Label();
            this.TextoResultadoIlhos = new System.Windows.Forms.Label();
            this.TextoAdesivoRetroverso = new System.Windows.Forms.Label();
            this.TextoRresultadoRetroverso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextoLargura
            // 
            this.TextoLargura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoLargura.AutoSize = true;
            this.TextoLargura.BackColor = System.Drawing.Color.Transparent;
            this.TextoLargura.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoLargura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoLargura.Location = new System.Drawing.Point(30, 75);
            this.TextoLargura.Name = "TextoLargura";
            this.TextoLargura.Size = new System.Drawing.Size(96, 26);
            this.TextoLargura.TabIndex = 1;
            this.TextoLargura.Text = "Largura:";
            this.TextoLargura.Click += new System.EventHandler(this.textLargura_Click);
            // 
            // TextoAltura
            // 
            this.TextoAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoAltura.AutoSize = true;
            this.TextoAltura.BackColor = System.Drawing.Color.Transparent;
            this.TextoAltura.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAltura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoAltura.Location = new System.Drawing.Point(30, 154);
            this.TextoAltura.Name = "TextoAltura";
            this.TextoAltura.Size = new System.Drawing.Size(80, 26);
            this.TextoAltura.TabIndex = 2;
            this.TextoAltura.Text = "Altura:";
            this.TextoAltura.Click += new System.EventHandler(this.textAltura_Click);
            // 
            // TextoX
            // 
            this.TextoX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoX.AutoSize = true;
            this.TextoX.BackColor = System.Drawing.Color.Transparent;
            this.TextoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoX.ForeColor = System.Drawing.Color.Red;
            this.TextoX.Location = new System.Drawing.Point(74, 137);
            this.TextoX.Name = "TextoX";
            this.TextoX.Size = new System.Drawing.Size(16, 20);
            this.TextoX.TabIndex = 3;
            this.TextoX.Text = "x";
            // 
            // BoxLargura
            // 
            this.BoxLargura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLargura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BoxLargura.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.BoxLargura.Location = new System.Drawing.Point(35, 104);
            this.BoxLargura.MaxLength = 10;
            this.BoxLargura.Name = "BoxLargura";
            this.BoxLargura.Size = new System.Drawing.Size(91, 35);
            this.BoxLargura.TabIndex = 1;
            this.BoxLargura.Text = "0,0";
            this.BoxLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxLargura.TextChanged += new System.EventHandler(this.boxL_TextChanged);
            // 
            // BoxAltura
            // 
            this.BoxAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAltura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BoxAltura.Location = new System.Drawing.Point(35, 184);
            this.BoxAltura.MaxLength = 10;
            this.BoxAltura.Name = "BoxAltura";
            this.BoxAltura.Size = new System.Drawing.Size(91, 35);
            this.BoxAltura.TabIndex = 2;
            this.BoxAltura.Text = "0,0";
            this.BoxAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxAltura.TextChanged += new System.EventHandler(this.boxA_TextChanged);
            // 
            // TextoM2produto
            // 
            this.TextoM2produto.AutoSize = true;
            this.TextoM2produto.BackColor = System.Drawing.Color.Transparent;
            this.TextoM2produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoM2produto.ForeColor = System.Drawing.Color.Red;
            this.TextoM2produto.Location = new System.Drawing.Point(251, 46);
            this.TextoM2produto.Name = "TextoM2produto";
            this.TextoM2produto.Size = new System.Drawing.Size(155, 31);
            this.TextoM2produto.TabIndex = 6;
            this.TextoM2produto.Text = "M² Produto:";
            this.TextoM2produto.Click += new System.EventHandler(this.textM2_Click);
            // 
            // TextoResultadoM2Produto
            // 
            this.TextoResultadoM2Produto.AutoSize = true;
            this.TextoResultadoM2Produto.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoM2Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoM2Produto.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoM2Produto.Location = new System.Drawing.Point(396, 46);
            this.TextoResultadoM2Produto.Name = "TextoResultadoM2Produto";
            this.TextoResultadoM2Produto.Size = new System.Drawing.Size(80, 31);
            this.TextoResultadoM2Produto.TabIndex = 7;
            this.TextoResultadoM2Produto.Text = "0 mm";
            this.TextoResultadoM2Produto.Click += new System.EventHandler(this.textResultado_Click);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.AccessibleDescription = "";
            this.botaoCalcular.AccessibleName = "";
            this.botaoCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCalcular.Location = new System.Drawing.Point(35, 361);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(91, 35);
            this.botaoCalcular.TabIndex = 4;
            this.botaoCalcular.Text = "calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // TextoResultadoAdesivos
            // 
            this.TextoResultadoAdesivos.AutoSize = true;
            this.TextoResultadoAdesivos.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoAdesivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoAdesivos.ForeColor = System.Drawing.Color.MediumBlue;
            this.TextoResultadoAdesivos.Location = new System.Drawing.Point(242, 96);
            this.TextoResultadoAdesivos.Name = "TextoResultadoAdesivos";
            this.TextoResultadoAdesivos.Size = new System.Drawing.Size(251, 29);
            this.TextoResultadoAdesivos.TabIndex = 9;
            this.TextoResultadoAdesivos.Text = "Resultado Adesivos:";
            this.TextoResultadoAdesivos.UseMnemonic = false;
            // 
            // TextoQuantidadeAdesivosM2
            // 
            this.TextoQuantidadeAdesivosM2.AutoSize = true;
            this.TextoQuantidadeAdesivosM2.BackColor = System.Drawing.Color.Transparent;
            this.TextoQuantidadeAdesivosM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoQuantidadeAdesivosM2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoQuantidadeAdesivosM2.Location = new System.Drawing.Point(257, 127);
            this.TextoQuantidadeAdesivosM2.Name = "TextoQuantidadeAdesivosM2";
            this.TextoQuantidadeAdesivosM2.Size = new System.Drawing.Size(219, 29);
            this.TextoQuantidadeAdesivosM2.TabIndex = 10;
            this.TextoQuantidadeAdesivosM2.Text = "Quantidade por M²:";
            // 
            // TextoResultadoQtdM2
            // 
            this.TextoResultadoQtdM2.AutoSize = true;
            this.TextoResultadoQtdM2.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoQtdM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoQtdM2.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoQtdM2.Location = new System.Drawing.Point(257, 156);
            this.TextoResultadoQtdM2.Name = "TextoResultadoQtdM2";
            this.TextoResultadoQtdM2.Size = new System.Drawing.Size(54, 25);
            this.TextoResultadoQtdM2.TabIndex = 11;
            this.TextoResultadoQtdM2.Text = "0 un";
            this.TextoResultadoQtdM2.Click += new System.EventHandler(this.resultadoQteM2_Click);
            // 
            // TextoSemCorte
            // 
            this.TextoSemCorte.AutoSize = true;
            this.TextoSemCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoSemCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoSemCorte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoSemCorte.Location = new System.Drawing.Point(257, 196);
            this.TextoSemCorte.Name = "TextoSemCorte";
            this.TextoSemCorte.Size = new System.Drawing.Size(135, 29);
            this.TextoSemCorte.TabIndex = 12;
            this.TextoSemCorte.Text = "Sem corte: ";
            // 
            // TextoComCorte
            // 
            this.TextoComCorte.AutoSize = true;
            this.TextoComCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoComCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoComCorte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoComCorte.Location = new System.Drawing.Point(257, 266);
            this.TextoComCorte.Name = "TextoComCorte";
            this.TextoComCorte.Size = new System.Drawing.Size(130, 29);
            this.TextoComCorte.TabIndex = 13;
            this.TextoComCorte.Text = "Com corte:";
            // 
            // TextoResultadoSemCorte
            // 
            this.TextoResultadoSemCorte.AutoSize = true;
            this.TextoResultadoSemCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoSemCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoSemCorte.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoSemCorte.Location = new System.Drawing.Point(257, 225);
            this.TextoResultadoSemCorte.Name = "TextoResultadoSemCorte";
            this.TextoResultadoSemCorte.Size = new System.Drawing.Size(87, 25);
            this.TextoResultadoSemCorte.TabIndex = 14;
            this.TextoResultadoSemCorte.Text = "R$ 0,00";
            this.TextoResultadoSemCorte.Click += new System.EventHandler(this.resultadoSemCorte_Click);
            // 
            // TextoResultadoComCorte
            // 
            this.TextoResultadoComCorte.AutoSize = true;
            this.TextoResultadoComCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoComCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoComCorte.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoComCorte.Location = new System.Drawing.Point(257, 295);
            this.TextoResultadoComCorte.Name = "TextoResultadoComCorte";
            this.TextoResultadoComCorte.Size = new System.Drawing.Size(87, 25);
            this.TextoResultadoComCorte.TabIndex = 15;
            this.TextoResultadoComCorte.Text = "R$ 0,00";
            // 
            // TextoQuantidadeAdesivos
            // 
            this.TextoQuantidadeAdesivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoQuantidadeAdesivos.AutoSize = true;
            this.TextoQuantidadeAdesivos.BackColor = System.Drawing.Color.Transparent;
            this.TextoQuantidadeAdesivos.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoQuantidadeAdesivos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoQuantidadeAdesivos.Location = new System.Drawing.Point(10, 248);
            this.TextoQuantidadeAdesivos.Name = "TextoQuantidadeAdesivos";
            this.TextoQuantidadeAdesivos.Size = new System.Drawing.Size(142, 26);
            this.TextoQuantidadeAdesivos.TabIndex = 16;
            this.TextoQuantidadeAdesivos.Text = "Qte Adesivos";
            // 
            // BoxQuantidadeAdesivos
            // 
            this.BoxQuantidadeAdesivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxQuantidadeAdesivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQuantidadeAdesivos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BoxQuantidadeAdesivos.Location = new System.Drawing.Point(35, 277);
            this.BoxQuantidadeAdesivos.Name = "BoxQuantidadeAdesivos";
            this.BoxQuantidadeAdesivos.Size = new System.Drawing.Size(91, 35);
            this.BoxQuantidadeAdesivos.TabIndex = 3;
            this.BoxQuantidadeAdesivos.Text = "0";
            this.BoxQuantidadeAdesivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxQuantidadeAdesivos.TextChanged += new System.EventHandler(this.quantidadeAdesivos_TextChanged);
            // 
            // TextoResultadoLona
            // 
            this.TextoResultadoLona.AutoSize = true;
            this.TextoResultadoLona.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoLona.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.TextoResultadoLona.ForeColor = System.Drawing.Color.MediumBlue;
            this.TextoResultadoLona.Location = new System.Drawing.Point(554, 98);
            this.TextoResultadoLona.Name = "TextoResultadoLona";
            this.TextoResultadoLona.Size = new System.Drawing.Size(202, 29);
            this.TextoResultadoLona.TabIndex = 18;
            this.TextoResultadoLona.Text = "Resultado Lona:";
            // 
            // TextoTubeteCorda
            // 
            this.TextoTubeteCorda.AutoSize = true;
            this.TextoTubeteCorda.BackColor = System.Drawing.Color.Transparent;
            this.TextoTubeteCorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TextoTubeteCorda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoTubeteCorda.Location = new System.Drawing.Point(554, 131);
            this.TextoTubeteCorda.Name = "TextoTubeteCorda";
            this.TextoTubeteCorda.Size = new System.Drawing.Size(188, 29);
            this.TextoTubeteCorda.TabIndex = 19;
            this.TextoTubeteCorda.Text = "Tubete e Corda:";
            // 
            // TextoIlhos
            // 
            this.TextoIlhos.AutoSize = true;
            this.TextoIlhos.BackColor = System.Drawing.Color.Transparent;
            this.TextoIlhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TextoIlhos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoIlhos.Location = new System.Drawing.Point(554, 198);
            this.TextoIlhos.Name = "TextoIlhos";
            this.TextoIlhos.Size = new System.Drawing.Size(127, 29);
            this.TextoIlhos.TabIndex = 20;
            this.TextoIlhos.Text = "Com Ilhós:";
            this.TextoIlhos.Click += new System.EventHandler(this.ilhos_Click);
            // 
            // TextoResultadoTubeteCorda
            // 
            this.TextoResultadoTubeteCorda.AutoSize = true;
            this.TextoResultadoTubeteCorda.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoTubeteCorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoTubeteCorda.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoTubeteCorda.Location = new System.Drawing.Point(554, 156);
            this.TextoResultadoTubeteCorda.Name = "TextoResultadoTubeteCorda";
            this.TextoResultadoTubeteCorda.Size = new System.Drawing.Size(87, 25);
            this.TextoResultadoTubeteCorda.TabIndex = 21;
            this.TextoResultadoTubeteCorda.Text = "R$ 0,00";
            this.TextoResultadoTubeteCorda.Click += new System.EventHandler(this.resultadoTubeteCorda_Click);
            // 
            // TextoResultadoIlhos
            // 
            this.TextoResultadoIlhos.AutoSize = true;
            this.TextoResultadoIlhos.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoIlhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoIlhos.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoIlhos.Location = new System.Drawing.Point(554, 227);
            this.TextoResultadoIlhos.Name = "TextoResultadoIlhos";
            this.TextoResultadoIlhos.Size = new System.Drawing.Size(87, 25);
            this.TextoResultadoIlhos.TabIndex = 22;
            this.TextoResultadoIlhos.Text = "R$ 0,00";
            this.TextoResultadoIlhos.Click += new System.EventHandler(this.resultadoIlhos_Click);
            // 
            // TextoAdesivoRetroverso
            // 
            this.TextoAdesivoRetroverso.AutoSize = true;
            this.TextoAdesivoRetroverso.BackColor = System.Drawing.Color.Transparent;
            this.TextoAdesivoRetroverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAdesivoRetroverso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoAdesivoRetroverso.Location = new System.Drawing.Point(257, 350);
            this.TextoAdesivoRetroverso.Name = "TextoAdesivoRetroverso";
            this.TextoAdesivoRetroverso.Size = new System.Drawing.Size(229, 29);
            this.TextoAdesivoRetroverso.TabIndex = 23;
            this.TextoAdesivoRetroverso.Text = "Adesivo Retroverso:";
            this.TextoAdesivoRetroverso.Click += new System.EventHandler(this.adesivoRetroverso_Click);
            // 
            // TextoRresultadoRetroverso
            // 
            this.TextoRresultadoRetroverso.AutoSize = true;
            this.TextoRresultadoRetroverso.BackColor = System.Drawing.Color.Transparent;
            this.TextoRresultadoRetroverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoRresultadoRetroverso.ForeColor = System.Drawing.Color.Red;
            this.TextoRresultadoRetroverso.Location = new System.Drawing.Point(257, 379);
            this.TextoRresultadoRetroverso.Name = "TextoRresultadoRetroverso";
            this.TextoRresultadoRetroverso.Size = new System.Drawing.Size(87, 25);
            this.TextoRresultadoRetroverso.TabIndex = 24;
            this.TextoRresultadoRetroverso.Text = "R$ 0,00";
            this.TextoRresultadoRetroverso.Click += new System.EventHandler(this.resultadoRetroverso_Click);
            // 
            // ProgramaPrincipal
            // 
            this.AcceptButton = this.botaoCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 429);
            this.Controls.Add(this.TextoRresultadoRetroverso);
            this.Controls.Add(this.TextoAdesivoRetroverso);
            this.Controls.Add(this.TextoResultadoIlhos);
            this.Controls.Add(this.TextoResultadoTubeteCorda);
            this.Controls.Add(this.TextoIlhos);
            this.Controls.Add(this.TextoTubeteCorda);
            this.Controls.Add(this.TextoResultadoLona);
            this.Controls.Add(this.BoxQuantidadeAdesivos);
            this.Controls.Add(this.TextoQuantidadeAdesivos);
            this.Controls.Add(this.TextoResultadoComCorte);
            this.Controls.Add(this.TextoResultadoSemCorte);
            this.Controls.Add(this.TextoComCorte);
            this.Controls.Add(this.TextoSemCorte);
            this.Controls.Add(this.TextoResultadoQtdM2);
            this.Controls.Add(this.TextoQuantidadeAdesivosM2);
            this.Controls.Add(this.TextoResultadoAdesivos);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.TextoResultadoM2Produto);
            this.Controls.Add(this.TextoM2produto);
            this.Controls.Add(this.BoxAltura);
            this.Controls.Add(this.BoxLargura);
            this.Controls.Add(this.TextoX);
            this.Controls.Add(this.TextoAltura);
            this.Controls.Add(this.TextoLargura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qtdM² - v1.0";
            this.Load += new System.EventHandler(this.NomePrograma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextoLargura;
        private System.Windows.Forms.Label TextoAltura;
        private System.Windows.Forms.Label TextoX;
        private System.Windows.Forms.TextBox BoxLargura;
        private System.Windows.Forms.TextBox BoxAltura;
        private System.Windows.Forms.Label TextoM2produto;
        private System.Windows.Forms.Label TextoResultadoM2Produto;
        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.Label TextoResultadoAdesivos;
        private System.Windows.Forms.Label TextoQuantidadeAdesivosM2;
        private System.Windows.Forms.Label TextoResultadoQtdM2;
        private System.Windows.Forms.Label TextoSemCorte;
        private System.Windows.Forms.Label TextoComCorte;
        private System.Windows.Forms.Label TextoResultadoSemCorte;
        private System.Windows.Forms.Label TextoResultadoComCorte;
        private System.Windows.Forms.Label TextoQuantidadeAdesivos;
        private System.Windows.Forms.TextBox BoxQuantidadeAdesivos;
        private System.Windows.Forms.Label TextoResultadoLona;
        private System.Windows.Forms.Label TextoTubeteCorda;
        private System.Windows.Forms.Label TextoIlhos;
        private System.Windows.Forms.Label TextoResultadoTubeteCorda;
        private System.Windows.Forms.Label TextoResultadoIlhos;
        private System.Windows.Forms.Label TextoAdesivoRetroverso;
        private System.Windows.Forms.Label TextoRresultadoRetroverso;
    }
}

