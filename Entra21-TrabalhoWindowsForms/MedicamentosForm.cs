namespace Entra21_TrabalhoWindowsForms
{
    public partial class MedicamentosForm : Form
    {
        private MedicamentosServico medicamentosServico;

        public MedicamentosForm()
        {
            InitializeComponent();

            medicamentosServico = new MedicamentosServico();

            ListarMedicamentos();

            PreencherDataGridViewComMedicamentos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeMedicamento.Text.Trim();
            var tipo = Convert.ToString(comboBoxTipoMedicamento.SelectedItem);

            //var dadosValidos = ValidarDados(nome, tipo);

            //if (dadosValidos == false)
            //    return;

            if (dataGridViewMedicamentos.SelectedRows.Count == 0)
                CadastrarMedicamento(nome, tipo);
            else
                //EditarMedicamento(nome, tipo);           

            PreencherDataGridViewComMedicamentos();

            LimparCampos();
        }

        private void ListarMedicamentos()
        {
            var medicamentos = medicamentosServico.ObterTodos();

            dataGridViewMedicamentos.ClearSelection();

            for (var i = 0; i < medicamentos.Count; i++)
            {
                var medicamento = medicamentos[i];

                dataGridViewMedicamentos.Rows.Add(new object[]
                {
                    medicamento.Codigo,
                    medicamento.Nome,
                    medicamento.Tipo,
                });
            }
        }        

        public void LimparCampos()
        {
            textBoxNomeMedicamento.Text = "";
            comboBoxTipoMedicamento.SelectedIndex = -1;

            dataGridViewMedicamentos.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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

            var nome = medicamentosServico.ObterPorCodigo(codigo);

            textBoxNomeMedicamento.Text = nome.Nome;
            comboBoxTipoMedicamento.SelectedItem = nome.Tipo;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEditar();
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
                        medicamento.Tipo
                });
            }

            dataGridViewMedicamentos.ClearSelection();
        }

        private void CadastrarMedicamento(string nome, string tipo)
        {
            var medicamentos = new Medicamentos();

            medicamentos.Codigo = medicamentosServico.ObterUltimoCodigo() + 1;
            medicamentos.Nome = nome;
            medicamentos.Tipo = tipo;

            medicamentosServico.Adicionar(medicamentos);
        }

        public void EditarMedicamento(string nome, string tipo)
        {
            var linhaSelecionada = dataGridViewMedicamentos.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var medicamento = new Medicamentos();

            medicamento.Codigo = codigoSelecionado;
            medicamento.Nome = nome;
            medicamento.Tipo = tipo;

            medicamentosServico.Editar(medicamento);
        }

        private void MedicamentosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComMedicamentos();
        }
    }
}