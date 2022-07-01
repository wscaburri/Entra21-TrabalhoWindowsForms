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
        private Responsavel ObjetoResponsavel;

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
           
            
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = Convert.ToString(comboBoxTipo.SelectedItem);
            var nomeCompleto = textBoxNomeCompleto.Text;
            var cpf = maskedTextBoxCpf.Text;
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
            
            
            
            var dadosValidos = ObjetoResponsavel.ValidarCpf(cpf);
            if (dadosValidos == false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {

            }

            

        }
        private void PreecherDataGridViewComResponsaveis()
        {
            var resposanveis = responsavelServico.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < resposanveis.Count; i++)
            {
                var responsavel = resposanveis[i];

                dataGridView1.Rows.Add(new object[]
                {
                    responsavel.Codigo,
                    responsavel.Tipo,
                    responsavel.NomeCompleto,
                    responsavel.Cpf,
                    responsavel.DataNascimento,
                    responsavel.Cep,
                    responsavel.Cidade,
                    responsavel.Bairro,


                });

            }
        }
    }
}
