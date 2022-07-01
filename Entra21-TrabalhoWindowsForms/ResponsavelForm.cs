using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21_TrabalhoWindowsForms
{
    public partial class ResponsavelForm : Form
    {
        private ResponsavelServico responsavelServico;
        private AnimalServico animalServico;
        private Validacoes validacoes;
        private EditarResponsavelForm editarResponsavel;

        public ResponsavelForm()
        {
            InitializeComponent();

            responsavelServico = new ResponsavelServico();

            PreencherComboBoxComNomeAnimais();
        }

        private void PreencherComboBoxComNomeAnimais()
        {
            var responsavel = animalServico.ObterTodos();


        }
        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            maskedTextBoxCpf.Text = "";
            maskedTextBoxRg.Text = "";
            
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = Convert.ToString(comboBoxTipo.SelectedItem);
            var nomeCompleto = textBoxNomeCompleto.Text;
            var cpf = maskedTextBoxCpf.Text;
            var rg = maskedTextBoxRg.Text;
            var dataNascimento = Convert.ToString(dateTimePickerDataCadastro.Text);
            var cep = maskedTextBoxCep.Text;
            var cidade = Convert.ToString(comboBoxCidade.SelectedItem);
            var bairro = textBoxBairro.Text;
            var endereco = textBoxEndereco.Text;
            var numero = textBoxNumero.Text;
            var complemento = textBoxComplemento.Text;
            var localDeTrabalho = textBoxLocalDeTrabalho.Text;
            var observacao = textBoxObservacaoLocalDeTrabalho;
            var dataDeCadastro = Convert.ToString(dateTimePickerDataCadastro.Text);
            var nomePet = comboBoxNomePet.Text;
            var telefone = maskedTextBoxTelefone.Text;
            var celular = maskedTextBoxCelular.Text;
            var email = textBoxEmail.Text;
            
            
            
            var dadosValidos = validacoes.ValidarCpf(cpf);
            if (dadosValidos == false)
            {
                return;
            }

            

            

        }
    }
}
