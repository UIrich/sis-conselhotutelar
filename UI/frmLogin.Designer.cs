namespace UI
{
    partial class frmLogin
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
            lblUser = new Label();
            txtUser = new TextBox();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            panel1 = new Panel();
            lblBemVindo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(57, 41);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuário";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(57, 58);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(168, 23);
            txtUser.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(57, 137);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(167, 32);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(57, 98);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(168, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(57, 81);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblBemVindo);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 28);
            panel1.TabIndex = 5;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = SystemColors.Window;
            lblBemVindo.Location = new Point(93, 6);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(86, 20);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem-vindo";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 197);
            Controls.Add(panel1);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnEntrar);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txtUser;
        private Button btnEntrar;
        private TextBox txtSenha;
        private Label lblSenha;
        private Panel panel1;
        private Label lblBemVindo;
    }
}