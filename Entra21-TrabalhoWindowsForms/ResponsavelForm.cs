using Newtonsoft.Json;

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

            //PreencherComboBoxComNomeAnimais();

            ObterDadosCep();
        }

        /*private void PreencherComboBoxComNomeAnimais()
        {
            var responsavel = animalServico.ObterTodos();
        }*/

        private void LimparCampos()
        {
            var dataAtual = DateTime.Now;
            textBoxNomeCompleto.Text = "";
            textBoxEndereco.Text = "";
            textBoxBairro.Text = "";
            comboBoxCidade.SelectedIndex = -1;
            textBoxNumero.Text = "";
            textBoxComplemento.Text = "";
            textBoxLocalDeTrabalho.Text = "";
            textBoxObservacaoLocalDeTrabalho.Text = "";
            textBoxEmail.Text = "";
            dateTimePickerDataCadastro.Value = dataAtual;
            maskedTextBoxCep.Text = "";
            maskedTextBoxCelular.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxCpf.Text = "";
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        public void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um responsável para editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var responsavel = responsavelServico.ObterPorCodigo(codigo);

            maskedTextBoxCep.Text = responsavel.Cep;
            textBoxEndereco.Text = responsavel.Endereco;
            comboBoxNomePet.SelectedItem = responsavel.Pet.Nome;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = Convert.ToString(comboBoxTipo.SelectedItem);
            var nomeCompleto = textBoxNomeCompleto.Text;
            var cpf = maskedTextBoxCpf.Text;
            var dataNascimento = Convert.ToString(dateTimePickerDataCadastro.Value);
            var cep = maskedTextBoxCep.Text;
            var cidade = Convert.ToString(comboBoxCidade.SelectedItem);
            var bairro = textBoxBairro.Text;
            var endereco = textBoxEndereco.Text;
            var numeroResidencia = textBoxNumero.Text;
            var complemento = textBoxComplemento.Text;
            var localDeTrabalho = textBoxLocalDeTrabalho.Text;
            var observacao = textBoxObservacaoLocalDeTrabalho;
            var dataDeCadastro = Convert.ToString(dateTimePickerDataCadastro.Value);
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
                CadastrarResponsavel(nomeCompleto, tipo, cpf, dataNascimento, dataDeCadastro,
              cep, cidade, bairro, endereco,
              numeroResidencia, complemento,
              localDeTrabalho, telefone, celular, email, nomePet);
            else
                EditarResponsavel(nomeCompleto, tipo, cpf, dataNascimento,
             cep, cidade, bairro, endereco,
             numeroResidencia, complemento,
             localDeTrabalho, telefone, celular, email, nomePet);
        }

        private void EditarResponsavel(string nomeCompleto, string tipo, string cpf, string dataNascimento,
            string cep, string cidade, string bairro, string endereco,
            string numeroResidencia, string complemento,
            string localDeTrabalho, string telefone, string celular, string email, string nomeAnimal)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var responsavel = new Responsavel();
            responsavel.Codigo = codigoSelecionado;
            responsavel.NomeCompleto = nomeCompleto;
            responsavel.DataNascimento = Convert.ToDateTime(dataNascimento);
            responsavel.Tipo = tipo;
            responsavel.Cpf = cpf;
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
            responsavel.Pet = animalServico.ObterPorNomeAnimal(nomeAnimal);

            responsavelServico.Editar(responsavel);
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

        public void CadastrarResponsavel(string nomeCompleto, string tipo, string cpf, string dataNascimento,
            string cep, string cidade, string bairro, string endereco,
            string numeroResidencia, string complemento,
            string localDeTrabalho, string telefone, string celular, string email, string nomeAnimal, string dataCadastro)
        {
            var responsavel = new Responsavel();
            responsavel.Codigo = responsavelServico.ObterPorUltimoCodigo() + 1;
            responsavel.NomeCompleto = nomeCompleto;
            responsavel.Tipo = tipo;
            responsavel.Cpf = cpf;
            responsavel.DataNascimento = Convert.ToDateTime(dataNascimento);
            responsavel.DataDeCadastro = Convert.ToDateTime(dataCadastro);
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
            responsavel.Pet = animalServico.ObterPorNomeAnimal(nomeAnimal);

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

        public bool ValidarDados(string nomeCompleto, string cpf,
            string cep, string cidade, string bairro, string enderecoCompleto,
            string numeroResidencia, string localDeTrabalho, string telefone, string celular)
        {
            if (Resp.ValidarCpf(cpf) == false)
            {
                MessageBox.Show("CPF inválido");

                maskedTextBoxCpf.Focus();
                return false;
            }

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
            if (comboBoxTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha o tipo de pessoa");

                comboBoxTipo.DroppedDown = true;
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
            var dataAtual = DateTime.Now;
            if (dateTimePickerDataNascimento.Value == dataAtual)
            {
                MessageBox.Show("Preencha a data de nascimento");
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }

            var reposta = MessageBox.Show("Deseja realmente apagar o endereço?", "Aviso",
                MessageBoxButtons.YesNo);

            if (reposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa seu registro continua salvo");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var responsavel = responsavelServico.ObterPorCodigo(codigo);

            responsavelServico.Apagar(responsavel);

            PreecherDataGridViewComResponsaveis();

            dataGridView1.ClearSelection();
        }
    }
}