﻿using System;
using System.Windows.Forms;
using Model.Ordem_de_Servico;
using Controller;
using Model.Pessoa_e_Usuario;
using Model;

namespace View
{
    public partial class Frm_Servico : Form
    {
        public Frm_Servico()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finalizando Ordem de serviço (Botão).
        /// </summary>
        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_OS.Text))
            {
                OrdemServico OSbase = new OrdemServico();
                Servico ServicoBase = new Servico();

                ControllerOrdemServico controllerOS = new ControllerOrdemServico();
                ControllerServico controllerServico = new ControllerServico();
                ControllerEmail controllerEmail = new ControllerEmail();

                bool Resultado = false;

                if (controllerOS.Verificar(Txt_OS.Text))//Verifica se a OS existe ou não
                {
                    Resultado = controllerOS.FinalizarOS(Txt_OS.Text);

                    if (Resultado)
                    {
                        MessageBox.Show("Ordem de serviço Finalizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao finalizar sua Ordem de serviço, informações foram salvas no arquivo log no diretorio do sue software", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //Gerando o serviço
                    controllerServico.Save(Txt_Descricao.Text, double.Parse(Txt_Valor.Text), Txt_OS.Text);


                    if (MessageBox.Show("Enviar E-mail para o cliente informando sobre o término do serviço?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Model.Email EmailBase = new Model.Email();

                        //Decodificando Email Base para enviar!
                        String EmailDecoficado = controllerEmail.DecodificarEmailBase(RecuperandoEmailBase(), NomeEmpresa(), InformacaoCliente()[0]);

                        string ResultadoEnvio = controllerEmail.Enviar(InformacaoCliente()[0], InformacaoCliente()[1], NomeEmpresa(), EmailDecoficado);

                        MessageBox.Show(ResultadoEnvio, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe o numero da ordem de serviço!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Recuperando informações do cliente.
        /// </summary>
        /// <returns>Nome e E-mail do cliente</returns>
        private string[] InformacaoCliente()
        {
            OrdemServico OSBase = new OrdemServico();
            Fisica PessoaFisicaBase = new Fisica();
            Juridica PessoaJuridicaBase = new Juridica();


            ControllerOrdemServico controllerOS = new ControllerOrdemServico();
            ControllerFisica controllerPF = new ControllerFisica();
            ControllerJuridica controllerPJ = new ControllerJuridica();

            string NomeDoCliente = "Não Econtrado";
            string EmailCliente = "Não encontrado";
            string[] Informacoes = new string[2];

            NomeDoCliente = controllerOS.LoadOSFinalizada(Txt_OS.Text).Cliente;

            //TODO:Arrumar para verificar o tipo de pessoa

            //Verificando o tipo e o Email do usuario


            if (true) //Verifica se é PessoaFisica
            {
                EmailCliente = controllerPF.Load(NomeDoCliente).Email;
                NomeDoCliente = controllerPF.Load(NomeDoCliente).Nome;

                Informacoes[0] = NomeDoCliente;
                Informacoes[1] = EmailCliente;
            }
            else if (controllerPJ.Verificar(NomeDoCliente)) //Verifica se é pessoa Juridica
            {
                PessoaJuridicaBase = controllerPJ.Load(NomeDoCliente);
                EmailCliente = PessoaFisicaBase.Email;
                NomeDoCliente = PessoaFisicaBase.Nome;

                Informacoes[0] = NomeDoCliente;
                Informacoes[1] = EmailCliente;
            }

            return Informacoes;
        }

        /// <summary>
        /// Recuperando informações da empresa
        /// </summary>
        /// <returns>Nome da empresa</returns>
        private string NomeEmpresa()
        {

            Empresa EmpresaBase = new Empresa();
            ControllerEmpresa controllerEmpresa = new ControllerEmpresa();

            string NomeEmpresa = "Não encontrado";

            NomeEmpresa = controllerEmpresa.Load().Nome;

            return NomeEmpresa;
        }

        /// <summary>
        /// Recuperando E-mail base;
        /// </summary>
        /// <returns>Texto do E-mail base ainda codificado.</returns>
        private string RecuperandoEmailBase()
        {
            Email Email = new Email();
            ControllerEmail controllerEmail = new ControllerEmail();

            string TextoEmail = "Não encontrado";

            TextoEmail = controllerEmail.LoadEmailBase();

            return TextoEmail;
        }
    }
}
