namespace UI
{
    partial class frmCadFamilia
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
            txtID = new TextBox();
            btnLimparFamilia = new Button();
            btnAplicarFamilia = new Button();
            txtPartFamilia = new TextBox();
            lblUsernameUser = new Label();
            txtSobrenomeFamilia = new TextBox();
            lblSobrenomeFamilia = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            txtResFamilia = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(236, 98);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 83;
            label10.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(47, 59);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 82;
            label3.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 98);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 81;
            label1.Text = "Responsável";
            // 
            // txtID
            // 
            txtID.Location = new Point(170, 164);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(38, 23);
            txtID.TabIndex = 80;
            txtID.Visible = false;
            // 
            // btnLimparFamilia
            // 
            btnLimparFamilia.BackColor = Color.RoyalBlue;
            btnLimparFamilia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparFamilia.ForeColor = SystemColors.Window;
            btnLimparFamilia.Location = new Point(48, 158);
            btnLimparFamilia.Margin = new Padding(3, 2, 3, 2);
            btnLimparFamilia.Name = "btnLimparFamilia";
            btnLimparFamilia.Size = new Size(95, 30);
            btnLimparFamilia.TabIndex = 4;
            btnLimparFamilia.Text = "Limpar";
            btnLimparFamilia.UseVisualStyleBackColor = false;
            btnLimparFamilia.Click += btnLimparFamilia_Click;
            // 
            // btnAplicarFamilia
            // 
            btnAplicarFamilia.BackColor = Color.RoyalBlue;
            btnAplicarFamilia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAplicarFamilia.ForeColor = SystemColors.Window;
            btnAplicarFamilia.Location = new Point(235, 158);
            btnAplicarFamilia.Margin = new Padding(3, 2, 3, 2);
            btnAplicarFamilia.Name = "btnAplicarFamilia";
            btnAplicarFamilia.Size = new Size(96, 30);
            btnAplicarFamilia.TabIndex = 5;
            btnAplicarFamilia.Text = "Aplicar";
            btnAplicarFamilia.UseVisualStyleBackColor = false;
            btnAplicarFamilia.Click += btnAplicarFamilia_Click;
            // 
            // txtPartFamilia
            // 
            txtPartFamilia.Location = new Point(237, 116);
            txtPartFamilia.Margin = new Padding(3, 2, 3, 2);
            txtPartFamilia.Name = "txtPartFamilia";
            txtPartFamilia.Size = new Size(95, 23);
            txtPartFamilia.TabIndex = 3;
            // 
            // lblUsernameUser
            // 
            lblUsernameUser.AutoSize = true;
            lblUsernameUser.Location = new Point(246, 98);
            lblUsernameUser.Name = "lblUsernameUser";
            lblUsernameUser.Size = new Size(75, 15);
            lblUsernameUser.TabIndex = 78;
            lblUsernameUser.Text = "Participantes";
            // 
            // txtSobrenomeFamilia
            // 
            txtSobrenomeFamilia.Location = new Point(48, 76);
            txtSobrenomeFamilia.Margin = new Padding(3, 2, 3, 2);
            txtSobrenomeFamilia.Name = "txtSobrenomeFamilia";
            txtSobrenomeFamilia.Size = new Size(284, 23);
            txtSobrenomeFamilia.TabIndex = 1;
            // 
            // lblSobrenomeFamilia
            // 
            lblSobrenomeFamilia.AutoSize = true;
            lblSobrenomeFamilia.Location = new Point(57, 59);
            lblSobrenomeFamilia.Name = "lblSobrenomeFamilia";
            lblSobrenomeFamilia.Size = new Size(178, 15);
            lblSobrenomeFamilia.TabIndex = 77;
            lblSobrenomeFamilia.Text = "Sobrenome (Não se limita a um)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-7, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 33);
            panel1.TabIndex = 86;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(131, 7);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 0;
            label4.Text = "Nova família";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(47, 98);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 87;
            label2.Text = "*";
            // 
            // txtResFamilia
            // 
            txtResFamilia.Location = new Point(51, 116);
            txtResFamilia.Margin = new Padding(3, 2, 3, 2);
            txtResFamilia.Name = "txtResFamilia";
            txtResFamilia.Size = new Size(182, 23);
            txtResFamilia.TabIndex = 2;
            // 
            // frmCadFamilia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 230);
            Controls.Add(txtResFamilia);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnLimparFamilia);
            Controls.Add(btnAplicarFamilia);
            Controls.Add(txtPartFamilia);
            Controls.Add(lblUsernameUser);
            Controls.Add(txtSobrenomeFamilia);
            Controls.Add(lblSobrenomeFamilia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmCadFamilia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCadFamilia";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxFamiliaCidadao;
        private Label label2;
        private Label label10;
        private Label label3;
        private Label label1;
        private TextBox txtTelCidadao;
        private TextBox txtID;
        private Button btnLimparFamilia;
        private Button btnAplicarFamilia;
        private TextBox txtEmailCidadao;
        private Label lblSenhaUser;
        private TextBox txtPartFamilia;
        private Label lblUsernameUser;
        private TextBox txtSobrenomeFamilia;
        private Label lblSobrenomeFamilia;
        private Panel panel1;
        private Label label4;
        private TextBox txtResFamilia;
    }
}