namespace Entra21_TrabalhoWindowsForms
{
    public partial class MedicamentosForm : Form
    {
        private MedicamentosServico medicamentosServico;

        public MedicamentosForm()
        {
            InitializeComponent();

            medicamentosServico = new MedicamentosServico();

            PreencherDataGridViewComMedicamentos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeMedicamento.Text.Trim();
            var tipo = Convert.ToString(comboBoxTipoMedicamento.SelectedItem);
            var forma = Convert.ToString(SelecionarFormaMedicamento());
            var recomendacao = Convert.ToString(VerificarRecomendacaoSelecionada());
            var dataCadastro = dateTimePickerDataCadastro.Value;

            var dadosValidos = ValidarDados(nome, tipo, forma, recomendacao, dataCadastro);

            if (dadosValidos == false)
                return;

            if (dataGridViewMedicamentos.SelectedRows.Count == 0)
                CadastrarMedicamento(nome, tipo, forma, recomendacao, dataCadastro);
            else
                EditarMedicamento(nome, tipo, forma, recomendacao, dataCadastro);

            PreencherDataGridViewComMedicamentos();

            LimparCampos();
        }

        private void CadastrarMedicamento(string nome, string tipo, string forma, string recomendacao, DateTime dataCadastro)
        {
            var medicamentos = new Medicamentos();

            medicamentos.Codigo = medicamentosServico.ObterUltimoCodigo() + 1;
            medicamentos.Nome = nome;
            medicamentos.Tipo = tipo;
            medicamentos.Forma = forma;
            medicamentos.Recomendacao = recomendacao;
            medicamentos.DataCadastro = dataCadastro;

            medicamentosServico.Adicionar(medicamentos);
        }

        public void EditarMedicamento(string nome, string tipo, string forma, string recomendacao, DateTime dataCadastro)
        {
            var linhaSelecionada = dataGridViewMedicamentos.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var medicamento = new Medicamentos();

            medicamento.Codigo = codigoSelecionado;
            medicamento.Nome = nome;
            medicamento.Tipo = tipo;
            medicamento.Forma = forma;
            medicamento.Recomendacao = recomendacao;
            medicamento.DataCadastro = dataCadastro;

            medicamentosServico.Editar(medicamento);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEditar();
        }

        private void ApresentarDadosParaEditar()
        {
            if (dataGridViewMedicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um medicamento para editar!");

                return;
            }

            var linhaSelecionada = dataGridViewMedicamentos.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var medicamento = medicamentosServico.ObterPorCodigo(codigo);

            textBoxNomeMedicamento.Text = medicamento.Nome;
            comboBoxTipoMedicamento.SelectedItem = medicamento.Tipo;
            dateTimePickerDataCadastro.Text = Convert.ToString(medicamento.DataCadastro);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um medicamento para apagar!");

                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar o medicamento?", "AVISO",
                MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Operação cancelada. O medicamento continua salvo!");

                return;
            }

            var linhaSelecionada = dataGridViewMedicamentos.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var medicamento = medicamentosServico.ObterPorCodigo(codigo);

            medicamentosServico.Apagar(medicamento);

            PreencherDataGridViewComMedicamentos();

            dataGridViewMedicamentos.ClearSelection();
        }

        public void LimparCampos()
        {
            textBoxNomeMedicamento.Text = string.Empty;
            comboBoxTipoMedicamento.SelectedIndex = -1;
            radioButtonComprimido.Checked = false;
            radioButtonLiquida.Checked = false;
            radioButtonVacina.Checked = false;
            checkBoxCaes.Checked = false;
            checkBoxGatos.Checked = false;
            dateTimePickerDataCadastro.ResetText();
            dataGridViewMedicamentos.ClearSelection();
        }

        private void PreencherDataGridViewComMedicamentos()
        {
            var medicamentos = medicamentosServico.ObterTodos();

            dataGridViewMedicamentos.Rows.Clear();

            for (var i = 0; i < medicamentos.Count; i++)
            {
                var medicamento = medicamentos[i];

                dataGridViewMedicamentos.Rows.Add(new object[]
                {
                        medicamento.Codigo,
                        medicamento.Nome,
                        medicamento.Tipo,
                        medicamento.Forma,
                        medicamento.Recomendacao,
                        medicamento.DataCadastro.ToString("dd/MM/yyyy")
                });
            }

            dataGridViewMedicamentos.ClearSelection();
        }

        private string SelecionarFormaMedicamento()
        {
            var formaComprimido = "";

            if (radioButtonComprimido.Checked == true)
                formaComprimido = "Comprimido";

            if (radioButtonLiquida.Checked == true)
                formaComprimido = "Liquida";

            if (radioButtonVacina.Checked == true)
                formaComprimido = "Vacina";

            return formaComprimido;
        }

        private string VerificarRecomendacaoSelecionada()
        {
            var recomendacao = "";

            if (checkBoxCaes.Checked == true && checkBoxGatos.Checked == true)
                recomendacao = "Cães e Gatos";
            else if (checkBoxCaes.Checked == true && checkBoxGatos.Checked == false)
                recomendacao = "Cães";
            else if (checkBoxCaes.Checked == false && checkBoxGatos.Checked == true)
                recomendacao = "Gatos";

            return recomendacao;
        }

        private bool ValidarDados(string nome, string tipo, string forma, string recomendacao, DateTime dataCadastro)
        {
            if (nome.Trim().Length < 3)
            {
                MessageBox.Show("Nome do medicamento inválido.");

                textBoxNomeMedicamento.Focus();

                return false;
            }

            if (comboBoxTipoMedicamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo do medicamento.");

                comboBoxTipoMedicamento.DroppedDown = true;

                return false;
            }

            if (radioButtonComprimido.Checked == false && radioButtonLiquida.Checked == false && radioButtonVacina.Checked == false)
            {
                MessageBox.Show("Selecione a forma do medicamento.");

                return false;
            }

            if (checkBoxCaes.Checked == false && checkBoxGatos.Checked == false)
            {
                MessageBox.Show("Selecione a recomendação do medicamento.");

                return false;
            }

            if (dataCadastro > DateTime.Now)
            {
                MessageBox.Show("Data de cadastro não pode ser maior do que a atual");

                dateTimePickerDataCadastro.Focus();

                return false;
            }

            return true;
        }

        private void MedicamentosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComMedicamentos();
        }
    }
}