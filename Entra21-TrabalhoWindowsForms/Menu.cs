namespace Entra21_TrabalhoWindowsForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonCadastroReponsavel_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastroRemedios_Click(object sender, EventArgs e)
        {
            var cadastroMedicamentosForm = new MedicamentosForm();
            cadastroMedicamentosForm.ShowDialog();
        }

        private void buttonRegistroGeral_Click(object sender, EventArgs e)
        {
            var registroGeralForm = new RegistroGeralForm();
            registroGeralForm.ShowDialog();
        }
    }
}