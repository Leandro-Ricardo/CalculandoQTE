
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
            this.qteM2 = new System.Windows.Forms.Label();
            this.textLargura = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.Label();
            this.boxL = new System.Windows.Forms.TextBox();
            this.boxA = new System.Windows.Forms.TextBox();
            this.textM2 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qteM2
            // 
            this.qteM2.AutoSize = true;
            this.qteM2.Location = new System.Drawing.Point(301, 9);
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
            this.textLargura.Location = new System.Drawing.Point(12, 30);
            this.textLargura.Name = "textLargura";
            this.textLargura.Size = new System.Drawing.Size(54, 16);
            this.textLargura.TabIndex = 1;
            this.textLargura.Text = "Largura";
            // 
            // textAltura
            // 
            this.textAltura.AutoSize = true;
            this.textAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.Location = new System.Drawing.Point(18, 83);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(42, 16);
            this.textAltura.TabIndex = 2;
            this.textAltura.Text = "Altura";
            // 
            // textX
            // 
            this.textX.AutoSize = true;
            this.textX.ForeColor = System.Drawing.Color.Red;
            this.textX.Location = new System.Drawing.Point(33, 67);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(12, 13);
            this.textX.TabIndex = 3;
            this.textX.Text = "x";
            // 
            // boxL
            // 
            this.boxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxL.Location = new System.Drawing.Point(12, 47);
            this.boxL.MaxLength = 10;
            this.boxL.Name = "boxL";
            this.boxL.Size = new System.Drawing.Size(53, 22);
            this.boxL.TabIndex = 4;
            this.boxL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxL.TextChanged += new System.EventHandler(this.boxL_TextChanged);
            // 
            // boxA
            // 
            this.boxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxA.Location = new System.Drawing.Point(12, 99);
            this.boxA.MaxLength = 10;
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(54, 22);
            this.boxA.TabIndex = 5;
            this.boxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxA.TextChanged += new System.EventHandler(this.boxA_TextChanged);
            // 
            // textM2
            // 
            this.textM2.AutoSize = true;
            this.textM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textM2.ForeColor = System.Drawing.Color.Red;
            this.textM2.Location = new System.Drawing.Point(87, 105);
            this.textM2.Name = "textM2";
            this.textM2.Size = new System.Drawing.Size(36, 16);
            this.textM2.TabIndex = 6;
            this.textM2.Text = "M² = ";
            // 
            // textResultado
            // 
            this.textResultado.AutoSize = true;
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.ForeColor = System.Drawing.Color.Red;
            this.textResultado.Location = new System.Drawing.Point(118, 105);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(15, 16);
            this.textResultado.TabIndex = 7;
            this.textResultado.Text = "0";
            this.textResultado.Click += new System.EventHandler(this.textResultado_Click);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.Location = new System.Drawing.Point(75, 72);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(75, 23);
            this.botaoCalcular.TabIndex = 8;
            this.botaoCalcular.Text = "calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // NomePrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 380);
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
            this.Text = "qteM² by Leandro Ricardo";
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
    }
}

