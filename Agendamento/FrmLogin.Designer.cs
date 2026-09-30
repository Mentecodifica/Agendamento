namespace Agendamento
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnEntrar = new Button();
            BtnSair = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Location = new Point(122, 256);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(140, 22);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.CharacterCasing = CharacterCasing.Upper;
            txtSenha.Location = new Point(122, 301);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(140, 22);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 307);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 2;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 256);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // BtnEntrar
            // 
            BtnEntrar.Location = new Point(122, 342);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(75, 23);
            BtnEntrar.TabIndex = 4;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(424, 342);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(80, 23);
            BtnSair.TabIndex = 5;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(516, 368);
            Controls.Add(BtnSair);
            Controls.Add(BtnEntrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button BtnEntrar;
        private Button BtnSair;
    }
}
