namespace VisualFotoeVídeo
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.picEvento = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picAlterar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picPesquisa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picCadastro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.picEvento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picAlterar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picPesquisa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picCadastro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picLogin);
            this.panel1.Location = new System.Drawing.Point(-3, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 832);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 546);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Eventos";
            // 
            // picEvento
            // 
            this.picEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEvento.Image = global::VisualFotoeVídeo.Properties.Resources.evento;
            this.picEvento.Location = new System.Drawing.Point(124, 458);
            this.picEvento.Margin = new System.Windows.Forms.Padding(2);
            this.picEvento.Name = "picEvento";
            this.picEvento.Size = new System.Drawing.Size(79, 83);
            this.picEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEvento.TabIndex = 10;
            this.picEvento.TabStop = false;
            this.picEvento.Click += new System.EventHandler(this.picEvento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 682);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alterar/Excluir";
            // 
            // picAlterar
            // 
            this.picAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAlterar.Image = global::VisualFotoeVídeo.Properties.Resources.alterar;
            this.picAlterar.Location = new System.Drawing.Point(124, 587);
            this.picAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.picAlterar.Name = "picAlterar";
            this.picAlterar.Size = new System.Drawing.Size(77, 80);
            this.picAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlterar.TabIndex = 8;
            this.picAlterar.TabStop = false;
            this.picAlterar.Click += new System.EventHandler(this.picAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pesquisa";
            // 
            // picPesquisa
            // 
            this.picPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPesquisa.Image = global::VisualFotoeVídeo.Properties.Resources.pesquisa;
            this.picPesquisa.Location = new System.Drawing.Point(124, 323);
            this.picPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.picPesquisa.Name = "picPesquisa";
            this.picPesquisa.Size = new System.Drawing.Size(79, 83);
            this.picPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPesquisa.TabIndex = 6;
            this.picPesquisa.TabStop = false;
            this.picPesquisa.Click += new System.EventHandler(this.picPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadastro";
            // 
            // picCadastro
            // 
            this.picCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCadastro.Image = global::VisualFotoeVídeo.Properties.Resources.cadastro;
            this.picCadastro.Location = new System.Drawing.Point(124, 184);
            this.picCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.picCadastro.Name = "picCadastro";
            this.picCadastro.Size = new System.Drawing.Size(79, 83);
            this.picCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadastro.TabIndex = 4;
            this.picCadastro.TabStop = false;
            this.picCadastro.Click += new System.EventHandler(this.picCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // picLogin
            // 
            this.picLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogin.Image = global::VisualFotoeVídeo.Properties.Resources.login_entrar;
            this.picLogin.Location = new System.Drawing.Point(124, 62);
            this.picLogin.Margin = new System.Windows.Forms.Padding(2);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(79, 83);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 2;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualFotoeVídeo.Properties.Resources.okMenor;
            this.pictureBox1.Location = new System.Drawing.Point(748, 230);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 796);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Visual Foto e Vídeo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPesquisa;
        private System.Windows.Forms.PictureBox picAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picEvento;
    }
}

