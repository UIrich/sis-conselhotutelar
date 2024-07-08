namespace UI
{
    partial class frmVerCadastrados
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
            panelVerCadastrados = new Panel();
            lblVerCadastrados = new Label();
            dataGridCidadao = new DataGridView();
            dataGridColaborador = new DataGridView();
            dataGridFamilia = new DataGridView();
            lblVerCidadao = new Label();
            lblVerFamilia = new Label();
            lblVerColaborador = new Label();
            txtVerCidadao = new TextBox();
            btnPesquisarCidadao = new Button();
            btnPesquisarFamilia = new Button();
            txtVerFamilia = new TextBox();
            btnPesquisarColaborador = new Button();
            txtVerColaborador = new TextBox();
            btnLimparTudo = new Button();
            panelVerCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidadao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridColaborador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFamilia).BeginInit();
            SuspendLayout();
            // 
            // panelVerCadastrados
            // 
            panelVerCadastrados.BackColor = Color.RoyalBlue;
            panelVerCadastrados.Controls.Add(lblVerCadastrados);
            panelVerCadastrados.Location = new Point(1, 1);
            panelVerCadastrados.Margin = new Padding(3, 2, 3, 2);
            panelVerCadastrados.Name = "panelVerCadastrados";
            panelVerCadastrados.Size = new Size(971, 48);
            panelVerCadastrados.TabIndex = 0;
            // 
            // lblVerCadastrados
            // 
            lblVerCadastrados.AutoSize = true;
            lblVerCadastrados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerCadastrados.ForeColor = SystemColors.Window;
            lblVerCadastrados.Location = new Point(265, 14);
            lblVerCadastrados.Name = "lblVerCadastrados";
            lblVerCadastrados.Size = new Size(366, 25);
            lblVerCadastrados.TabIndex = 0;
            lblVerCadastrados.Text = "Visualizar pessoas e famílias cadastradas";
            // 
            // dataGridCidadao
            // 
            dataGridCidadao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidadao.Location = new Point(116, 158);
            dataGridCidadao.Margin = new Padding(3, 2, 3, 2);
            dataGridCidadao.Name = "dataGridCidadao";
            dataGridCidadao.ReadOnly = true;
            dataGridCidadao.RowHeadersWidth = 51;
            dataGridCidadao.Size = new Size(330, 141);
            dataGridCidadao.TabIndex = 1;
            dataGridCidadao.CellMouseDoubleClick += dataGridCidadao_CellMouseDoubleClick;
            // 
            // dataGridColaborador
            // 
            dataGridColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridColaborador.Location = new Point(116, 406);
            dataGridColaborador.Margin = new Padding(3, 2, 3, 2);
            dataGridColaborador.Name = "dataGridColaborador";
            dataGridColaborador.ReadOnly = true;
            dataGridColaborador.RowHeadersWidth = 51;
            dataGridColaborador.Size = new Size(712, 141);
            dataGridColaborador.TabIndex = 2;
            dataGridColaborador.CellMouseDoubleClick += dataGridColaborador_CellMouseDoubleClick;
            // 
            // dataGridFamilia
            // 
            dataGridFamilia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFamilia.Location = new Point(498, 158);
            dataGridFamilia.Margin = new Padding(3, 2, 3, 2);
            dataGridFamilia.Name = "dataGridFamilia";
            dataGridFamilia.ReadOnly = true;
            dataGridFamilia.RowHeadersWidth = 51;
            dataGridFamilia.Size = new Size(330, 141);
            dataGridFamilia.TabIndex = 3;
            // 
            // lblVerCidadao
            // 
            lblVerCidadao.AutoSize = true;
            lblVerCidadao.Location = new Point(118, 89);
            lblVerCidadao.Name = "lblVerCidadao";
            lblVerCidadao.Size = new Size(51, 15);
            lblVerCidadao.TabIndex = 4;
            lblVerCidadao.Text = "Cidadão";
            // 
            // lblVerFamilia
            // 
            lblVerFamilia.AutoSize = true;
            lblVerFamilia.Location = new Point(498, 88);
            lblVerFamilia.Name = "lblVerFamilia";
            lblVerFamilia.Size = new Size(45, 15);
            lblVerFamilia.TabIndex = 5;
            lblVerFamilia.Text = "Família";
            // 
            // lblVerColaborador
            // 
            lblVerColaborador.AutoSize = true;
            lblVerColaborador.Location = new Point(116, 340);
            lblVerColaborador.Name = "lblVerColaborador";
            lblVerColaborador.Size = new Size(73, 15);
            lblVerColaborador.TabIndex = 6;
            lblVerColaborador.Text = "Colaborador";
            // 
            // txtVerCidadao
            // 
            txtVerCidadao.Location = new Point(116, 118);
            txtVerCidadao.Margin = new Padding(3, 2, 3, 2);
            txtVerCidadao.Name = "txtVerCidadao";
            txtVerCidadao.Size = new Size(178, 23);
            txtVerCidadao.TabIndex = 7;
            // 
            // btnPesquisarCidadao
            // 
            btnPesquisarCidadao.Location = new Point(298, 118);
            btnPesquisarCidadao.Margin = new Padding(3, 2, 3, 2);
            btnPesquisarCidadao.Name = "btnPesquisarCidadao";
            btnPesquisarCidadao.Size = new Size(130, 22);
            btnPesquisarCidadao.TabIndex = 8;
            btnPesquisarCidadao.Text = "Pesquisar por nome";
            btnPesquisarCidadao.UseVisualStyleBackColor = true;
            btnPesquisarCidadao.Click += btnPesquisarCidadao_Click;
            // 
            // btnPesquisarFamilia
            // 
            btnPesquisarFamilia.Location = new Point(681, 118);
            btnPesquisarFamilia.Margin = new Padding(3, 2, 3, 2);
            btnPesquisarFamilia.Name = "btnPesquisarFamilia";
            btnPesquisarFamilia.Size = new Size(133, 22);
            btnPesquisarFamilia.TabIndex = 10;
            btnPesquisarFamilia.Text = "Pesquisar por nome";
            btnPesquisarFamilia.UseVisualStyleBackColor = true;
            // 
            // txtVerFamilia
            // 
            txtVerFamilia.Location = new Point(498, 118);
            txtVerFamilia.Margin = new Padding(3, 2, 3, 2);
            txtVerFamilia.Name = "txtVerFamilia";
            txtVerFamilia.Size = new Size(178, 23);
            txtVerFamilia.TabIndex = 9;
            // 
            // btnPesquisarColaborador
            // 
            btnPesquisarColaborador.Location = new Point(394, 367);
            btnPesquisarColaborador.Margin = new Padding(3, 2, 3, 2);
            btnPesquisarColaborador.Name = "btnPesquisarColaborador";
            btnPesquisarColaborador.Size = new Size(143, 22);
            btnPesquisarColaborador.TabIndex = 12;
            btnPesquisarColaborador.Text = "Pesquisar por nome";
            btnPesquisarColaborador.UseVisualStyleBackColor = true;
            btnPesquisarColaborador.Click += btnPesquisarColaborador_Click;
            // 
            // txtVerColaborador
            // 
            txtVerColaborador.Location = new Point(116, 368);
            txtVerColaborador.Margin = new Padding(3, 2, 3, 2);
            txtVerColaborador.Name = "txtVerColaborador";
            txtVerColaborador.Size = new Size(274, 23);
            txtVerColaborador.TabIndex = 11;
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.Location = new Point(116, 585);
            btnLimparTudo.Margin = new Padding(3, 2, 3, 2);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(103, 22);
            btnLimparTudo.TabIndex = 13;
            btnLimparTudo.Text = "Limpar tudo";
            btnLimparTudo.UseVisualStyleBackColor = true;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // frmVerCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 652);
            Controls.Add(btnLimparTudo);
            Controls.Add(btnPesquisarColaborador);
            Controls.Add(txtVerColaborador);
            Controls.Add(btnPesquisarFamilia);
            Controls.Add(txtVerFamilia);
            Controls.Add(btnPesquisarCidadao);
            Controls.Add(txtVerCidadao);
            Controls.Add(lblVerColaborador);
            Controls.Add(lblVerFamilia);
            Controls.Add(lblVerCidadao);
            Controls.Add(dataGridFamilia);
            Controls.Add(dataGridColaborador);
            Controls.Add(dataGridCidadao);
            Controls.Add(panelVerCadastrados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmVerCadastrados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVerCadastrados";
            Load += frmVerCadastrados_Load;
            panelVerCadastrados.ResumeLayout(false);
            panelVerCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidadao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridColaborador).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFamilia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelVerCadastrados;
        private DataGridView dataGridCidadao;
        private Label lblVerCadastrados;
        private DataGridView dataGridColaborador;
        private DataGridView dataGridFamilia;
        private Label lblVerCidadao;
        private Label lblVerFamilia;
        private Label lblVerColaborador;
        private TextBox txtVerCidadao;
        private Button btnPesquisarCidadao;
        private Button btnPesquisarFamilia;
        private TextBox txtVerFamilia;
        private Button btnPesquisarColaborador;
        private TextBox txtVerColaborador;
        private Button btnLimparTudo;
    }
}