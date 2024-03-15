namespace VisualFotoeVídeo
{
    partial class FormEntrarCadastrar
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
            this.rbtEntrar = new MetroFramework.Controls.MetroRadioButton();
            this.btn_entrar = new MetroFramework.Controls.MetroButton();
            this.rbtCriarLogin = new MetroFramework.Controls.MetroRadioButton();
            this.btn_cadastro = new MetroFramework.Controls.MetroButton();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtEntrar
            // 
            this.rbtEntrar.AutoSize = true;
            this.rbtEntrar.Location = new System.Drawing.Point(342, 59);
            this.rbtEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtEntrar.Name = "rbtEntrar";
            this.rbtEntrar.Size = new System.Drawing.Size(59, 17);
            this.rbtEntrar.TabIndex = 13;
            this.rbtEntrar.Text = "Entrar";
            this.rbtEntrar.UseVisualStyleBackColor = true;
            this.rbtEntrar.CheckedChanged += new System.EventHandler(this.rbtEntrar_CheckedChanged);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.Location = new System.Drawing.Point(206, 269);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(132, 39);
            this.btn_entrar.TabIndex = 20;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.Visible = false;
            this.btn_entrar.Click += new System.EventHandler(this.btnEntrarCriar_Click);
            // 
            // rbtCriarLogin
            // 
            this.rbtCriarLogin.AutoSize = true;
            this.rbtCriarLogin.Checked = true;
            this.rbtCriarLogin.Location = new System.Drawing.Point(108, 59);
            this.rbtCriarLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtCriarLogin.Name = "rbtCriarLogin";
            this.rbtCriarLogin.Size = new System.Drawing.Size(101, 17);
            this.rbtCriarLogin.TabIndex = 12;
            this.rbtCriarLogin.TabStop = true;
            this.rbtCriarLogin.Text = "Criar Usuário";
            this.rbtCriarLogin.UseVisualStyleBackColor = true;
            this.rbtCriarLogin.CheckedChanged += new System.EventHandler(this.rbtCriarLogin_CheckedChanged);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastro.Location = new System.Drawing.Point(206, 269);
            this.btn_cadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(132, 39);
            this.btn_cadastro.TabIndex = 21;
            this.btn_cadastro.Text = "Criar Usuário";
            this.btn_cadastro.Visible = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(172, 202);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(325, 23);
            this.txtSenha.TabIndex = 18;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Location = new System.Drawing.Point(206, 161);
            this.txtLoginEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(291, 23);
            this.txtLoginEmail.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(172, 120);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 23);
            this.txtNome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Digite sua Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Digite seu Login/Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digite seu Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualFotoeVídeo.Properties.Resources.okMenor;
            this.pictureBox1.Location = new System.Drawing.Point(224, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FormEntrarCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.rbtEntrar);
            this.Controls.Add(this.rbtCriarLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1333, 1231);
            this.Name = "FormEntrarCadastrar";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.FormEntrarCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rbtEntrar;
        private MetroFramework.Controls.MetroButton btn_entrar;
        private MetroFramework.Controls.MetroRadioButton rbtCriarLogin;
        private MetroFramework.Controls.MetroButton btn_cadastro;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtLoginEmail;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}