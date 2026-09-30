namespace Agendamento
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            toolStripMenu = new ToolStrip();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCadpacientes = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnAgenda = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            BtnCadaluno = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            BtnCadSala = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            BtnCadprofturma = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            Btncadusuarios = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnLogout = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            BtnSair = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            BtnBackup = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            txtUsuariologado = new TextBox();
            toolStripMenu.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenu
            // 
            toolStripMenu.BackColor = Color.Transparent;
            toolStripMenu.Dock = DockStyle.Left;
            toolStripMenu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenu.ImageScalingSize = new Size(60, 60);
            toolStripMenu.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, btnCadpacientes, toolStripSeparator3, btnAgenda, toolStripSeparator9, BtnCadaluno, toolStripSeparator8, BtnCadSala, toolStripSeparator7, BtnCadprofturma, toolStripSeparator4, Btncadusuarios, toolStripSeparator6, btnLogout, toolStripSeparator5, BtnSair, toolStripSeparator10, BtnBackup, toolStripSeparator1 });
            toolStripMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStripMenu.Location = new Point(0, 0);
            toolStripMenu.Name = "toolStripMenu";
            toolStripMenu.RenderMode = ToolStripRenderMode.System;
            toolStripMenu.Size = new Size(149, 833);
            toolStripMenu.TabIndex = 0;
            toolStripMenu.Text = "Menu";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(146, 6);
            // 
            // btnCadpacientes
            // 
            btnCadpacientes.BackColor = Color.Transparent;
            btnCadpacientes.BackgroundImageLayout = ImageLayout.None;
            btnCadpacientes.Image = (Image)resources.GetObject("btnCadpacientes.Image");
            btnCadpacientes.ImageTransparentColor = Color.Magenta;
            btnCadpacientes.Name = "btnCadpacientes";
            btnCadpacientes.Size = new Size(146, 80);
            btnCadpacientes.Text = "Cadastro de Pacientes";
            btnCadpacientes.TextAlign = ContentAlignment.BottomCenter;
            btnCadpacientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(146, 6);
            // 
            // btnAgenda
            // 
            btnAgenda.Image = (Image)resources.GetObject("btnAgenda.Image");
            btnAgenda.ImageTransparentColor = Color.Magenta;
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(146, 80);
            btnAgenda.Text = "Agenda";
            btnAgenda.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(146, 6);
            // 
            // BtnCadaluno
            // 
            BtnCadaluno.Image = (Image)resources.GetObject("BtnCadaluno.Image");
            BtnCadaluno.ImageTransparentColor = Color.Magenta;
            BtnCadaluno.Name = "BtnCadaluno";
            BtnCadaluno.Size = new Size(146, 80);
            BtnCadaluno.Text = "Cadastro de Alunos";
            BtnCadaluno.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(146, 6);
            // 
            // BtnCadSala
            // 
            BtnCadSala.Image = (Image)resources.GetObject("BtnCadSala.Image");
            BtnCadSala.ImageTransparentColor = Color.Magenta;
            BtnCadSala.Name = "BtnCadSala";
            BtnCadSala.Size = new Size(146, 80);
            BtnCadSala.Text = "Cadastro de Salas";
            BtnCadSala.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(146, 6);
            // 
            // BtnCadprofturma
            // 
            BtnCadprofturma.Image = (Image)resources.GetObject("BtnCadprofturma.Image");
            BtnCadprofturma.ImageTransparentColor = Color.Magenta;
            BtnCadprofturma.Name = "BtnCadprofturma";
            BtnCadprofturma.Size = new Size(146, 80);
            BtnCadprofturma.Text = "Cad. Prof. e Turmas";
            BtnCadprofturma.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(146, 6);
            // 
            // Btncadusuarios
            // 
            Btncadusuarios.Image = (Image)resources.GetObject("Btncadusuarios.Image");
            Btncadusuarios.ImageTransparentColor = Color.Magenta;
            Btncadusuarios.Name = "Btncadusuarios";
            Btncadusuarios.Size = new Size(146, 80);
            Btncadusuarios.Text = "Cadastro de Usuários";
            Btncadusuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(146, 6);
            // 
            // btnLogout
            // 
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageTransparentColor = Color.Magenta;
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 80);
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(146, 6);
            // 
            // BtnSair
            // 
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.ImageTransparentColor = Color.Magenta;
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(146, 80);
            BtnSair.Text = "Sair";
            BtnSair.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(146, 6);
            // 
            // BtnBackup
            // 
            BtnBackup.Image = (Image)resources.GetObject("BtnBackup.Image");
            BtnBackup.ImageTransparentColor = Color.Magenta;
            BtnBackup.Name = "BtnBackup";
            BtnBackup.Size = new Size(146, 80);
            BtnBackup.Text = "Backup";
            BtnBackup.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(146, 6);
            // 
            // txtUsuariologado
            // 
            txtUsuariologado.BackColor = SystemColors.Control;
            txtUsuariologado.Enabled = false;
            txtUsuariologado.Location = new Point(181, 12);
            txtUsuariologado.Name = "txtUsuariologado";
            txtUsuariologado.Size = new Size(100, 22);
            txtUsuariologado.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1238, 833);
            Controls.Add(txtUsuariologado);
            Controls.Add(toolStripMenu);
            Cursor = Cursors.Hand;
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            toolStripMenu.ResumeLayout(false);
            toolStripMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMenu;
        private ToolStripButton btnCadpacientes;
        private ToolStripButton btnAgenda;
        private ToolStripButton BtnCadaluno;
        private ToolStripButton BtnCadSala;
        private ToolStripButton Btncadusuarios;
        private ToolStripButton btnLogout;
        private ToolStripButton BtnSair;
        private ToolStripButton BtnBackup;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnCadprofturma;
        private ToolStripSeparator toolStripSeparator10;
        private TextBox txtUsuariologado;
    }
}