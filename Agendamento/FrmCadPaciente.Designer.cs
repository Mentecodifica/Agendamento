namespace Agendamento
{
    partial class FrmCadPaciente
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
            txtNome = new TextBox();
            txtResponsavel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            maskedTextBoxCpf = new MaskedTextBox();
            label4 = new Label();
            MskData = new MaskedTextBox();
            label5 = new Label();
            txtCodcli = new TextBox();
            panel1 = new Panel();
            checkBoxAtivo = new CheckBox();
            btnPesquisar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            panel2 = new Panel();
            BtnExcluir = new Button();
            BtnSalvar = new Button();
            BtnNovo = new Button();
            RBMasc = new RadioButton();
            RBfeminino = new RadioButton();
            groupBox1 = new GroupBox();
            MTBcel2 = new MaskedTextBox();
            MTBcel1 = new MaskedTextBox();
            labe12212 = new Label();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(426, 22);
            txtNome.TabIndex = 0;
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(107, 136);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(382, 22);
            txtResponsavel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 6;
            label2.Text = "Responsável:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 107);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 7;
            label3.Text = "Data nasc:";
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(65, 98);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.PromptChar = ' ';
            maskedTextBoxCpf.Size = new Size(123, 22);
            maskedTextBoxCpf.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(36, 16);
            label4.TabIndex = 9;
            label4.Text = "CPF:";
            // 
            // MskData
            // 
            MskData.Location = new Point(401, 101);
            MskData.Mask = "00/00/0000";
            MskData.Name = "MskData";
            MskData.PromptChar = ' ';
            MskData.Size = new Size(90, 22);
            MskData.TabIndex = 10;
            MskData.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(56, 16);
            label5.TabIndex = 11;
            label5.Text = "Cod. Cli:";
            // 
            // txtCodcli
            // 
            txtCodcli.Location = new Point(65, 6);
            txtCodcli.Name = "txtCodcli";
            txtCodcli.Size = new Size(77, 22);
            txtCodcli.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBoxAtivo);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCodcli);
            panel1.Location = new Point(3, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 41);
            panel1.TabIndex = 13;
            // 
            // checkBoxAtivo
            // 
            checkBoxAtivo.AutoSize = true;
            checkBoxAtivo.ForeColor = Color.Black;
            checkBoxAtivo.Location = new Point(172, 8);
            checkBoxAtivo.Name = "checkBoxAtivo";
            checkBoxAtivo.Size = new Size(56, 20);
            checkBoxAtivo.TabIndex = 21;
            checkBoxAtivo.Text = "Ativo";
            checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(378, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 30);
            btnPesquisar.TabIndex = 13;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(90, 167);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PromptChar = ' ';
            maskedTextBox1.Size = new Size(123, 22);
            maskedTextBox1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 173);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 15;
            label6.Text = "CPF Resp:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BtnExcluir);
            panel2.Controls.Add(BtnSalvar);
            panel2.Controls.Add(BtnNovo);
            panel2.Location = new Point(5, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 40);
            panel2.TabIndex = 16;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(388, 11);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(93, 25);
            BtnExcluir.TabIndex = 19;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(188, 11);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(100, 24);
            BtnSalvar.TabIndex = 18;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(6, 11);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(100, 24);
            BtnNovo.TabIndex = 17;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // RBMasc
            // 
            RBMasc.AutoSize = true;
            RBMasc.Location = new Point(6, 21);
            RBMasc.Name = "RBMasc";
            RBMasc.Size = new Size(86, 20);
            RBMasc.TabIndex = 21;
            RBMasc.TabStop = true;
            RBMasc.Text = "Masculino";
            RBMasc.UseVisualStyleBackColor = true;
            // 
            // RBfeminino
            // 
            RBfeminino.AutoSize = true;
            RBfeminino.Location = new Point(98, 21);
            RBfeminino.Name = "RBfeminino";
            RBfeminino.Size = new Size(80, 20);
            RBfeminino.TabIndex = 22;
            RBfeminino.TabStop = true;
            RBfeminino.Text = "Feminino";
            RBfeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBfeminino);
            groupBox1.Controls.Add(RBMasc);
            groupBox1.Location = new Point(300, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(191, 58);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo:";
            // 
            // MTBcel2
            // 
            MTBcel2.Location = new Point(194, 209);
            MTBcel2.Mask = "(00)00000-0000";
            MTBcel2.Name = "MTBcel2";
            MTBcel2.PromptChar = ' ';
            MTBcel2.Size = new Size(100, 22);
            MTBcel2.TabIndex = 21;
            // 
            // MTBcel1
            // 
            MTBcel1.Location = new Point(79, 209);
            MTBcel1.Mask = "(00)00000-0000";
            MTBcel1.Name = "MTBcel1";
            MTBcel1.PromptChar = ' ';
            MTBcel1.Size = new Size(100, 22);
            MTBcel1.TabIndex = 22;
            // 
            // labe12212
            // 
            labe12212.AutoSize = true;
            labe12212.Location = new Point(16, 212);
            labe12212.Name = "labe12212";
            labe12212.Size = new Size(56, 16);
            labe12212.TabIndex = 23;
            labe12212.Text = "Contato:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 279);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // FrmCadPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(506, 290);
            Controls.Add(labe12212);
            Controls.Add(MTBcel1);
            Controls.Add(MTBcel2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(maskedTextBox1);
            Controls.Add(MskData);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResponsavel);
            Controls.Add(txtNome);
            Controls.Add(groupBox2);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pacientes";
            Load += FrmCadPaciente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtResponsavel;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBoxCpf;
        private Label label4;
        private MaskedTextBox MskData;
        private Label label5;
        private TextBox txtCodcli;
        private Panel panel1;
        private Button btnPesquisar;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private Panel panel2;
        private Button BtnExcluir;
        private Button BtnSalvar;
        private Button BtnNovo;
        private CheckBox checkBoxAtivo;
        private RadioButton RBMasc;
        private RadioButton RBfeminino;
        private GroupBox groupBox1;
        private MaskedTextBox MTBcel2;
        private MaskedTextBox MTBcel1;
        private Label labe12212;
        private GroupBox groupBox2;
    }
}