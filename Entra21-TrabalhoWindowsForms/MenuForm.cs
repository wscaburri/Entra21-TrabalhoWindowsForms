namespace Entra21_TrabalhoWindowsForms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonCadastroResponsavel_Click(object sender, EventArgs e)
        {
            var cadastroResponsavelForm = new ResponsavelForm();
            cadastroResponsavelForm.ShowDialog();
        }

        private void buttonCadastroPet_Click(object sender, EventArgs e)
        {
            var cadastroAnimal = new CadastroAnimal();
            cadastroAnimal.ShowDialog();
        }

        private void buttonCadastroMedicamentos_Click(object sender, EventArgs e)
        {
            var cadastroMedicamentosForm = new MedicamentosForm();
            cadastroMedicamentosForm.ShowDialog();
        }

        private void buttonVeterinario_Click(object sender, EventArgs e)
        {
            var cadastroVeterinarioForm = new VeterinarioForm();
            cadastroVeterinarioForm.ShowDialog();
        }

        private void buttonAgendamentoConsulta_Click(object sender, EventArgs e)
        {
            var cadastroAgendamentoConsultaForm = new AgendamentoConsultaForm();
            cadastroAgendamentoConsultaForm.ShowDialog();
        }

        private void buttonConsultarHorarios_Click(object sender, EventArgs e)
        {
            var registroGeralForm = new RegistroGeralForm();
            registroGeralForm.ShowDialog();
        }
    }
}