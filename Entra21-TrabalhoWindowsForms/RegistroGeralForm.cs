namespace Entra21_TrabalhoWindowsForms
{
    public partial class RegistroGeralForm : Form
    {
        private AgendamentoConsultaForm agendamentoConsultaForm;
        private AgendamentoConsultaServico agendamentoConsultaServico;

        public RegistroGeralForm()
        {
            InitializeComponent();

            agendamentoConsultaForm = new AgendamentoConsultaForm();
            agendamentoConsultaServico = new AgendamentoConsultaServico();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}