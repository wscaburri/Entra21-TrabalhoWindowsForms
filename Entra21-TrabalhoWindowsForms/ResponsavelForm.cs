using Newtonsoft.Json;
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
        private Responsavel Resp;

        public ResponsavelForm()
        {
            InitializeComponent();

            responsavelServico = new ResponsavelServico();

            PreecherDataGridViewComResponsaveis();

            PreencherComboBoxComNomeAnimais();

            ObterDadosCep();
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
            var linha selecionada =
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



            var dadosValidos = Resp.ValidarCpf(cpf);
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
                    responsavel.NomeCompleto,
                    responsavel.Cpf,
                    responsavel.DataNascimento,

                });

            }
            dataGridView1.Rows.Clear();
        }

        public void CadastrarResponsavel(string nomeCompleto, string tipo, string cpf, DateTime dataNascimento,
            string cep, string cidade, string bairro, string endereco,
            string numeroResidencia, string complemento,
            string localDeTrabalho, string telefone, string celular, string email, int codigoAnimal)
        {
            var responsavel = new Responsavel();
            responsavel.Codigo = responsavelServico.ObterPorUltimoCodigo() + 1;
            responsavel.NomeCompleto = nomeCompleto;
            responsavel.Tipo = tipo;
            responsavel.Cpf = cpf;
            responsavel.DataNascimento = dataNascimento;
            responsavel.Cep = cep;
            responsavel.Cidade = cidade;
            responsavel.Bairro = bairro;
            responsavel.Endereco = endereco;
            responsavel.NumeroResidencia = numeroResidencia;
            responsavel.Complemento = complemento;
            responsavel.LocalDeTrabalho = localDeTrabalho;
            responsavel.Telefone = telefone;
            responsavel.Celular = celular;
            responsavel.Email = email;
            responsavel.Pet = animalServico.ObterPorCodigo(codigoAnimal);

            responsavelServico.Adicionar(responsavel);

        }
        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                return;
            }

            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
               
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosResponsavel = JsonConvert.DeserializeObject<ResponsavelDadosRequisicao>(resposta);

                maskedTextBoxCep.Text = $"{dadosResponsavel.Cep}";
                textBoxEndereco.Text = $" - {dadosResponsavel.Logradouro}";
                comboBoxCidade.Text = $"{dadosResponsavel.Localidade}";
                textBoxBairro.Text = $"{dadosResponsavel.Bairro}";

            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }
        private void textBoxEndereco_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }
        public bool ValidarDados(string nomeCompleto, string tipo, string cpf, DateTime dataNascimento,
            string cep, string cidade, string bairro, string enderecoCompleto,
            string numeroResidencia, string complemento,
            string localDeTrabalho, string telefone, string celular)
        {
            Resp.ValidarCpf(cpf);

            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("Cep inválido");

                maskedTextBoxCep.Focus();

                return false;
            }
            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve conter no mínimo 10 caracteres");

                textBoxEndereco.Focus();

                return false;
            }
            if (bairro.Trim().Length < 2)
            {
                MessageBox.Show("Bairro deve conter no mínimo 2 caracteres");

                textBoxBairro.Focus();
            }
            if (comboBoxCidade.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma cidade");

                comboBoxCidade.DroppedDown = true;

                return false;
            }
            if (comboBoxNomePet.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um animal");

                comboBoxNomePet.DroppedDown = true;

                return false;
            }
            return true;
        }

    }
}
