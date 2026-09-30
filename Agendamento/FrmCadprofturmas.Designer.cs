namespace Agendamento
{
    partial class FrmCadprofturmas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            DVGturmas = new DataGridView();
            checkBoxAtivo = new CheckBox();
            btnrmTurma = new Button();
            btnAddtuma = new Button();
            panel1 = new Panel();
            btnPesquisar = new Button();
            txtCodprof = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            DGVTumas = new DataGridView();
            panel3 = new Panel();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            tabPage2 = new TabPage();
            label8 = new Label();
            comboBoxPeriodo = new ComboBox();
            checkBoxturma = new CheckBox();
            label7 = new Label();
            txtnometurma = new TextBox();
            panel4 = new Panel();
            BtnExcluirturma = new Button();
            Btnnovaturma = new Button();
            BtnSalvarturma = new Button();
            panel2 = new Panel();
            BtnPesquisarTurma = new Button();
            TXTcodturma = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVGturmas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTumas).BeginInit();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(510, 518);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(DVGturmas);
            tabPage1.Controls.Add(checkBoxAtivo);
            tabPage1.Controls.Add(btnrmTurma);
            tabPage1.Controls.Add(btnAddtuma);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(DGVTumas);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(502, 489);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro de professores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 196);
            label5.Name = "label5";
            label5.Size = new Size(135, 16);
            label5.TabIndex = 20;
            label5.Text = "Turmas cadastradas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 196);
            label4.Name = "label4";
            label4.Size = new Size(203, 16);
            label4.TabIndex = 19;
            label4.Text = "Turmas vinculadas ao professor:";
            // 
            // DVGturmas
            // 
            DVGturmas.BackgroundColor = Color.White;
            DVGturmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGturmas.Location = new Point(266, 218);
            DVGturmas.Name = "DVGturmas";
            DVGturmas.Size = new Size(227, 218);
            DVGturmas.TabIndex = 18;
            // 
            // checkBoxAtivo
            // 
            checkBoxAtivo.AutoSize = true;
            checkBoxAtivo.Location = new Point(418, 64);
            checkBoxAtivo.Name = "checkBoxAtivo";
            checkBoxAtivo.Size = new Size(56, 20);
            checkBoxAtivo.TabIndex = 17;
            checkBoxAtivo.Text = "Ativo";
            checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // btnrmTurma
            // 
            btnrmTurma.Location = new Point(11, 167);
            btnrmTurma.Name = "btnrmTurma";
            btnrmTurma.Size = new Size(120, 23);
            btnrmTurma.TabIndex = 16;
            btnrmTurma.Text = "Remover";
            btnrmTurma.UseVisualStyleBackColor = true;
            // 
            // btnAddtuma
            // 
            btnAddtuma.Location = new Point(373, 167);
            btnAddtuma.Name = "btnAddtuma";
            btnAddtuma.Size = new Size(120, 23);
            btnAddtuma.TabIndex = 15;
            btnAddtuma.Text = "Adicionar turma";
            btnAddtuma.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(txtCodprof);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 50);
            panel1.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(398, 11);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(92, 32);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtCodprof
            // 
            txtCodprof.Location = new Point(48, 16);
            txtCodprof.Name = "txtCodprof";
            txtCodprof.Size = new Size(57, 22);
            txtCodprof.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(7, 19);
            label3.Name = "label3";
            label3.Size = new Size(35, 16);
            label3.TabIndex = 3;
            label3.Text = "Cod:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 105);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 9;
            label2.Text = "CNDB:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 64);
            label1.Name = "label1";
            label1.Size = new Size(108, 16);
            label1.TabIndex = 8;
            label1.Text = "Nome Professor:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 22);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 22);
            textBox1.TabIndex = 11;
            // 
            // DGVTumas
            // 
            DGVTumas.BackgroundColor = Color.White;
            DGVTumas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTumas.GridColor = Color.Gray;
            DGVTumas.Location = new Point(11, 218);
            DGVTumas.Name = "DGVTumas";
            DGVTumas.Size = new Size(246, 218);
            DGVTumas.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnExcluir);
            panel3.Controls.Add(btnSalvar);
            panel3.Controls.Add(btnNovo);
            panel3.Location = new Point(7, 442);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 41);
            panel3.TabIndex = 13;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(411, 8);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 28);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(208, 8);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(74, 28);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(3, 8);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(76, 28);
            btnNovo.TabIndex = 18;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(comboBoxPeriodo);
            tabPage2.Controls.Add(checkBoxturma);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtnometurma);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(502, 489);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro de turmas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 128);
            label8.Name = "label8";
            label8.Size = new Size(58, 16);
            label8.TabIndex = 6;
            label8.Text = "Periodo:";
            // 
            // comboBoxPeriodo
            // 
            comboBoxPeriodo.FormattingEnabled = true;
            comboBoxPeriodo.Location = new Point(6, 156);
            comboBoxPeriodo.Name = "comboBoxPeriodo";
            comboBoxPeriodo.Size = new Size(121, 24);
            comboBoxPeriodo.TabIndex = 5;
            // 
            // checkBoxturma
            // 
            checkBoxturma.AutoSize = true;
            checkBoxturma.Location = new Point(273, 62);
            checkBoxturma.Name = "checkBoxturma";
            checkBoxturma.Size = new Size(56, 20);
            checkBoxturma.TabIndex = 4;
            checkBoxturma.Text = "Ativo";
            checkBoxturma.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 62);
            label7.Name = "label7";
            label7.Size = new Size(102, 16);
            label7.TabIndex = 3;
            label7.Text = "Nome da turma:";
            // 
            // txtnometurma
            // 
            txtnometurma.Location = new Point(3, 81);
            txtnometurma.Name = "txtnometurma";
            txtnometurma.Size = new Size(209, 22);
            txtnometurma.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(BtnExcluirturma);
            panel4.Controls.Add(Btnnovaturma);
            panel4.Controls.Add(BtnSalvarturma);
            panel4.Location = new Point(6, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(493, 42);
            panel4.TabIndex = 1;
            // 
            // BtnExcluirturma
            // 
            BtnExcluirturma.Location = new Point(413, 11);
            BtnExcluirturma.Name = "BtnExcluirturma";
            BtnExcluirturma.Size = new Size(75, 26);
            BtnExcluirturma.TabIndex = 4;
            BtnExcluirturma.Text = "Excluir";
            BtnExcluirturma.UseVisualStyleBackColor = true;
            // 
            // Btnnovaturma
            // 
            Btnnovaturma.Location = new Point(3, 11);
            Btnnovaturma.Name = "Btnnovaturma";
            Btnnovaturma.Size = new Size(75, 26);
            Btnnovaturma.TabIndex = 3;
            Btnnovaturma.Text = "Novo";
            Btnnovaturma.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarturma
            // 
            BtnSalvarturma.Location = new Point(198, 11);
            BtnSalvarturma.Name = "BtnSalvarturma";
            BtnSalvarturma.Size = new Size(81, 26);
            BtnSalvarturma.TabIndex = 2;
            BtnSalvarturma.Text = "Salvar";
            BtnSalvarturma.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BtnPesquisarTurma);
            panel2.Controls.Add(TXTcodturma);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(3, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 43);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // BtnPesquisarTurma
            // 
            BtnPesquisarTurma.Location = new Point(378, 3);
            BtnPesquisarTurma.Name = "BtnPesquisarTurma";
            BtnPesquisarTurma.Size = new Size(110, 26);
            BtnPesquisarTurma.TabIndex = 7;
            BtnPesquisarTurma.Text = "Pequisar";
            BtnPesquisarTurma.UseVisualStyleBackColor = true;
            // 
            // TXTcodturma
            // 
            TXTcodturma.Location = new Point(46, 5);
            TXTcodturma.Name = "TXTcodturma";
            TXTcodturma.Size = new Size(58, 22);
            TXTcodturma.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(4, 13);
            label6.Name = "label6";
            label6.Size = new Size(35, 16);
            label6.TabIndex = 2;
            label6.Text = "Cod:";
            // 
            // FrmCadprofturmas
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(514, 528);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadprofturmas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de professores e turmas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DVGturmas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTumas).EndInit();
            panel3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private Button btnPesquisar;
        private TextBox txtCodprof;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView DGVTumas;
        private Panel panel3;
        private TabPage tabPage2;
        private Button btnAddtuma;
        private CheckBox checkBoxAtivo;
        private Button btnrmTurma;
        private Label label5;
        private Label label4;
        private DataGridView DVGturmas;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private Panel panel4;
        private Panel panel2;
        private TextBox TXTcodturma;
        private Label label6;
        private Label label8;
        private ComboBox comboBoxPeriodo;
        private CheckBox checkBoxturma;
        private Label label7;
        private TextBox txtnometurma;
        private Button BtnExcluirturma;
        private Button Btnnovaturma;
        private Button BtnSalvarturma;
        private Button BtnPesquisarTurma;
    }
}