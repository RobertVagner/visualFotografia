namespace VisualFotoeVídeo
{
    partial class frmPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnPesquisaData = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisaCpfCnpj = new MetroFramework.Controls.MetroButton();
            this.txtPequisaCpfCnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisaNome = new MetroFramework.Controls.MetroButton();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.btnPesquisaData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPesquisaCpfCnpj);
            this.panel1.Controls.Add(this.txtPequisaCpfCnpj);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPesquisaNome);
            this.panel1.Controls.Add(this.txtPesquisaNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 1089);
            this.panel1.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(25, 538);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(404, 22);
            this.txtData.TabIndex = 11;
            // 
            // btnPesquisaData
            // 
            this.btnPesquisaData.Location = new System.Drawing.Point(25, 575);
            this.btnPesquisaData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisaData.Name = "btnPesquisaData";
            this.btnPesquisaData.Size = new System.Drawing.Size(404, 31);
            this.btnPesquisaData.TabIndex = 10;
            this.btnPesquisaData.Text = "Pesquisar por Dia:";
            this.btnPesquisaData.Click += new System.EventHandler(this.btnPesquisaData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pesquisa pelo dia:";
            // 
            // btnPesquisaCpfCnpj
            // 
            this.btnPesquisaCpfCnpj.Location = new System.Drawing.Point(21, 422);
            this.btnPesquisaCpfCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisaCpfCnpj.Name = "btnPesquisaCpfCnpj";
            this.btnPesquisaCpfCnpj.Size = new System.Drawing.Size(404, 31);
            this.btnPesquisaCpfCnpj.TabIndex = 7;
            this.btnPesquisaCpfCnpj.Text = "Pesquisar por Cidade:";
            this.btnPesquisaCpfCnpj.Click += new System.EventHandler(this.btnPesquisaCpfCnpj_Click);
            // 
            // txtPequisaCpfCnpj
            // 
            this.txtPequisaCpfCnpj.Location = new System.Drawing.Point(21, 385);
            this.txtPequisaCpfCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPequisaCpfCnpj.Name = "txtPequisaCpfCnpj";
            this.txtPequisaCpfCnpj.Size = new System.Drawing.Size(404, 22);
            this.txtPequisaCpfCnpj.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesquisa por Cidade:";
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.Location = new System.Drawing.Point(21, 272);
            this.btnPesquisaNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(404, 31);
            this.btnPesquisaNome.TabIndex = 4;
            this.btnPesquisaNome.Text = "Pesquisar por Nome";
            this.btnPesquisaNome.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(21, 235);
            this.txtPesquisaNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(404, 22);
            this.txtPesquisaNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisa por Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(151, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(517, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1364, 850);
            this.dataGridView1.TabIndex = 5;
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1081);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPesquisa";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnPesquisaData;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btnPesquisaCpfCnpj;
        private System.Windows.Forms.TextBox txtPequisaCpfCnpj;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnPesquisaNome;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtData;
    }
}