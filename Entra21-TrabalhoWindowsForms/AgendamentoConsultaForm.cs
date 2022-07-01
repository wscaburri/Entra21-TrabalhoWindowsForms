namespace Entra21_TrabalhoWindowsForms
{
    public partial class AgendamentoConsultaForm : Form
    {
        private AgendamentoConsultaServico agendamentoConsultaServico;
        private ResponsavelServico responsavelServico;
        private AnimalServico animalServico;
        private VeterinarioServico veterinarioServico;

        public AgendamentoConsultaForm()
        {
            InitializeComponent();

            agendamentoConsultaServico = new AgendamentoConsultaServico();
            responsavelServico = new ResponsavelServico();
            animalServico = new AnimalServico();
            veterinarioServico = new VeterinarioServico();

            PreencherDataGridViewComAgendamentos();
            PreencherComboBoxComNomeResponsavel();
            PreencherComboBoxComNomePet();
            PreencherComboBoxComNomeVeterinario();
        }

        private void PreencherComboBoxComNomeResponsavel()
        {
            var responsaveis = responsavelServico.ObterTodos();
            for (var i = 0; i < responsaveis.Count; i++)
            {
                var responsavel = responsaveis[i];
                comboBoxResponsavel.Items.Add(responsavel.NomeCompleto);
            }
        }

        private void PreencherComboBoxComNomePet()
        {
            var animais = animalServico.ObterTodos();
            for (var i = 0; i < animais.Count; i++)
            {
                var animal = animais[i];
                comboBoxResponsavel.Items.Add(animal.Nome);
            }
        }

        private void PreencherComboBoxComNomeVeterinario()
        {
            var veterinarios = veterinarioServico.ObterTodos();
            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];
                comboBoxResponsavel.Items.Add(veterinario.Nome);
            }
        }

        private void PreencherDataGridViewComAgendamentos()
        {
            var agendamentos = agendamentoConsultaServico.ObterTodos();

            dataGridViewAgendamentoConsulta.Rows.Clear();

            for (var i = 0; i < agendamentos.Count; i++)
            {
                var agendamento = agendamentos[i];

                dataGridViewAgendamentoConsulta.Rows.Add(new object[]
                {
                        agendamento.Codigo,
                        agendamento.DataConsulta.ToString("dd/MM/yyyy"),
                        agendamento.HoraConsulta,
                        agendamento.NomeResponsavel,
                        agendamento.NomePet,
                        agendamento.NomeVeterinario
                });
            }

            dataGridViewAgendamentoConsulta.ClearSelection();
        }

        private void dataGridViewAgendamentoConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencherDataGridViewComAgendamentos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var dataConsulta = dateTimePickerDataConsulta.Value;
            var horaConsulta = dateTimePickerHoraConsulta.Value;
            var nomeResponsavel = Convert.ToString(comboBoxResponsavel.SelectedItem);
            var nomePet = Convert.ToString(comboBoxPet.SelectedItem);
            var nomeVeterinario = Convert.ToString(comboBoxVeterinario.SelectedItem);

            var dadosValidados = ValidarDados(dataConsulta, horaConsulta, nomeResponsavel, nomePet, nomeVeterinario);

            if (dadosValidados == false)
                return;

            if (dataGridViewAgendamentoConsulta.SelectedRows.Count == 0)
                CadastrarAgendamento(dataConsulta, horaConsulta, nomeResponsavel, nomePet, nomeVeterinario);
            else
                EditarAgendamento(dataConsulta, horaConsulta, nomeResponsavel, nomePet, nomeVeterinario);

            PreencherDataGridViewComAgendamentos();

            LimparCampos();
        }

        public void CadastrarAgendamento(DateTime dataConsulta, DateTime horaConsulta, string nomeResponsavel, string nomePet, string nomeVeterinario)
        {
            var agendamentos = new AgendamentoConsulta();

            agendamentos.Codigo = agendamentoConsultaServico.ObterUltimoCodigo() + 1;
            agendamentos.DataConsulta = dataConsulta;
            agendamentos.HoraConsulta = horaConsulta;
            agendamentos.NomeResponsavel = nomeResponsavel;
            agendamentos.NomePet = nomePet;
            agendamentos.NomeVeterinario = nomeVeterinario;

            agendamentoConsultaServico.Adicionar(agendamentos);
        }

        public void EditarAgendamento(DateTime dataConsulta, DateTime horaConsulta, string nomeResponsavel, string nomePet, string nomeVeterinario)
        {
            var linhaSelecionada = dataGridViewAgendamentoConsulta.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var agendamento = new AgendamentoConsulta();

            agendamento.Codigo = codigoSelecionado;
            agendamento.DataConsulta = dataConsulta;
            agendamento.HoraConsulta = horaConsulta;
            agendamento.NomeResponsavel = nomeResponsavel;
            agendamento.NomePet = nomePet;
            agendamento.NomeVeterinario = nomeVeterinario;

            agendamentoConsultaServico.Editar(agendamento);
        }

        private bool ValidarDados(DateTime dataConsulta, DateTime horaConsulta, string nomeResponsavel, string nomePet, string nomeVeterinario)
        {
            if (dataConsulta < DateTime.Now)
            {
                MessageBox.Show("Data da Consulta não pode ser menor do que a atual");

                dateTimePickerDataConsulta.Focus();

                return false;
            }

            if (horaConsulta < DateTime.Now)
            {
                MessageBox.Show("Hora da Consulta não pode ser menor do que a atual");

                dateTimePickerHoraConsulta.Focus();
            }

            if (comboBoxResponsavel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Responsável.");

                comboBoxResponsavel.DroppedDown = true;

                return false;
            }

            if (comboBoxPet.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Pet.");

                comboBoxPet.DroppedDown = true;

                return false;
            }

            f(comboBoxVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Veterinário.");

                comboBoxVeterinario.DroppedDown = true;

                return false;
            }

            return true;
        }
    }
}