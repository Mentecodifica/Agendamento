namespace Agendamento
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            groupBox1 = new GroupBox();
            label11 = new Label();
            comboBoxPsicologo = new ComboBox();
            dateTimePickerHora = new DateTimePicker();
            TxtTipoatendimeto = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            DataTimeDataagendamento = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            BtnNovoPaciente = new Button();
            BtnSalvarAgend = new Button();
            BtnReagendarAgend = new Button();
            BtnCalendario = new Button();
            BtnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(BtnCalendario);
            groupBox1.Controls.Add(BtnNovoPaciente);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBoxPsicologo);
            groupBox1.Controls.Add(dateTimePickerHora);
            groupBox1.Controls.Add(TxtTipoatendimeto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DataTimeDataagendamento);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agendar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.WindowText;
            label11.Location = new Point(6, 25);
            label11.Name = "label11";
            label11.Size = new Size(90, 16);
            label11.TabIndex = 52;
            label11.Text = "Psicologo (a):";
            // 
            // comboBoxPsicologo
            // 
            comboBoxPsicologo.FormattingEnabled = true;
            comboBoxPsicologo.Location = new Point(102, 17);
            comboBoxPsicologo.Name = "comboBoxPsicologo";
            comboBoxPsicologo.Size = new Size(121, 24);
            comboBoxPsicologo.TabIndex = 50;
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(665, 19);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.Size = new Size(68, 22);
            dateTimePickerHora.TabIndex = 47;
            // 
            // TxtTipoatendimeto
            // 
            TxtTipoatendimeto.FormattingEnabled = true;
            TxtTipoatendimeto.Location = new Point(288, 17);
            TxtTipoatendimeto.Name = "TxtTipoatendimeto";
            TxtTipoatendimeto.Size = new Size(125, 24);
            TxtTipoatendimeto.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(233, 25);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 28;
            label4.Text = "Turma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(433, 25);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 26;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(604, 25);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 25;
            label2.Text = "Horario:";
            // 
            // DataTimeDataagendamento
            // 
            DataTimeDataagendamento.Format = DateTimePickerFormat.Short;
            DataTimeDataagendamento.Location = new Point(478, 20);
            DataTimeDataagendamento.Name = "DataTimeDataagendamento";
            DataTimeDataagendamento.Size = new Size(110, 22);
            DataTimeDataagendamento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 54;
            label1.Text = "Paciente:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(102, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(486, 24);
            comboBox1.TabIndex = 55;
            // 
            // BtnNovoPaciente
            // 
            BtnNovoPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNovoPaciente.BackColor = Color.White;
            BtnNovoPaciente.ForeColor = SystemColors.WindowText;
            BtnNovoPaciente.Image = (Image)resources.GetObject("BtnNovoPaciente.Image");
            BtnNovoPaciente.Location = new Point(604, 53);
            BtnNovoPaciente.Name = "BtnNovoPaciente";
            BtnNovoPaciente.Size = new Size(137, 26);
            BtnNovoPaciente.TabIndex = 54;
            BtnNovoPaciente.Text = "Novo Paciente";
            BtnNovoPaciente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNovoPaciente.UseVisualStyleBackColor = false;
            BtnNovoPaciente.Click += BtnNovoPaciente_Click;
            // 
            // BtnSalvarAgend
            // 
            BtnSalvarAgend.BackColor = SystemColors.Control;
            BtnSalvarAgend.ForeColor = SystemColors.WindowText;
            BtnSalvarAgend.Image = (Image)resources.GetObject("BtnSalvarAgend.Image");
            BtnSalvarAgend.Location = new Point(12, 156);
            BtnSalvarAgend.Name = "BtnSalvarAgend";
            BtnSalvarAgend.Size = new Size(177, 33);
            BtnSalvarAgend.TabIndex = 54;
            BtnSalvarAgend.Text = "Salvar Agendamento";
            BtnSalvarAgend.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalvarAgend.UseVisualStyleBackColor = false;
            // 
            // BtnReagendarAgend
            // 
            BtnReagendarAgend.BackColor = SystemColors.Control;
            BtnReagendarAgend.Image = (Image)resources.GetObject("BtnReagendarAgend.Image");
            BtnReagendarAgend.Location = new Point(585, 155);
            BtnReagendarAgend.Name = "BtnReagendarAgend";
            BtnReagendarAgend.Size = new Size(168, 34);
            BtnReagendarAgend.TabIndex = 55;
            BtnReagendarAgend.Text = "Agendar/Reagendar";
            BtnReagendarAgend.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReagendarAgend.UseVisualStyleBackColor = false;
            // 
            // BtnCalendario
            // 
            BtnCalendario.BackColor = SystemColors.Control;
            BtnCalendario.Image = (Image)resources.GetObject("BtnCalendario.Image");
            BtnCalendario.Location = new Point(6, 98);
            BtnCalendario.Name = "BtnCalendario";
            BtnCalendario.Size = new Size(200, 33);
            BtnCalendario.TabIndex = 56;
            BtnCalendario.Text = "Calendario de consultas";
            BtnCalendario.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCalendario.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = SystemColors.Control;
            BtnCancelar.ForeColor = Color.Black;
            BtnCancelar.Location = new Point(300, 155);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(159, 34);
            BtnCancelar.TabIndex = 56;
            BtnCancelar.Text = "Cancelar Consulta";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 193);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnReagendarAgend);
            Controls.Add(BtnSalvarAgend);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Agenda";
            Text = "Agenda";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private ComboBox comboBoxPsicologo;
        private DateTimePicker dateTimePickerHora;
        private ComboBox TxtTipoatendimeto;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker DataTimeDataagendamento;
        private ComboBox comboBox1;
        private Label label1;
        private Button BtnNovoPaciente;
        private Button BtnCalendario;
        private Button BtnSalvarAgend;
        private Button BtnReagendarAgend;
        private Button BtnCancelar;
    }
}