﻿namespace View
{
    partial class Frm_Pai
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pai));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensDeServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurídicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupexibirPainelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lbl_Nome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_NomeEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.imprimirOrdemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ordensDeServiçosToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.pessoaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.opiçõesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blocoDeNotasToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.inicioToolStripMenuItem.Text = "&Inicio";
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blocoDeNotasToolStripMenuItem.Image")));
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "&Bloco de notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculadoraToolStripMenuItem.Image")));
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculadoraToolStripMenuItem.Text = "&Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ordensDeServiçosToolStripMenuItem
            // 
            this.ordensDeServiçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaF5ToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.listarToolStripMenuItem1});
            this.ordensDeServiçosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordensDeServiçosToolStripMenuItem.Image")));
            this.ordensDeServiçosToolStripMenuItem.Name = "ordensDeServiçosToolStripMenuItem";
            this.ordensDeServiçosToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.ordensDeServiçosToolStripMenuItem.Text = "&Ordens de serviços";
            // 
            // novaF5ToolStripMenuItem
            // 
            this.novaF5ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novaF5ToolStripMenuItem.Image")));
            this.novaF5ToolStripMenuItem.Name = "novaF5ToolStripMenuItem";
            this.novaF5ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.novaF5ToolStripMenuItem.Text = "&Nova Ordem";
            this.novaF5ToolStripMenuItem.Click += new System.EventHandler(this.novaF5ToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem1.Image")));
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.editarToolStripMenuItem1.Text = "&Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listarToolStripMenuItem1.Image")));
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.listarToolStripMenuItem1.Text = "&Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarOSToolStripMenuItem,
            this.listarServiçosToolStripMenuItem});
            this.serviçoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviçoToolStripMenuItem.Image")));
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // finalizarOSToolStripMenuItem
            // 
            this.finalizarOSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("finalizarOSToolStripMenuItem.Image")));
            this.finalizarOSToolStripMenuItem.Name = "finalizarOSToolStripMenuItem";
            this.finalizarOSToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.finalizarOSToolStripMenuItem.Text = "Finalizar OS";
            this.finalizarOSToolStripMenuItem.Click += new System.EventHandler(this.finalizarOSToolStripMenuItem_Click);
            // 
            // listarServiçosToolStripMenuItem
            // 
            this.listarServiçosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarServiçosToolStripMenuItem.Image")));
            this.listarServiçosToolStripMenuItem.Name = "listarServiçosToolStripMenuItem";
            this.listarServiçosToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listarServiçosToolStripMenuItem.Text = "Listar serviços";
            this.listarServiçosToolStripMenuItem.Click += new System.EventHandler(this.listarServiçosToolStripMenuItem_Click);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.jurídicaToolStripMenuItem,
            this.listarFísicaToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.pessoaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaToolStripMenuItem.Image")));
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.pessoaToolStripMenuItem.Text = "&Pessoa";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem.Image")));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar pessoa &Física";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // jurídicaToolStripMenuItem
            // 
            this.jurídicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jurídicaToolStripMenuItem.Image")));
            this.jurídicaToolStripMenuItem.Name = "jurídicaToolStripMenuItem";
            this.jurídicaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.jurídicaToolStripMenuItem.Text = "Cadastrar pessoa &Jurídica";
            this.jurídicaToolStripMenuItem.Click += new System.EventHandler(this.jurídicaToolStripMenuItem_Click);
            // 
            // listarFísicaToolStripMenuItem
            // 
            this.listarFísicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarFísicaToolStripMenuItem.Image")));
            this.listarFísicaToolStripMenuItem.Name = "listarFísicaToolStripMenuItem";
            this.listarFísicaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.listarFísicaToolStripMenuItem.Text = "&Listar pessoas Físicas";
            this.listarFísicaToolStripMenuItem.Click += new System.EventHandler(this.listarFísicaToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarToolStripMenuItem.Image")));
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.listarToolStripMenuItem.Text = "&Listar pessoas Jurídicas";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.listarUsuáriosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.usuariosToolStripMenuItem.Text = "&Técnicos";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.editarToolStripMenuItem.Text = "&Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // listarUsuáriosToolStripMenuItem
            // 
            this.listarUsuáriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarUsuáriosToolStripMenuItem.Image")));
            this.listarUsuáriosToolStripMenuItem.Name = "listarUsuáriosToolStripMenuItem";
            this.listarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listarUsuáriosToolStripMenuItem.Text = "&Listar Técnicos";
            this.listarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.listarUsuáriosToolStripMenuItem_Click);
            // 
            // opiçõesToolStripMenuItem
            // 
            this.opiçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpresaToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.BackupexibirPainelToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.opiçõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opiçõesToolStripMenuItem.Image")));
            this.opiçõesToolStripMenuItem.Name = "opiçõesToolStripMenuItem";
            this.opiçõesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.opiçõesToolStripMenuItem.Text = "&Configurações";
            // 
            // EmpresaToolStripMenuItem
            // 
            this.EmpresaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EmpresaToolStripMenuItem.Image")));
            this.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem";
            this.EmpresaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.EmpresaToolStripMenuItem.Text = "&Empresa";
            this.EmpresaToolStripMenuItem.Click += new System.EventHandler(this.telaInicialToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailBaseToolStripMenuItem,
            this.servidorToolStripMenuItem});
            this.emailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emailToolStripMenuItem.Image")));
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.emailToolStripMenuItem.Text = "E-mail";
            // 
            // emailBaseToolStripMenuItem
            // 
            this.emailBaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emailBaseToolStripMenuItem.Image")));
            this.emailBaseToolStripMenuItem.Name = "emailBaseToolStripMenuItem";
            this.emailBaseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.emailBaseToolStripMenuItem.Text = "&E-mail Base";
            this.emailBaseToolStripMenuItem.Click += new System.EventHandler(this.emailBaseToolStripMenuItem_Click);
            // 
            // servidorToolStripMenuItem
            // 
            this.servidorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("servidorToolStripMenuItem.Image")));
            this.servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            this.servidorToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.servidorToolStripMenuItem.Text = "&Servidor";
            this.servidorToolStripMenuItem.Click += new System.EventHandler(this.servidorToolStripMenuItem_Click);
            // 
            // BackupexibirPainelToolStripMenuItem
            // 
            this.BackupexibirPainelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BackupexibirPainelToolStripMenuItem.Image")));
            this.BackupexibirPainelToolStripMenuItem.Name = "BackupexibirPainelToolStripMenuItem";
            this.BackupexibirPainelToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.BackupexibirPainelToolStripMenuItem.Text = "&Backup";
            this.BackupexibirPainelToolStripMenuItem.Click += new System.EventHandler(this.exibirPainelToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_Nome,
            this.toolStripStatusLabel2,
            this.Lbl_NomeEmpresa,
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1131, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Nome.Text = "Usuario";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // Lbl_NomeEmpresa
            // 
            this.Lbl_NomeEmpresa.Name = "Lbl_NomeEmpresa";
            this.Lbl_NomeEmpresa.Size = new System.Drawing.Size(107, 17);
            this.Lbl_NomeEmpresa.Text = "Nome  da empresa";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirOrdemDeServiçoToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "Print_OS";
            // 
            // imprimirOrdemDeServiçoToolStripMenuItem
            // 
            this.imprimirOrdemDeServiçoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirOrdemDeServiçoToolStripMenuItem.Image")));
            this.imprimirOrdemDeServiçoToolStripMenuItem.Name = "imprimirOrdemDeServiçoToolStripMenuItem";
            this.imprimirOrdemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.imprimirOrdemDeServiçoToolStripMenuItem.Text = "Imprimir Ordem de serviço";
            this.imprimirOrdemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.imprimirOrdemDeServiçoToolStripMenuItem_Click);
            // 
            // Frm_Pai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1131, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Frm_Pai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Pai_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Pai_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Pai_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensDeServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurídicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackupexibirPainelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFísicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Nome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_NomeEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem imprimirOrdemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidorToolStripMenuItem;
    }
}



