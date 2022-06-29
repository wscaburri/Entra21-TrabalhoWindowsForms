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
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeMedicamento.Text.Trim();
            var tipo = Convert.ToString(comboBoxTipoMedicamento.SelectedItem);

            /*if (dataGridViewMedicamentos.ColumnCount == 0)
            {
                AdicionarMedicamento(nome, tipo);

                return;
            }*/

            if (dataGridViewMedicamentos.SelectedRows.Count == 0)
                AdicionarMedicamento(nome, tipo);
            //else
            //EditarEndereco(nome, tipo);

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

        private void AdicionarMedicamento(string nome, string tipo)
        {
            var medicamento = new Medicamentos();

            medicamento.Codigo = medicamentosServico.ObterUltimoCodigo() + 1;
            medicamento.Nome = nome;
            medicamento.Tipo = tipo;
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
                MessageBox.Show("Operação cancelado. O medicamento continua salvo!");

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
        }
    }
}