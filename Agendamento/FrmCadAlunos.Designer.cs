namespace Agendamento
{
    partial class FrmCadAlunos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtCodaluno = new TextBox();
            BtnPesquisarAluno = new Button();
            panel2 = new Panel();
            BtnExcluir = new Button();
            BtnSalvar = new Button();
            btnNovo = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            BtnPesquisarprof = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 22);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 81);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 115);
            label2.Name = "label2";
            label2.Size = new Size(29, 16);
            label2.TabIndex = 2;
            label2.Text = "RA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 164);
            label3.Name = "label3";
            label3.Size = new Size(49, 16);
            label3.TabIndex = 3;
            label3.Text = "Turma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 218);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 4;
            label4.Text = "Professor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(8, 12);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 5;
            label5.Text = "Cod. Aluno:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtCodaluno);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BtnPesquisarAluno);
            panel1.Location = new Point(6, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 43);
            panel1.TabIndex = 6;
            // 
            // txtCodaluno
            // 
            txtCodaluno.Location = new Point(91, 6);
            txtCodaluno.Name = "txtCodaluno";
            txtCodaluno.Size = new Size(56, 22);
            txtCodaluno.TabIndex = 7;
            // 
            // BtnPesquisarAluno
            // 
            BtnPesquisarAluno.Location = new Point(319, 8);
            BtnPesquisarAluno.Name = "BtnPesquisarAluno";
            BtnPesquisarAluno.Size = new Size(104, 24);
            BtnPesquisarAluno.TabIndex = 12;
            BtnPesquisarAluno.Text = "Pesquisar";
            BtnPesquisarAluno.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BtnExcluir);
            panel2.Controls.Add(BtnSalvar);
            panel2.Controls.Add(btnNovo);
            panel2.Location = new Point(7, 247);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 43);
            panel2.TabIndex = 7;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(343, 11);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(90, 26);
            BtnExcluir.TabIndex = 10;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(176, 11);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(93, 26);
            BtnSalvar.TabIndex = 9;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(3, 11);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(90, 26);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 22);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(78, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 22);
            textBox4.TabIndex = 10;
            // 
            // BtnPesquisarprof
            // 
            BtnPesquisarprof.Location = new Point(366, 218);
            BtnPesquisarprof.Name = "BtnPesquisarprof";
            BtnPesquisarprof.Size = new Size(75, 23);
            BtnPesquisarprof.TabIndex = 13;
            BtnPesquisarprof.Text = "Pequisar";
            BtnPesquisarprof.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 190);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // FrmCadAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 297);
            Controls.Add(groupBox1);
            Controls.Add(BtnPesquisarprof);
            Controls.Add(textBox4);
            Controls.Add(panel2);
            Controls.Add(label4);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private TextBox txtCodaluno;
        private Panel panel2;
        private Button BtnExcluir;
        private Button BtnSalvar;
        private Button btnNovo;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button BtnPesquisarAluno;
        private Button BtnPesquisarprof;
        private GroupBox groupBox1;
    }
}