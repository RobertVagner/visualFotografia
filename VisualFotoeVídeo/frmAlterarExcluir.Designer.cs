namespace VisualFotoeVídeo
{
    partial class frmAlterarExcluir
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
            this.txtHD = new MetroFramework.Controls.MetroTextBox();
            this.picLimpar = new System.Windows.Forms.PictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.ckbBackup = new System.Windows.Forms.CheckBox();
            this.ckbLegenda = new System.Windows.Forms.CheckBox();
            this.ckbDados = new System.Windows.Forms.CheckBox();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.dataEntregaEdicao = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataEvento = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCpfCnpj = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbmNomeEvento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnExcluir = new System.Windows.Forms.RadioButton();
            this.rbnAlterar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pnFaseEvento = new System.Windows.Forms.Panel();
            this.rbtFinalizada = new System.Windows.Forms.RadioButton();
            this.rbtEmAndamento = new System.Windows.Forms.RadioButton();
            this.rbtSemEdicao = new System.Windows.Forms.RadioButton();
            this.txtEditor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).BeginInit();
            this.pnInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnFaseEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(1072, 484);
            this.txtHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(732, 23);
            this.txtHD.TabIndex = 36;
            // 
            // picLimpar
            // 
            this.picLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLimpar.Image = global::VisualFotoeVídeo.Properties.Resources.limpar;
            this.picLimpar.Location = new System.Drawing.Point(1857, 852);
            this.picLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLimpar.Name = "picLimpar";
            this.picLimpar.Size = new System.Drawing.Size(53, 58);
            this.picLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLimpar.TabIndex = 21;
            this.picLimpar.TabStop = false;
            this.picLimpar.Click += new System.EventHandler(this.picLimpar_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(625, 487);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(340, 20);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Informe o nome do HD que descarregou os arquivos:";
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnInfo.Controls.Add(this.ckbBackup);
            this.pnInfo.Controls.Add(this.ckbLegenda);
            this.pnInfo.Controls.Add(this.ckbDados);
            this.pnInfo.Location = new System.Drawing.Point(1380, 377);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(424, 85);
            this.pnInfo.TabIndex = 34;
            // 
            // ckbBackup
            // 
            this.ckbBackup.AutoSize = true;
            this.ckbBackup.Location = new System.Drawing.Point(283, 32);
            this.ckbBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbBackup.Name = "ckbBackup";
            this.ckbBackup.Size = new System.Drawing.Size(75, 20);
            this.ckbBackup.TabIndex = 2;
            this.ckbBackup.Text = "Backup";
            this.ckbBackup.UseVisualStyleBackColor = true;
            // 
            // ckbLegenda
            // 
            this.ckbLegenda.AutoSize = true;
            this.ckbLegenda.Location = new System.Drawing.Point(168, 32);
            this.ckbLegenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbLegenda.Name = "ckbLegenda";
            this.ckbLegenda.Size = new System.Drawing.Size(63, 20);
            this.ckbLegenda.TabIndex = 1;
            this.ckbLegenda.Text = "Fotos";
            this.ckbLegenda.UseVisualStyleBackColor = true;
            // 
            // ckbDados
            // 
            this.ckbDados.AutoSize = true;
            this.ckbDados.Location = new System.Drawing.Point(61, 32);
            this.ckbDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbDados.Name = "ckbDados";
            this.ckbDados.Size = new System.Drawing.Size(70, 20);
            this.ckbDados.TabIndex = 0;
            this.ckbDados.Text = "Dados";
            this.ckbDados.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Location = new System.Drawing.Point(845, 887);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(357, 38);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dataEntregaEdicao
            // 
            this.dataEntregaEdicao.Location = new System.Drawing.Point(1003, 426);
            this.dataEntregaEdicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataEntregaEdicao.Name = "dataEntregaEdicao";
            this.dataEntregaEdicao.Size = new System.Drawing.Size(303, 22);
            this.dataEntregaEdicao.TabIndex = 32;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(1003, 389);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(262, 20);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Selecione a data de entrega das edições:";
            // 
            // dataEvento
            // 
            this.dataEvento.Location = new System.Drawing.Point(625, 426);
            this.dataEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataEvento.Name = "dataEvento";
            this.dataEvento.Size = new System.Drawing.Size(303, 22);
            this.dataEvento.TabIndex = 30;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(625, 389);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(180, 20);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Selecione a data do evento:";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(764, 310);
            this.txtCpfCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(1040, 23);
            this.txtCpfCnpj.TabIndex = 28;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(625, 313);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 20);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Cidade:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(764, 270);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1040, 23);
            this.txtDescricao.TabIndex = 26;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(625, 273);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Descrição:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.cbmNomeEvento);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(625, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 114);
            this.panel2.TabIndex = 24;
            // 
            // cbmNomeEvento
            // 
            this.cbmNomeEvento.FormattingEnabled = true;
            this.cbmNomeEvento.Location = new System.Drawing.Point(29, 62);
            this.cbmNomeEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmNomeEvento.Name = "cbmNomeEvento";
            this.cbmNomeEvento.Size = new System.Drawing.Size(1113, 24);
            this.cbmNomeEvento.TabIndex = 1;
            this.cbmNomeEvento.SelectedIndexChanged += new System.EventHandler(this.cbmNomeEvento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione o evento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(764, 231);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(1040, 23);
            this.txtNome.TabIndex = 23;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(625, 235);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 20);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbnExcluir);
            this.panel1.Controls.Add(this.rbnAlterar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 1089);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "O que deseja fazer:";
            // 
            // rbnExcluir
            // 
            this.rbnExcluir.AutoSize = true;
            this.rbnExcluir.Location = new System.Drawing.Point(101, 249);
            this.rbnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnExcluir.Name = "rbnExcluir";
            this.rbnExcluir.Size = new System.Drawing.Size(67, 20);
            this.rbnExcluir.TabIndex = 3;
            this.rbnExcluir.TabStop = true;
            this.rbnExcluir.Text = "Excluir";
            this.rbnExcluir.UseVisualStyleBackColor = true;
            this.rbnExcluir.CheckedChanged += new System.EventHandler(this.rbnExcluir_CheckedChanged);
            // 
            // rbnAlterar
            // 
            this.rbnAlterar.AutoSize = true;
            this.rbnAlterar.Location = new System.Drawing.Point(101, 214);
            this.rbnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnAlterar.Name = "rbnAlterar";
            this.rbnAlterar.Size = new System.Drawing.Size(67, 20);
            this.rbnAlterar.TabIndex = 2;
            this.rbnAlterar.TabStop = true;
            this.rbnAlterar.Text = "Alterar";
            this.rbnAlterar.UseVisualStyleBackColor = true;
            this.rbnAlterar.CheckedChanged += new System.EventHandler(this.rbnAlterar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(93, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alterar/Excluir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualFotoeVídeo.Properties.Resources.okMenor;
            this.pictureBox1.Location = new System.Drawing.Point(113, 772);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(1251, 887);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(357, 38);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(625, 676);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 20);
            this.metroLabel8.TabIndex = 42;
            this.metroLabel8.Text = "Fase da Edição:";
            // 
            // pnFaseEvento
            // 
            this.pnFaseEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnFaseEvento.Controls.Add(this.rbtFinalizada);
            this.pnFaseEvento.Controls.Add(this.rbtEmAndamento);
            this.pnFaseEvento.Controls.Add(this.rbtSemEdicao);
            this.pnFaseEvento.Location = new System.Drawing.Point(625, 711);
            this.pnFaseEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFaseEvento.Name = "pnFaseEvento";
            this.pnFaseEvento.Size = new System.Drawing.Size(1179, 94);
            this.pnFaseEvento.TabIndex = 41;
            // 
            // rbtFinalizada
            // 
            this.rbtFinalizada.AutoSize = true;
            this.rbtFinalizada.Location = new System.Drawing.Point(876, 41);
            this.rbtFinalizada.Name = "rbtFinalizada";
            this.rbtFinalizada.Size = new System.Drawing.Size(90, 20);
            this.rbtFinalizada.TabIndex = 2;
            this.rbtFinalizada.TabStop = true;
            this.rbtFinalizada.Text = "Finalizada";
            this.rbtFinalizada.UseVisualStyleBackColor = true;
            // 
            // rbtEmAndamento
            // 
            this.rbtEmAndamento.AutoSize = true;
            this.rbtEmAndamento.Location = new System.Drawing.Point(531, 41);
            this.rbtEmAndamento.Name = "rbtEmAndamento";
            this.rbtEmAndamento.Size = new System.Drawing.Size(120, 20);
            this.rbtEmAndamento.TabIndex = 1;
            this.rbtEmAndamento.TabStop = true;
            this.rbtEmAndamento.Text = "Em Andamento";
            this.rbtEmAndamento.UseVisualStyleBackColor = true;
            // 
            // rbtSemEdicao
            // 
            this.rbtSemEdicao.AutoSize = true;
            this.rbtSemEdicao.Location = new System.Drawing.Point(172, 41);
            this.rbtSemEdicao.Name = "rbtSemEdicao";
            this.rbtSemEdicao.Size = new System.Drawing.Size(102, 20);
            this.rbtSemEdicao.TabIndex = 0;
            this.rbtSemEdicao.TabStop = true;
            this.rbtSemEdicao.Text = "Sem Edição";
            this.rbtSemEdicao.UseVisualStyleBackColor = true;
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(913, 540);
            this.txtEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(891, 23);
            this.txtEditor.TabIndex = 46;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(625, 544);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(173, 20);
            this.metroLabel9.TabIndex = 45;
            this.metroLabel9.Text = "Informe o nome do Editor:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(913, 598);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(445, 30);
            this.metroComboBox1.TabIndex = 44;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(625, 598);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(180, 20);
            this.metroLabel7.TabIndex = 43;
            this.metroLabel7.Text = "Informe o nome do Usuário";
            // 
            // frmAlterarExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1081);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.pnFaseEvento);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.picLimpar);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dataEntregaEdicao);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dataEvento);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAlterarExcluir";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAlterarExcluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).EndInit();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnFaseEvento.ResumeLayout(false);
            this.pnFaseEvento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtHD;
        private System.Windows.Forms.PictureBox picLimpar;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.CheckBox ckbBackup;
        private System.Windows.Forms.CheckBox ckbLegenda;
        private System.Windows.Forms.CheckBox ckbDados;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private System.Windows.Forms.DateTimePicker dataEntregaEdicao;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DateTimePicker dataEvento;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCpfCnpj;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbmNomeEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnExcluir;
        private System.Windows.Forms.RadioButton rbnAlterar;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Panel pnFaseEvento;
        private System.Windows.Forms.RadioButton rbtFinalizada;
        private System.Windows.Forms.RadioButton rbtEmAndamento;
        private System.Windows.Forms.RadioButton rbtSemEdicao;
        private MetroFramework.Controls.MetroTextBox txtEditor;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}