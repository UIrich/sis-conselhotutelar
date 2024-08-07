﻿namespace UI
{
    partial class frmCadUser
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
            lblNomeUser = new Label();
            txtNomeUser = new TextBox();
            txtUsernameUser = new TextBox();
            lblUsernameUser = new Label();
            txtSenhaUser = new TextBox();
            lblSenhaUser = new Label();
            btnAplicarUser = new Button();
            btnLimparUser = new Button();
            panelNewUser = new Panel();
            btnVoltar = new Button();
            lblNewUser = new Label();
            txtID = new TextBox();
            txtConfirmSenhaUser = new TextBox();
            lblConfirmSenhaUser = new Label();
            lblCargoUser = new Label();
            cboxCargoUser = new ComboBox();
            label1 = new Label();
            txtEmailUser = new TextBox();
            label2 = new Label();
            txtTelefoneUser = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panelNewUser.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Location = new Point(56, 65);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(40, 15);
            lblNomeUser.TabIndex = 0;
            lblNomeUser.Text = "Nome";
            // 
            // txtNomeUser
            // 
            txtNomeUser.Location = new Point(47, 82);
            txtNomeUser.Margin = new Padding(3, 2, 3, 2);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(284, 23);
            txtNomeUser.TabIndex = 1;
            // 
            // txtUsernameUser
            // 
            txtUsernameUser.Location = new Point(47, 122);
            txtUsernameUser.Margin = new Padding(3, 2, 3, 2);
            txtUsernameUser.Name = "txtUsernameUser";
            txtUsernameUser.Size = new Size(284, 23);
            txtUsernameUser.TabIndex = 2;
            // 
            // lblUsernameUser
            // 
            lblUsernameUser.AutoSize = true;
            lblUsernameUser.Location = new Point(56, 105);
            lblUsernameUser.Name = "lblUsernameUser";
            lblUsernameUser.Size = new Size(47, 15);
            lblUsernameUser.TabIndex = 2;
            lblUsernameUser.Text = "Usuário";
            // 
            // txtSenhaUser
            // 
            txtSenhaUser.Location = new Point(46, 203);
            txtSenhaUser.Margin = new Padding(3, 2, 3, 2);
            txtSenhaUser.Name = "txtSenhaUser";
            txtSenhaUser.Size = new Size(285, 23);
            txtSenhaUser.TabIndex = 4;
            txtSenhaUser.UseSystemPasswordChar = true;
            // 
            // lblSenhaUser
            // 
            lblSenhaUser.AutoSize = true;
            lblSenhaUser.Location = new Point(56, 186);
            lblSenhaUser.Name = "lblSenhaUser";
            lblSenhaUser.Size = new Size(39, 15);
            lblSenhaUser.TabIndex = 4;
            lblSenhaUser.Text = "Senha";
            // 
            // btnAplicarUser
            // 
            btnAplicarUser.BackColor = Color.RoyalBlue;
            btnAplicarUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAplicarUser.ForeColor = SystemColors.Window;
            btnAplicarUser.Location = new Point(234, 334);
            btnAplicarUser.Margin = new Padding(3, 2, 3, 2);
            btnAplicarUser.Name = "btnAplicarUser";
            btnAplicarUser.Size = new Size(96, 30);
            btnAplicarUser.TabIndex = 9;
            btnAplicarUser.Text = "Aplicar";
            btnAplicarUser.UseVisualStyleBackColor = false;
            btnAplicarUser.Click += btnAplicarUser_Click;
            // 
            // btnLimparUser
            // 
            btnLimparUser.BackColor = Color.RoyalBlue;
            btnLimparUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparUser.ForeColor = SystemColors.Window;
            btnLimparUser.Location = new Point(47, 334);
            btnLimparUser.Margin = new Padding(3, 2, 3, 2);
            btnLimparUser.Name = "btnLimparUser";
            btnLimparUser.Size = new Size(95, 30);
            btnLimparUser.TabIndex = 8;
            btnLimparUser.Text = "Limpar";
            btnLimparUser.UseVisualStyleBackColor = false;
            btnLimparUser.Click += btnLimparUser_Click;
            // 
            // panelNewUser
            // 
            panelNewUser.BackColor = Color.RoyalBlue;
            panelNewUser.Controls.Add(btnVoltar);
            panelNewUser.Controls.Add(lblNewUser);
            panelNewUser.Location = new Point(1, 1);
            panelNewUser.Margin = new Padding(3, 2, 3, 2);
            panelNewUser.Name = "panelNewUser";
            panelNewUser.Size = new Size(385, 40);
            panelNewUser.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.ImeMode = ImeMode.NoControl;
            btnVoltar.Location = new Point(9, 8);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(38, 26);
            btnVoltar.TabIndex = 28;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblNewUser
            // 
            lblNewUser.AutoSize = true;
            lblNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewUser.ForeColor = SystemColors.Window;
            lblNewUser.Location = new Point(114, 8);
            lblNewUser.Name = "lblNewUser";
            lblNewUser.Size = new Size(149, 21);
            lblNewUser.TabIndex = 0;
            lblNewUser.Text = "Novo colaborador";
            // 
            // txtID
            // 
            txtID.Location = new Point(169, 340);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(38, 23);
            txtID.TabIndex = 27;
            txtID.Visible = false;
            // 
            // txtConfirmSenhaUser
            // 
            txtConfirmSenhaUser.Location = new Point(46, 244);
            txtConfirmSenhaUser.Margin = new Padding(3, 2, 3, 2);
            txtConfirmSenhaUser.Name = "txtConfirmSenhaUser";
            txtConfirmSenhaUser.Size = new Size(285, 23);
            txtConfirmSenhaUser.TabIndex = 5;
            txtConfirmSenhaUser.UseSystemPasswordChar = true;
            // 
            // lblConfirmSenhaUser
            // 
            lblConfirmSenhaUser.AutoSize = true;
            lblConfirmSenhaUser.Location = new Point(56, 226);
            lblConfirmSenhaUser.Name = "lblConfirmSenhaUser";
            lblConfirmSenhaUser.Size = new Size(95, 15);
            lblConfirmSenhaUser.TabIndex = 29;
            lblConfirmSenhaUser.Text = "Confirmar senha";
            // 
            // lblCargoUser
            // 
            lblCargoUser.AutoSize = true;
            lblCargoUser.Location = new Point(209, 266);
            lblCargoUser.Name = "lblCargoUser";
            lblCargoUser.Size = new Size(39, 15);
            lblCargoUser.TabIndex = 31;
            lblCargoUser.Text = "Cargo";
            // 
            // cboxCargoUser
            // 
            cboxCargoUser.FormattingEnabled = true;
            cboxCargoUser.Items.AddRange(new object[] { "Administrador", "Conselheiro" });
            cboxCargoUser.Location = new Point(199, 284);
            cboxCargoUser.Margin = new Padding(3, 2, 3, 2);
            cboxCargoUser.Name = "cboxCargoUser";
            cboxCargoUser.Size = new Size(133, 23);
            cboxCargoUser.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 146);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 34;
            label1.Text = "E-mail";
            // 
            // txtEmailUser
            // 
            txtEmailUser.Location = new Point(47, 164);
            txtEmailUser.Margin = new Padding(3, 2, 3, 2);
            txtEmailUser.Name = "txtEmailUser";
            txtEmailUser.Size = new Size(284, 23);
            txtEmailUser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 267);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 36;
            label2.Text = "Telefone";
            // 
            // txtTelefoneUser
            // 
            txtTelefoneUser.Location = new Point(47, 284);
            txtTelefoneUser.Margin = new Padding(3, 2, 3, 2);
            txtTelefoneUser.Name = "txtTelefoneUser";
            txtTelefoneUser.Size = new Size(147, 23);
            txtTelefoneUser.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(46, 65);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 37;
            label3.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(199, 266);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 40;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(46, 226);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 41;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(46, 186);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 42;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(47, 146);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 43;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(46, 105);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 44;
            label10.Text = "*";
            // 
            // frmCadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 389);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefoneUser);
            Controls.Add(label1);
            Controls.Add(txtEmailUser);
            Controls.Add(cboxCargoUser);
            Controls.Add(lblCargoUser);
            Controls.Add(lblConfirmSenhaUser);
            Controls.Add(txtConfirmSenhaUser);
            Controls.Add(txtID);
            Controls.Add(panelNewUser);
            Controls.Add(btnLimparUser);
            Controls.Add(btnAplicarUser);
            Controls.Add(txtSenhaUser);
            Controls.Add(lblSenhaUser);
            Controls.Add(txtUsernameUser);
            Controls.Add(lblUsernameUser);
            Controls.Add(txtNomeUser);
            Controls.Add(lblNomeUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmCadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCadUser";
            panelNewUser.ResumeLayout(false);
            panelNewUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeUser;
        private TextBox txtNomeUser;
        private TextBox txtUsernameUser;
        private Label lblUsernameUser;
        private TextBox txtSenhaUser;
        private Label lblSenhaUser;
        private Button btnAplicarUser;
        private Button btnLimparUser;
        private Panel panelNewUser;
        private Label lblNewUser;
        private TextBox txtID;
        private Button btnVoltar;
        private TextBox txtConfirmSenhaUser;
        private Label lblConfirmSenhaUser;
        private Label lblCargoUser;
        private ComboBox cboxCargoUser;
        private Label label1;
        private TextBox txtEmailUser;
        private Label label2;
        private TextBox txtTelefoneUser;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}