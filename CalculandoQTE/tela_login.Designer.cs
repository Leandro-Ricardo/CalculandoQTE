
namespace CalculandoQTE
{
    partial class tela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_login));
            this.imgSenha = new System.Windows.Forms.PictureBox();
            this.boxSenha = new System.Windows.Forms.TextBox();
            this.botaoConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSenha
            // 
            this.imgSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgSenha.BackColor = System.Drawing.Color.Transparent;
            this.imgSenha.Image = ((System.Drawing.Image)(resources.GetObject("imgSenha.Image")));
            this.imgSenha.Location = new System.Drawing.Point(136, 40);
            this.imgSenha.Name = "imgSenha";
            this.imgSenha.Size = new System.Drawing.Size(37, 35);
            this.imgSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSenha.TabIndex = 1;
            this.imgSenha.TabStop = false;
            // 
            // boxSenha
            // 
            this.boxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSenha.Location = new System.Drawing.Point(102, 103);
            this.boxSenha.Name = "boxSenha";
            this.boxSenha.PasswordChar = '*';
            this.boxSenha.Size = new System.Drawing.Size(100, 26);
            this.boxSenha.TabIndex = 2;
            this.boxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxSenha.TextChanged += new System.EventHandler(this.boxSenha_TextChanged);
            // 
            // botaoConectar
            // 
            this.botaoConectar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoConectar.Location = new System.Drawing.Point(102, 135);
            this.botaoConectar.Name = "botaoConectar";
            this.botaoConectar.Size = new System.Drawing.Size(100, 29);
            this.botaoConectar.TabIndex = 3;
            this.botaoConectar.Text = "Conectar";
            this.botaoConectar.UseVisualStyleBackColor = true;
            this.botaoConectar.Click += new System.EventHandler(this.botaoConectar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // tela_login
            // 
            this.AcceptButton = this.botaoConectar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoConectar);
            this.Controls.Add(this.boxSenha);
            this.Controls.Add(this.imgSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qtdM² - Login";
            this.Load += new System.EventHandler(this.tela_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSenha;
        private System.Windows.Forms.TextBox boxSenha;
        private System.Windows.Forms.Button botaoConectar;
        private System.Windows.Forms.Label label1;
    }
}