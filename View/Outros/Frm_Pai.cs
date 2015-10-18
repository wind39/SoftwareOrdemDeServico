﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace View
{
    public partial class Frm_Pai : Form
    {


        public Frm_Pai()
        {
            InitializeComponent();
        }

        string Usuario;
        string NivelAcesso;

        public Frm_Pai(string usuario, string nivelAcesso)
        {
            InitializeComponent();

            Usuario = usuario;
            NivelAcesso = nivelAcesso;

            if (nivelAcesso == "Usuario" || nivelAcesso == "usuario")
            {
                //Desativando algumas informações que o usario não pode usar.

                usuariosToolStripMenuItem.Visible = false;
                produtosToolStripMenuItem.Visible = false;

                EmpresaToolStripMenuItem.Enabled = false;
                BackupexibirPainelToolStripMenuItem.Enabled = false;
            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Frm_Pai_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios_Usuarios.Frm_NewUsu Frm_NewUso = new Formularios_Usuarios.Frm_NewUsu();

            Frm_NewUso.MdiParent = this;

            Frm_NewUso.Show();
        }

        private void novaF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OS.Frm_NewOrdem Frm_NewOrdem = new OS.Frm_NewOrdem();

            Frm_NewOrdem.MdiParent = this;

            Frm_NewOrdem.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OS.Frm_EditarOS Frm_Editar = new OS.Frm_EditarOS();

            Frm_Editar.MdiParent = this;

            Frm_Editar.Show();


        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoas.Frm_PessoaFisica Pessoa = new Pessoas.Frm_PessoaFisica();

            Pessoa.MdiParent = this;

            Pessoa.Show();
        }

        private void jurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoas.Frm_PessoaJuridica Pessoa = new Pessoas.Frm_PessoaJuridica();

            Pessoa.MdiParent = this;

            Pessoa.Show();
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opicoes.Frm_OpicoesInicial Tela_Inicial = new Opicoes.Frm_OpicoesInicial();

            Tela_Inicial.MdiParent = this;

            Tela_Inicial.Show();
        }

        private void Frm_Pai_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = null;
            try
            {
                sr = new System.IO.StreamReader("Empresa.CFG");

                Lbl_NomeEmpresa.Text = sr.ReadLine();

                Lbl_Nome.Text = Usuario;
            }
            catch (Exception exc)
            {
                Arquivos.ArquivoLog Log = new Arquivos.ArquivoLog();
                Log.ArquivoExceptionLog(exc);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outros.Frm_Sobre Sobre = new Outros.Frm_Sobre();

            Sobre.MdiParent = this;

            Sobre.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OS.Frm_ListarOS Frm_ListarOS = new OS.Frm_ListarOS();

            Frm_ListarOS.MdiParent = this;

            Frm_ListarOS.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoas.Frm_ListarJuridica Frm_ListarJuridica = new Pessoas.Frm_ListarJuridica();

            Frm_ListarJuridica.MdiParent = this;

            Frm_ListarJuridica.Show();
        }

        private void listarFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoas.Frm_ListarFisica Frm_ListarFisica = new Pessoas.Frm_ListarFisica();

            Frm_ListarFisica.MdiParent = this;

            Frm_ListarFisica.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad");
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Usuario.Frm_EditUsu frm_EdiUso = new View.Usuario.Frm_EditUsu();

            frm_EdiUso.MdiParent = this;

            frm_EdiUso.Show();
        }

        private void Frm_Pai_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void exibirPainelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Backup frm_Backup = new Frm_Backup();

            frm_Backup.MdiParent = this;

            frm_Backup.Show();
        }

        private void Frm_Pai_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void imprimirOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ImprimirOS frm_ImprimirOS = new Frm_ImprimirOS();

            frm_ImprimirOS.MdiParent = this;

            frm_ImprimirOS.Show();
        }

        private void criarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NovoProduto frm_NewProduto = new Frm_NovoProduto();

            frm_NewProduto.MdiParent = this;

            frm_NewProduto.Show();
        }

        private void listarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListaProdutos frm_ListarProdutos = new Frm_ListaProdutos();

            frm_ListarProdutos.MdiParent = this;

            frm_ListarProdutos.Show();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EditarProduto frm_EditarProduto = new Frm_EditarProduto();

            frm_EditarProduto.MdiParent = this;

            frm_EditarProduto.Show();
        }
    }
}
