
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
            this.TextoResultadoAdesivos = new System.Windows.Forms.Label();
            this.TextoQuantidadeAdesivosM2 = new System.Windows.Forms.Label();
            this.TextoResultadoQtdM2 = new System.Windows.Forms.Label();
            this.TextoSemCorte = new System.Windows.Forms.Label();
            this.TextoComCorte = new System.Windows.Forms.Label();
            this.TextoResultadoSemCorte = new System.Windows.Forms.Label();
            this.TextoResultadoComCorte = new System.Windows.Forms.Label();
            this.TextoResultadoLona = new System.Windows.Forms.Label();
            this.TextoTubeteCorda = new System.Windows.Forms.Label();
            this.TextoIlhos = new System.Windows.Forms.Label();
            this.TextoResultadoTubeteCorda = new System.Windows.Forms.Label();
            this.TextoResultadoIlhos = new System.Windows.Forms.Label();
            this.TextoAdesivoRetroverso = new System.Windows.Forms.Label();
            this.TextoRresultadoRetroverso = new System.Windows.Forms.Label();
            this.TextoResultadoQtdMin = new System.Windows.Forms.Label();
            this.TextoQuantidadeMaxMinM2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdesivos = new System.Windows.Forms.TabPage();
            this.tabLona = new System.Windows.Forms.TabPage();
            this.TextoLargura = new System.Windows.Forms.Label();
            this.TextoAltura = new System.Windows.Forms.Label();
            this.TextoX = new System.Windows.Forms.Label();
            this.BoxLargura = new System.Windows.Forms.TextBox();
            this.BoxAltura = new System.Windows.Forms.TextBox();
            this.TextoM2produto = new System.Windows.Forms.Label();
            this.TextoResultadoM2Produto = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.mm1 = new System.Windows.Forms.Label();
            this.mm2 = new System.Windows.Forms.Label();
            this.BoxQuantidadeAdesivos = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.Label();
            this.TextoQuantidadeAdesivos = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAdesivos.SuspendLayout();
            this.tabLona.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoResultadoAdesivos
            // 
            this.TextoResultadoAdesivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoAdesivos.AutoEllipsis = true;
            this.TextoResultadoAdesivos.AutoSize = true;
            this.TextoResultadoAdesivos.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoAdesivos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoAdesivos.ForeColor = System.Drawing.Color.MediumBlue;
            this.TextoResultadoAdesivos.Location = new System.Drawing.Point(179, 20);
            this.TextoResultadoAdesivos.Name = "TextoResultadoAdesivos";
            this.TextoResultadoAdesivos.Size = new System.Drawing.Size(216, 26);
            this.TextoResultadoAdesivos.TabIndex = 9;
            this.TextoResultadoAdesivos.Text = "Resultado Adesivos:";
            this.TextoResultadoAdesivos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextoResultadoAdesivos.UseMnemonic = false;
            // 
            // TextoQuantidadeAdesivosM2
            // 
            this.TextoQuantidadeAdesivosM2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoQuantidadeAdesivosM2.AutoEllipsis = true;
            this.TextoQuantidadeAdesivosM2.AutoSize = true;
            this.TextoQuantidadeAdesivosM2.BackColor = System.Drawing.Color.Transparent;
            this.TextoQuantidadeAdesivosM2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoQuantidadeAdesivosM2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoQuantidadeAdesivosM2.Location = new System.Drawing.Point(4, 66);
            this.TextoQuantidadeAdesivosM2.Name = "TextoQuantidadeAdesivosM2";
            this.TextoQuantidadeAdesivosM2.Size = new System.Drawing.Size(126, 27);
            this.TextoQuantidadeAdesivosM2.TabIndex = 10;
            this.TextoQuantidadeAdesivosM2.Text = "Qtd por M²:";
            // 
            // TextoResultadoQtdM2
            // 
            this.TextoResultadoQtdM2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoQtdM2.AutoEllipsis = true;
            this.TextoResultadoQtdM2.AutoSize = true;
            this.TextoResultadoQtdM2.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoQtdM2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoQtdM2.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoQtdM2.Location = new System.Drawing.Point(128, 69);
            this.TextoResultadoQtdM2.Name = "TextoResultadoQtdM2";
            this.TextoResultadoQtdM2.Size = new System.Drawing.Size(47, 23);
            this.TextoResultadoQtdM2.TabIndex = 11;
            this.TextoResultadoQtdM2.Text = "0 un";
            this.TextoResultadoQtdM2.Click += new System.EventHandler(this.resultadoQteM2_Click);
            // 
            // TextoSemCorte
            // 
            this.TextoSemCorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoSemCorte.AutoEllipsis = true;
            this.TextoSemCorte.AutoSize = true;
            this.TextoSemCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoSemCorte.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoSemCorte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoSemCorte.Location = new System.Drawing.Point(7, 192);
            this.TextoSemCorte.Name = "TextoSemCorte";
            this.TextoSemCorte.Size = new System.Drawing.Size(205, 27);
            this.TextoSemCorte.TabIndex = 12;
            this.TextoSemCorte.Text = "Adesivo Sem corte: ";
            this.TextoSemCorte.Click += new System.EventHandler(this.TextoSemCorte_Click);
            // 
            // TextoComCorte
            // 
            this.TextoComCorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoComCorte.AutoEllipsis = true;
            this.TextoComCorte.AutoSize = true;
            this.TextoComCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoComCorte.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoComCorte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoComCorte.Location = new System.Drawing.Point(7, 260);
            this.TextoComCorte.Name = "TextoComCorte";
            this.TextoComCorte.Size = new System.Drawing.Size(204, 27);
            this.TextoComCorte.TabIndex = 13;
            this.TextoComCorte.Text = "Adesivo Com corte:";
            // 
            // TextoResultadoSemCorte
            // 
            this.TextoResultadoSemCorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoSemCorte.AutoEllipsis = true;
            this.TextoResultadoSemCorte.AutoSize = true;
            this.TextoResultadoSemCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoSemCorte.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoSemCorte.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoSemCorte.Location = new System.Drawing.Point(8, 219);
            this.TextoResultadoSemCorte.Name = "TextoResultadoSemCorte";
            this.TextoResultadoSemCorte.Size = new System.Drawing.Size(78, 23);
            this.TextoResultadoSemCorte.TabIndex = 14;
            this.TextoResultadoSemCorte.Text = "R$ 0,00";
            this.TextoResultadoSemCorte.Click += new System.EventHandler(this.resultadoSemCorte_Click);
            // 
            // TextoResultadoComCorte
            // 
            this.TextoResultadoComCorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoComCorte.AutoEllipsis = true;
            this.TextoResultadoComCorte.AutoSize = true;
            this.TextoResultadoComCorte.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoComCorte.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoComCorte.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoComCorte.Location = new System.Drawing.Point(8, 287);
            this.TextoResultadoComCorte.Name = "TextoResultadoComCorte";
            this.TextoResultadoComCorte.Size = new System.Drawing.Size(78, 23);
            this.TextoResultadoComCorte.TabIndex = 15;
            this.TextoResultadoComCorte.Text = "R$ 0,00";
            // 
            // TextoResultadoLona
            // 
            this.TextoResultadoLona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoLona.AutoEllipsis = true;
            this.TextoResultadoLona.AutoSize = true;
            this.TextoResultadoLona.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoLona.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoLona.ForeColor = System.Drawing.Color.MediumBlue;
            this.TextoResultadoLona.Location = new System.Drawing.Point(214, 21);
            this.TextoResultadoLona.Name = "TextoResultadoLona";
            this.TextoResultadoLona.Size = new System.Drawing.Size(181, 26);
            this.TextoResultadoLona.TabIndex = 18;
            this.TextoResultadoLona.Text = "Resultado Lona:";
            // 
            // TextoTubeteCorda
            // 
            this.TextoTubeteCorda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoTubeteCorda.AutoEllipsis = true;
            this.TextoTubeteCorda.AutoSize = true;
            this.TextoTubeteCorda.BackColor = System.Drawing.Color.Transparent;
            this.TextoTubeteCorda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTubeteCorda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoTubeteCorda.Location = new System.Drawing.Point(6, 64);
            this.TextoTubeteCorda.Name = "TextoTubeteCorda";
            this.TextoTubeteCorda.Size = new System.Drawing.Size(166, 27);
            this.TextoTubeteCorda.TabIndex = 19;
            this.TextoTubeteCorda.Text = "Tubete e Corda:";
            // 
            // TextoIlhos
            // 
            this.TextoIlhos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoIlhos.AutoEllipsis = true;
            this.TextoIlhos.AutoSize = true;
            this.TextoIlhos.BackColor = System.Drawing.Color.Transparent;
            this.TextoIlhos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoIlhos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoIlhos.Location = new System.Drawing.Point(6, 128);
            this.TextoIlhos.Name = "TextoIlhos";
            this.TextoIlhos.Size = new System.Drawing.Size(117, 27);
            this.TextoIlhos.TabIndex = 20;
            this.TextoIlhos.Text = "Com Ilhós:";
            this.TextoIlhos.Click += new System.EventHandler(this.ilhos_Click);
            // 
            // TextoResultadoTubeteCorda
            // 
            this.TextoResultadoTubeteCorda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoTubeteCorda.AutoEllipsis = true;
            this.TextoResultadoTubeteCorda.AutoSize = true;
            this.TextoResultadoTubeteCorda.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoTubeteCorda.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoTubeteCorda.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoTubeteCorda.Location = new System.Drawing.Point(7, 88);
            this.TextoResultadoTubeteCorda.Name = "TextoResultadoTubeteCorda";
            this.TextoResultadoTubeteCorda.Size = new System.Drawing.Size(78, 23);
            this.TextoResultadoTubeteCorda.TabIndex = 21;
            this.TextoResultadoTubeteCorda.Text = "R$ 0,00";
            this.TextoResultadoTubeteCorda.Click += new System.EventHandler(this.resultadoTubeteCorda_Click);
            // 
            // TextoResultadoIlhos
            // 
            this.TextoResultadoIlhos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoIlhos.AutoEllipsis = true;
            this.TextoResultadoIlhos.AutoSize = true;
            this.TextoResultadoIlhos.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoIlhos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoIlhos.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoIlhos.Location = new System.Drawing.Point(7, 152);
            this.TextoResultadoIlhos.Name = "TextoResultadoIlhos";
            this.TextoResultadoIlhos.Size = new System.Drawing.Size(78, 23);
            this.TextoResultadoIlhos.TabIndex = 22;
            this.TextoResultadoIlhos.Text = "R$ 0,00";
            this.TextoResultadoIlhos.Click += new System.EventHandler(this.resultadoIlhos_Click);
            // 
            // TextoAdesivoRetroverso
            // 
            this.TextoAdesivoRetroverso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoAdesivoRetroverso.AutoEllipsis = true;
            this.TextoAdesivoRetroverso.AutoSize = true;
            this.TextoAdesivoRetroverso.BackColor = System.Drawing.Color.Transparent;
            this.TextoAdesivoRetroverso.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAdesivoRetroverso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoAdesivoRetroverso.Location = new System.Drawing.Point(7, 347);
            this.TextoAdesivoRetroverso.Name = "TextoAdesivoRetroverso";
            this.TextoAdesivoRetroverso.Size = new System.Drawing.Size(209, 27);
            this.TextoAdesivoRetroverso.TabIndex = 23;
            this.TextoAdesivoRetroverso.Text = "Adesivo Retroverso:";
            this.TextoAdesivoRetroverso.Click += new System.EventHandler(this.adesivoRetroverso_Click);
            // 
            // TextoRresultadoRetroverso
            // 
            this.TextoRresultadoRetroverso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoRresultadoRetroverso.AutoEllipsis = true;
            this.TextoRresultadoRetroverso.AutoSize = true;
            this.TextoRresultadoRetroverso.BackColor = System.Drawing.Color.Transparent;
            this.TextoRresultadoRetroverso.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoRresultadoRetroverso.ForeColor = System.Drawing.Color.Red;
            this.TextoRresultadoRetroverso.Location = new System.Drawing.Point(8, 376);
            this.TextoRresultadoRetroverso.Name = "TextoRresultadoRetroverso";
            this.TextoRresultadoRetroverso.Size = new System.Drawing.Size(78, 23);
            this.TextoRresultadoRetroverso.TabIndex = 24;
            this.TextoRresultadoRetroverso.Text = "R$ 0,00";
            this.TextoRresultadoRetroverso.Click += new System.EventHandler(this.resultadoRetroverso_Click);
            // 
            // TextoResultadoQtdMin
            // 
            this.TextoResultadoQtdMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoQtdMin.AutoEllipsis = true;
            this.TextoResultadoQtdMin.AutoSize = true;
            this.TextoResultadoQtdMin.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoQtdMin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoQtdMin.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoQtdMin.Location = new System.Drawing.Point(262, 121);
            this.TextoResultadoQtdMin.Name = "TextoResultadoQtdMin";
            this.TextoResultadoQtdMin.Size = new System.Drawing.Size(47, 23);
            this.TextoResultadoQtdMin.TabIndex = 29;
            this.TextoResultadoQtdMin.Text = "0 un";
            this.TextoResultadoQtdMin.Click += new System.EventHandler(this.TextoResultadoQtdMin_Click);
            // 
            // TextoQuantidadeMaxMinM2
            // 
            this.TextoQuantidadeMaxMinM2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoQuantidadeMaxMinM2.AutoEllipsis = true;
            this.TextoQuantidadeMaxMinM2.AutoSize = true;
            this.TextoQuantidadeMaxMinM2.BackColor = System.Drawing.Color.Transparent;
            this.TextoQuantidadeMaxMinM2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoQuantidadeMaxMinM2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoQuantidadeMaxMinM2.Location = new System.Drawing.Point(4, 118);
            this.TextoQuantidadeMaxMinM2.Name = "TextoQuantidadeMaxMinM2";
            this.TextoQuantidadeMaxMinM2.Size = new System.Drawing.Size(263, 27);
            this.TextoQuantidadeMaxMinM2.TabIndex = 28;
            this.TextoQuantidadeMaxMinM2.Text = "Qtd máxima no valor mín:";
            this.TextoQuantidadeMaxMinM2.Click += new System.EventHandler(this.TextoQuantidadeMaxMinM2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdesivos);
            this.tabControl1.Controls.Add(this.tabLona);
            this.tabControl1.Location = new System.Drawing.Point(223, 62);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 519);
            this.tabControl1.TabIndex = 5;
            // 
            // tabAdesivos
            // 
            this.tabAdesivos.BackColor = System.Drawing.Color.Black;
            this.tabAdesivos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAdesivos.BackgroundImage")));
            this.tabAdesivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAdesivos.Controls.Add(this.BoxQuantidadeAdesivos);
            this.tabAdesivos.Controls.Add(this.un);
            this.tabAdesivos.Controls.Add(this.TextoQuantidadeAdesivos);
            this.tabAdesivos.Controls.Add(this.TextoResultadoAdesivos);
            this.tabAdesivos.Controls.Add(this.TextoResultadoQtdMin);
            this.tabAdesivos.Controls.Add(this.TextoQuantidadeAdesivosM2);
            this.tabAdesivos.Controls.Add(this.TextoQuantidadeMaxMinM2);
            this.tabAdesivos.Controls.Add(this.TextoResultadoQtdM2);
            this.tabAdesivos.Controls.Add(this.TextoSemCorte);
            this.tabAdesivos.Controls.Add(this.TextoComCorte);
            this.tabAdesivos.Controls.Add(this.TextoResultadoSemCorte);
            this.tabAdesivos.Controls.Add(this.TextoRresultadoRetroverso);
            this.tabAdesivos.Controls.Add(this.TextoResultadoComCorte);
            this.tabAdesivos.Controls.Add(this.TextoAdesivoRetroverso);
            this.tabAdesivos.Location = new System.Drawing.Point(4, 22);
            this.tabAdesivos.Margin = new System.Windows.Forms.Padding(0);
            this.tabAdesivos.Name = "tabAdesivos";
            this.tabAdesivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdesivos.Size = new System.Drawing.Size(597, 493);
            this.tabAdesivos.TabIndex = 0;
            this.tabAdesivos.Text = "Adesivos";
            this.tabAdesivos.Click += new System.EventHandler(this.tabAdesivos_Click);
            // 
            // tabLona
            // 
            this.tabLona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLona.BackgroundImage")));
            this.tabLona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLona.Controls.Add(this.TextoResultadoTubeteCorda);
            this.tabLona.Controls.Add(this.TextoResultadoLona);
            this.tabLona.Controls.Add(this.TextoTubeteCorda);
            this.tabLona.Controls.Add(this.TextoIlhos);
            this.tabLona.Controls.Add(this.TextoResultadoIlhos);
            this.tabLona.Location = new System.Drawing.Point(4, 22);
            this.tabLona.Name = "tabLona";
            this.tabLona.Padding = new System.Windows.Forms.Padding(3);
            this.tabLona.Size = new System.Drawing.Size(597, 493);
            this.tabLona.TabIndex = 1;
            this.tabLona.Text = "Lonas";
            this.tabLona.UseVisualStyleBackColor = true;
            this.tabLona.Click += new System.EventHandler(this.tabLona_Click);
            // 
            // TextoLargura
            // 
            this.TextoLargura.AutoSize = true;
            this.TextoLargura.BackColor = System.Drawing.Color.Transparent;
            this.TextoLargura.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoLargura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoLargura.Location = new System.Drawing.Point(52, 93);
            this.TextoLargura.Name = "TextoLargura";
            this.TextoLargura.Size = new System.Drawing.Size(96, 26);
            this.TextoLargura.TabIndex = 1;
            this.TextoLargura.Text = "Largura:";
            this.TextoLargura.Click += new System.EventHandler(this.textLargura_Click);
            // 
            // TextoAltura
            // 
            this.TextoAltura.AutoSize = true;
            this.TextoAltura.BackColor = System.Drawing.Color.Transparent;
            this.TextoAltura.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAltura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoAltura.Location = new System.Drawing.Point(52, 172);
            this.TextoAltura.Name = "TextoAltura";
            this.TextoAltura.Size = new System.Drawing.Size(80, 26);
            this.TextoAltura.TabIndex = 2;
            this.TextoAltura.Text = "Altura:";
            this.TextoAltura.Click += new System.EventHandler(this.textAltura_Click);
            // 
            // TextoX
            // 
            this.TextoX.AutoSize = true;
            this.TextoX.BackColor = System.Drawing.Color.Transparent;
            this.TextoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoX.ForeColor = System.Drawing.Color.Red;
            this.TextoX.Location = new System.Drawing.Point(96, 155);
            this.TextoX.Name = "TextoX";
            this.TextoX.Size = new System.Drawing.Size(16, 20);
            this.TextoX.TabIndex = 3;
            this.TextoX.Text = "x";
            // 
            // BoxLargura
            // 
            this.BoxLargura.AcceptsReturn = true;
            this.BoxLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLargura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BoxLargura.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.BoxLargura.Location = new System.Drawing.Point(57, 122);
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
            this.BoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAltura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BoxAltura.Location = new System.Drawing.Point(57, 202);
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
            this.TextoM2produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoM2produto.AutoEllipsis = true;
            this.TextoM2produto.AutoSize = true;
            this.TextoM2produto.BackColor = System.Drawing.Color.Transparent;
            this.TextoM2produto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoM2produto.ForeColor = System.Drawing.Color.Red;
            this.TextoM2produto.Location = new System.Drawing.Point(381, 27);
            this.TextoM2produto.Name = "TextoM2produto";
            this.TextoM2produto.Size = new System.Drawing.Size(182, 31);
            this.TextoM2produto.TabIndex = 6;
            this.TextoM2produto.Text = "M² do Produto:";
            this.TextoM2produto.Click += new System.EventHandler(this.textM2_Click);
            // 
            // TextoResultadoM2Produto
            // 
            this.TextoResultadoM2Produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoResultadoM2Produto.AutoEllipsis = true;
            this.TextoResultadoM2Produto.AutoSize = true;
            this.TextoResultadoM2Produto.BackColor = System.Drawing.Color.Transparent;
            this.TextoResultadoM2Produto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoResultadoM2Produto.ForeColor = System.Drawing.Color.Red;
            this.TextoResultadoM2Produto.Location = new System.Drawing.Point(557, 27);
            this.TextoResultadoM2Produto.Name = "TextoResultadoM2Produto";
            this.TextoResultadoM2Produto.Size = new System.Drawing.Size(75, 31);
            this.TextoResultadoM2Produto.TabIndex = 7;
            this.TextoResultadoM2Produto.Text = "0 mm";
            this.TextoResultadoM2Produto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextoResultadoM2Produto.Click += new System.EventHandler(this.textResultado_Click);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.AccessibleDescription = "";
            this.botaoCalcular.AccessibleName = "";
            this.botaoCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCalcular.Location = new System.Drawing.Point(57, 268);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(91, 35);
            this.botaoCalcular.TabIndex = 4;
            this.botaoCalcular.Text = "Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // mm1
            // 
            this.mm1.AutoSize = true;
            this.mm1.BackColor = System.Drawing.Color.Transparent;
            this.mm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm1.ForeColor = System.Drawing.Color.Red;
            this.mm1.Location = new System.Drawing.Point(150, 140);
            this.mm1.Name = "mm1";
            this.mm1.Size = new System.Drawing.Size(30, 16);
            this.mm1.TabIndex = 25;
            this.mm1.Text = "mm";
            // 
            // mm2
            // 
            this.mm2.AutoSize = true;
            this.mm2.BackColor = System.Drawing.Color.Transparent;
            this.mm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm2.ForeColor = System.Drawing.Color.Red;
            this.mm2.Location = new System.Drawing.Point(150, 220);
            this.mm2.Name = "mm2";
            this.mm2.Size = new System.Drawing.Size(30, 16);
            this.mm2.TabIndex = 26;
            this.mm2.Text = "mm";
            // 
            // BoxQuantidadeAdesivos
            // 
            this.BoxQuantidadeAdesivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQuantidadeAdesivos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BoxQuantidadeAdesivos.Location = new System.Drawing.Point(463, 37);
            this.BoxQuantidadeAdesivos.Name = "BoxQuantidadeAdesivos";
            this.BoxQuantidadeAdesivos.Size = new System.Drawing.Size(91, 35);
            this.BoxQuantidadeAdesivos.TabIndex = 30;
            this.BoxQuantidadeAdesivos.Text = "0";
            this.BoxQuantidadeAdesivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxQuantidadeAdesivos.TextChanged += new System.EventHandler(this.BoxQuantidadeAdesivos_TextChanged);
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.BackColor = System.Drawing.Color.Transparent;
            this.un.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.ForeColor = System.Drawing.Color.Red;
            this.un.Location = new System.Drawing.Point(556, 55);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(22, 16);
            this.un.TabIndex = 32;
            this.un.Text = "un";
            // 
            // TextoQuantidadeAdesivos
            // 
            this.TextoQuantidadeAdesivos.AutoSize = true;
            this.TextoQuantidadeAdesivos.BackColor = System.Drawing.Color.Transparent;
            this.TextoQuantidadeAdesivos.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoQuantidadeAdesivos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextoQuantidadeAdesivos.Location = new System.Drawing.Point(438, 8);
            this.TextoQuantidadeAdesivos.Name = "TextoQuantidadeAdesivos";
            this.TextoQuantidadeAdesivos.Size = new System.Drawing.Size(143, 26);
            this.TextoQuantidadeAdesivos.TabIndex = 31;
            this.TextoQuantidadeAdesivos.Text = "Qtd Adesivos";
            // 
            // ProgramaPrincipal
            // 
            this.AcceptButton = this.botaoCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 644);
            this.Controls.Add(this.mm2);
            this.Controls.Add(this.mm1);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.TextoResultadoM2Produto);
            this.Controls.Add(this.TextoM2produto);
            this.Controls.Add(this.BoxAltura);
            this.Controls.Add(this.BoxLargura);
            this.Controls.Add(this.TextoX);
            this.Controls.Add(this.TextoAltura);
            this.Controls.Add(this.TextoLargura);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgramaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qtdM² - v1.0";
            this.Load += new System.EventHandler(this.NomePrograma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAdesivos.ResumeLayout(false);
            this.tabAdesivos.PerformLayout();
            this.tabLona.ResumeLayout(false);
            this.tabLona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextoResultadoAdesivos;
        private System.Windows.Forms.Label TextoQuantidadeAdesivosM2;
        private System.Windows.Forms.Label TextoResultadoQtdM2;
        private System.Windows.Forms.Label TextoSemCorte;
        private System.Windows.Forms.Label TextoComCorte;
        private System.Windows.Forms.Label TextoResultadoSemCorte;
        private System.Windows.Forms.Label TextoResultadoComCorte;
        private System.Windows.Forms.Label TextoResultadoLona;
        private System.Windows.Forms.Label TextoTubeteCorda;
        private System.Windows.Forms.Label TextoIlhos;
        private System.Windows.Forms.Label TextoResultadoTubeteCorda;
        private System.Windows.Forms.Label TextoResultadoIlhos;
        private System.Windows.Forms.Label TextoAdesivoRetroverso;
        private System.Windows.Forms.Label TextoRresultadoRetroverso;
        private System.Windows.Forms.Label TextoResultadoQtdMin;
        private System.Windows.Forms.Label TextoQuantidadeMaxMinM2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdesivos;
        private System.Windows.Forms.TabPage tabLona;
        private System.Windows.Forms.Label TextoLargura;
        private System.Windows.Forms.Label TextoAltura;
        private System.Windows.Forms.Label TextoX;
        private System.Windows.Forms.TextBox BoxLargura;
        private System.Windows.Forms.TextBox BoxAltura;
        private System.Windows.Forms.Label TextoM2produto;
        private System.Windows.Forms.Label TextoResultadoM2Produto;
        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.Label mm1;
        private System.Windows.Forms.Label mm2;
        private System.Windows.Forms.TextBox BoxQuantidadeAdesivos;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.Label TextoQuantidadeAdesivos;
    }
}

