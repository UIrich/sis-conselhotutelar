namespace UI
{
    partial class frmCadCidadao
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
            label10 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtTelCidadao = new TextBox();
            txtID = new TextBox();
            btnLimparCidadao = new Button();
            btnAplicarCidadao = new Button();
            txtEmailCidadao = new TextBox();
            lblSenhaUser = new Label();
            txtIdadeCidadao = new TextBox();
            lblUsernameUser = new Label();
            txtNomeCidadao = new TextBox();
            lblNomeUser = new Label();
            panel1 = new Panel();
            label2 = new Label();
            cboxFamiliaCidadao = new ComboBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(41, 90);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 67;
            label10.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(41, 50);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 62;
            label3.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 90);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 60;
            label1.Text = "Telefone";
            // 
            // txtTelCidadao
            // 
            txtTelCidadao.Location = new Point(142, 107);
            txtTelCidadao.Margin = new Padding(3, 2, 3, 2);
            txtTelCidadao.Name = "txtTelCidadao";
            txtTelCidadao.Size = new Size(183, 23);
            txtTelCidadao.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(163, 242);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(38, 23);
            txtID.TabIndex = 57;
            txtID.Visible = false;
            // 
            // btnLimparCidadao
            // 
            btnLimparCidadao.BackColor = Color.RoyalBlue;
            btnLimparCidadao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparCidadao.ForeColor = SystemColors.Window;
            btnLimparCidadao.Location = new Point(41, 236);
            btnLimparCidadao.Margin = new Padding(3, 2, 3, 2);
            btnLimparCidadao.Name = "btnLimparCidadao";
            btnLimparCidadao.Size = new Size(95, 30);
            btnLimparCidadao.TabIndex = 5;
            btnLimparCidadao.Text = "Limpar";
            btnLimparCidadao.UseVisualStyleBackColor = false;
            btnLimparCidadao.Click += btnLimparCidadao_Click;
            // 
            // btnAplicarCidadao
            // 
            btnAplicarCidadao.BackColor = Color.RoyalBlue;
            btnAplicarCidadao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAplicarCidadao.ForeColor = SystemColors.Window;
            btnAplicarCidadao.Location = new Point(228, 236);
            btnAplicarCidadao.Margin = new Padding(3, 2, 3, 2);
            btnAplicarCidadao.Name = "btnAplicarCidadao";
            btnAplicarCidadao.Size = new Size(96, 30);
            btnAplicarCidadao.TabIndex = 6;
            btnAplicarCidadao.Text = "Aplicar";
            btnAplicarCidadao.UseVisualStyleBackColor = false;
            btnAplicarCidadao.Click += btnAplicarCidadao_Click;
            // 
            // txtEmailCidadao
            // 
            txtEmailCidadao.Location = new Point(42, 148);
            txtEmailCidadao.Margin = new Padding(3, 2, 3, 2);
            txtEmailCidadao.Name = "txtEmailCidadao";
            txtEmailCidadao.Size = new Size(283, 23);
            txtEmailCidadao.TabIndex = 4;
            // 
            // lblSenhaUser
            // 
            lblSenhaUser.AutoSize = true;
            lblSenhaUser.Location = new Point(42, 130);
            lblSenhaUser.Name = "lblSenhaUser";
            lblSenhaUser.Size = new Size(41, 15);
            lblSenhaUser.TabIndex = 50;
            lblSenhaUser.Text = "E-mail";
            // 
            // txtIdadeCidadao
            // 
            txtIdadeCidadao.Location = new Point(42, 107);
            txtIdadeCidadao.Margin = new Padding(3, 2, 3, 2);
            txtIdadeCidadao.Name = "txtIdadeCidadao";
            txtIdadeCidadao.Size = new Size(95, 23);
            txtIdadeCidadao.TabIndex = 2;
            // 
            // lblUsernameUser
            // 
            lblUsernameUser.AutoSize = true;
            lblUsernameUser.Location = new Point(51, 90);
            lblUsernameUser.Name = "lblUsernameUser";
            lblUsernameUser.Size = new Size(36, 15);
            lblUsernameUser.TabIndex = 47;
            lblUsernameUser.Text = "Idade";
            // 
            // txtNomeCidadao
            // 
            txtNomeCidadao.Location = new Point(42, 68);
            txtNomeCidadao.Margin = new Padding(3, 2, 3, 2);
            txtNomeCidadao.Name = "txtNomeCidadao";
            txtNomeCidadao.Size = new Size(284, 23);
            txtNomeCidadao.TabIndex = 1;
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Location = new Point(51, 50);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(40, 15);
            lblNomeUser.TabIndex = 45;
            lblNomeUser.Text = "Nome";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(0, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 35);
            panel1.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 170);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 69;
            label2.Text = "Família";
            // 
            // cboxFamiliaCidadao
            // 
            cboxFamiliaCidadao.FormattingEnabled = true;
            cboxFamiliaCidadao.Location = new Point(41, 188);
            cboxFamiliaCidadao.Margin = new Padding(3, 2, 3, 2);
            cboxFamiliaCidadao.Name = "cboxFamiliaCidadao";
            cboxFamiliaCidadao.Size = new Size(284, 23);
            cboxFamiliaCidadao.TabIndex = 70;
            // 
            // frmCadCidadao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 296);
            Controls.Add(cboxFamiliaCidadao);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtTelCidadao);
            Controls.Add(txtID);
            Controls.Add(btnLimparCidadao);
            Controls.Add(btnAplicarCidadao);
            Controls.Add(txtEmailCidadao);
            Controls.Add(lblSenhaUser);
            Controls.Add(txtIdadeCidadao);
            Controls.Add(lblUsernameUser);
            Controls.Add(txtNomeCidadao);
            Controls.Add(lblNomeUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmCadCidadao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCadCidadao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label3;
        private Label label1;
        private TextBox txtTelCidadao;
        private TextBox txtID;
        private Button btnLimparCidadao;
        private Button btnAplicarCidadao;
        private TextBox txtEmailCidadao;
        private Label lblSenhaUser;
        private TextBox txtIdadeCidadao;
        private Label lblUsernameUser;
        private TextBox txtNomeCidadao;
        private Label lblNomeUser;
        private Panel panel1;
        private Label label2;
        private ComboBox cboxFamiliaCidadao;
    }
}