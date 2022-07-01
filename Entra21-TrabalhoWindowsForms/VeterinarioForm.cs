namespace Entra21_TrabalhoWindowsForms
{
    public partial class VeterinarioForm : Form
    {
        private VeterinarioServico veterinarioServico;

        public VeterinarioForm()
        {
            InitializeComponent();

            veterinarioServico = new VeterinarioServico();

            PreencherDataGridViewComVeterinarios();
        }

        private void PreencherDataGridViewComVeterinarios()
        {
            var veterinarios = veterinarioServico.ObterTodos();

            dataGridViewVeterinarios.Rows.Clear();

            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                dataGridViewVeterinarios.Rows.Add(new object[]
                {
                        veterinario.Codigo,
                        veterinario.Nome,
                        veterinario.Cpf,
                        veterinario.DataAdmissao.ToString("dd/MM/yyyy")
                });
            }

            dataGridViewVeterinarios.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeVeterinario.Text.Trim().ToLower();
            var cpf = maskedTextBoxCpf.Text;
            var dataAdmissao = dateTimePickerDataAdmissao.Value;

            var dadosValidados = ValidarDados(nome, cpf, dataAdmissao);

            if (dadosValidados == false)
                return;

            if (dataGridViewVeterinarios.SelectedRows.Count == 0)
                CadastrarVeterinario(nome, cpf, dataAdmissao);
            else
                EditarVeterinario(nome, cpf, dataAdmissao);

            PreencherDataGridViewComVeterinarios();

            LimparCampos();
        }

        private void CadastrarVeterinario(string nome, string cpf, DateTime dataAdmissao)
        {
            var veterinario = new Veterinario();

            veterinario.Codigo = veterinarioServico.ObterUltimoCodigo() + 1;
            veterinario.Nome = nome;
            veterinario.Cpf = cpf;
            veterinario.DataAdmissao = dataAdmissao;

            veterinarioServico.Adicionar(veterinario);
        }

        public void EditarVeterinario(string nome, string cpf, DateTime dataAdmissao)
        {
            var linhaSelecionada = dataGridViewVeterinarios.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var veterinario = new Veterinario();

            veterinario.Codigo = veterinarioServico.ObterUltimoCodigo() + 1;
            veterinario.Nome = nome;
            veterinario.Cpf = cpf;
            veterinario.DataAdmissao = dataAdmissao;

            veterinarioServico.Editar(veterinario);
        }

        private bool ValidarDados(string nome, string cpf, DateTime dataAdmissao)
        {
            if (nome.Trim().Length < 3)
            {
                MessageBox.Show("Nome do medicamento inválido.");

                textBoxNomeVeterinario.Focus();

                return false;
            }

            if (cpf.Length != 14)
            {
                MessageBox.Show("CPF Inválido.");

                maskedTextBoxCpf.Focus();

                return false;
            }

            if (dataAdmissao > DateTime.Now)
            {
                MessageBox.Show("Data de admissão não pode ser maior do que a atual");

                dateTimePickerDataAdmissao.Focus();

                return false;
            }

            return true;
        }

        public void LimparCampos()
        {
            textBoxNomeVeterinario.Text = string.Empty;
            maskedTextBoxCpf.Text = string.Empty;
            dateTimePickerDataAdmissao.ResetText();
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
            if (dataGridViewVeterinarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um veterinario para editar!");

                return;
            }

            var linhaSelecionada = dataGridViewVeterinarios.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var veterinario = veterinarioServico.ObterPorCodigo(codigo);

            textBoxNomeVeterinario.Text = veterinario.Nome;
            maskedTextBoxCpf.Text = veterinario.Cpf;
            dateTimePickerDataAdmissao.Text = Convert.ToString(veterinario.DataAdmissao);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeterinarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um veterinário para apagar!");

                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar esse veterinário?", "AVISO",
                MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Operação cancelada. O veterinário continua salvo!");

                return;
            }

            var linhaSelecionada = dataGridViewVeterinarios.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var veterinario = veterinarioServico.ObterPorCodigo(codigo);

            veterinarioServico.Apagar(veterinario);

            PreencherDataGridViewComVeterinarios();

            dataGridViewVeterinarios.ClearSelection();
        }

        private void dataGridViewVeterinarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencherDataGridViewComVeterinarios();
        }
    }
}