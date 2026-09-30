namespace Agendamento
{
    partial class FrmCalendario
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
            PanelFiltro = new Panel();
            checkBoxVerDia = new CheckBox();
            label12 = new Label();
            comboBoxfiltropsicologo = new ComboBox();
            BtnCancelar = new Button();
            lblMesSelecionado = new Label();
            dateTimePickerHora = new DateTimePicker();
            BtnAgendarReagendar = new Button();
            label3 = new Label();
            DataTimeDataagendamento = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            BtnPesquisar = new Button();
            comboBoxStatusAgendamento = new ComboBox();
            textBoxNomecli = new TextBox();
            monthCalendar1 = new MonthCalendar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PanelFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // PanelFiltro
            // 
            PanelFiltro.BackColor = Color.LightSteelBlue;
            PanelFiltro.BorderStyle = BorderStyle.FixedSingle;
            PanelFiltro.Controls.Add(checkBoxVerDia);
            PanelFiltro.Controls.Add(BtnAgendarReagendar);
            PanelFiltro.Controls.Add(label12);
            PanelFiltro.Controls.Add(comboBoxfiltropsicologo);
            PanelFiltro.Controls.Add(BtnCancelar);
            PanelFiltro.Controls.Add(lblMesSelecionado);
            PanelFiltro.Controls.Add(dateTimePickerHora);
            PanelFiltro.Controls.Add(label3);
            PanelFiltro.Controls.Add(DataTimeDataagendamento);
            PanelFiltro.Controls.Add(label2);
            PanelFiltro.Controls.Add(label1);
            PanelFiltro.Controls.Add(BtnPesquisar);
            PanelFiltro.Controls.Add(comboBoxStatusAgendamento);
            PanelFiltro.Controls.Add(textBoxNomecli);
            PanelFiltro.Controls.Add(monthCalendar1);
            PanelFiltro.Location = new Point(2, 2);
            PanelFiltro.Name = "PanelFiltro";
            PanelFiltro.Size = new Size(288, 486);
            PanelFiltro.TabIndex = 1;
            // 
            // checkBoxVerDia
            // 
            checkBoxVerDia.AutoSize = true;
            checkBoxVerDia.BackColor = Color.Transparent;
            checkBoxVerDia.ForeColor = Color.Black;
            checkBoxVerDia.Location = new Point(149, 238);
            checkBoxVerDia.Name = "checkBoxVerDia";
            checkBoxVerDia.Size = new Size(129, 20);
            checkBoxVerDia.TabIndex = 55;
            checkBoxVerDia.Text = "Ver apenas o dia";
            checkBoxVerDia.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(159, 112);
            label12.Name = "label12";
            label12.Size = new Size(71, 16);
            label12.TabIndex = 54;
            label12.Text = "Psicologo:";
            // 
            // comboBoxfiltropsicologo
            // 
            comboBoxfiltropsicologo.FormattingEnabled = true;
            comboBoxfiltropsicologo.Location = new Point(157, 131);
            comboBoxfiltropsicologo.Name = "comboBoxfiltropsicologo";
            comboBoxfiltropsicologo.Size = new Size(121, 24);
            comboBoxfiltropsicologo.TabIndex = 52;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(184, 175);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 32);
            BtnCancelar.TabIndex = 49;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblMesSelecionado
            // 
            lblMesSelecionado.AutoSize = true;
            lblMesSelecionado.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMesSelecionado.ForeColor = Color.Black;
            lblMesSelecionado.Location = new Point(3, 232);
            lblMesSelecionado.Name = "lblMesSelecionado";
            lblMesSelecionado.Size = new Size(70, 25);
            lblMesSelecionado.TabIndex = 2;
            lblMesSelecionado.Text = "label4";
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(177, 78);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.Size = new Size(101, 22);
            dateTimePickerHora.TabIndex = 48;
            // 
            // BtnAgendarReagendar
            // 
            BtnAgendarReagendar.Location = new Point(3, 175);
            BtnAgendarReagendar.Name = "BtnAgendarReagendar";
            BtnAgendarReagendar.Size = new Size(151, 32);
            BtnAgendarReagendar.TabIndex = 9;
            BtnAgendarReagendar.Text = "Agendar/Reagendar";
            BtnAgendarReagendar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 59);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 8;
            label3.Text = "Data e hora:";
            label3.Click += label3_Click;
            // 
            // DataTimeDataagendamento
            // 
            DataTimeDataagendamento.Format = DateTimePickerFormat.Short;
            DataTimeDataagendamento.Location = new Point(3, 78);
            DataTimeDataagendamento.Name = "DataTimeDataagendamento";
            DataTimeDataagendamento.Size = new Size(126, 22);
            DataTimeDataagendamento.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(135, 16);
            label2.TabIndex = 6;
            label2.Text = "Status Agendamento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(121, 16);
            label1.TabIndex = 5;
            label1.Text = "Nome do paciente:";
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(182, 450);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(96, 31);
            BtnPesquisar.TabIndex = 3;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatusAgendamento
            // 
            comboBoxStatusAgendamento.FormattingEnabled = true;
            comboBoxStatusAgendamento.Location = new Point(3, 131);
            comboBoxStatusAgendamento.Name = "comboBoxStatusAgendamento";
            comboBoxStatusAgendamento.Size = new Size(121, 24);
            comboBoxStatusAgendamento.TabIndex = 2;
            // 
            // textBoxNomecli
            // 
            textBoxNomecli.Location = new Point(3, 24);
            textBoxNomecli.Name = "textBoxNomecli";
            textBoxNomecli.Size = new Size(275, 22);
            textBoxNomecli.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(34, 270);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Location = new Point(296, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(845, 486);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // FrmCalendario
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 496);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(PanelFiltro);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmCalendario";
            Text = "FrmCalendario";
            PanelFiltro.ResumeLayout(false);
            PanelFiltro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelFiltro;
        private CheckBox checkBoxVerDia;
        private Label label12;
        private ComboBox comboBoxfiltropsicologo;
        private Button BtnCancelar;
        private Label lblMesSelecionado;
        private DateTimePicker dateTimePickerHora;
        private Label label3;
        private DateTimePicker DataTimeDataagendamento;
        private Label label2;
        private Label label1;
        private Button BtnPesquisar;
        private ComboBox comboBoxStatusAgendamento;
        private TextBox textBoxNomecli;
        private MonthCalendar monthCalendar1;
        private Button BtnAgendarReagendar;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}