namespace Agendamento
{
    partial class FrmCadSalas
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
            textBox1 = new TextBox();
            label1 = new Label();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            textBox2 = new TextBox();
            checkBoxAtivo = new CheckBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 22);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(35, 16);
            label1.TabIndex = 1;
            label1.Text = "Cod:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(335, 83);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 28);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(167, 83);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 28);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(3, 83);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 28);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 22);
            textBox2.TabIndex = 4;
            // 
            // checkBoxAtivo
            // 
            checkBoxAtivo.AutoSize = true;
            checkBoxAtivo.Location = new Point(351, 17);
            checkBoxAtivo.Name = "checkBoxAtivo";
            checkBoxAtivo.Size = new Size(56, 20);
            checkBoxAtivo.TabIndex = 5;
            checkBoxAtivo.Text = "Ativo";
            checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 21);
            label2.Name = "label2";
            label2.Size = new Size(106, 16);
            label2.TabIndex = 6;
            label2.Text = "Número da sala:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBoxAtivo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 65);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // FrmCadSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(420, 117);
            Controls.Add(btnExcluir);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadSalas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de salas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private TextBox textBox2;
        private CheckBox checkBoxAtivo;
        private Label label2;
        private GroupBox groupBox1;
    }
}