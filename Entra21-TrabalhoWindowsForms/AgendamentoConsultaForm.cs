namespace Entra21_TrabalhoWindowsForms

{
    public partial class AgendamentoConsultaForm : Form


        private ResponsavelServico responsavelServico;
    private AnimalServico animalServico;

    {
        public AgendamentoConsultaForm()
    {
        InitializeComponent();

        responsavelServico = new ResponsavelServico();

        animalServico = new AnimalServico();
    }
}
}