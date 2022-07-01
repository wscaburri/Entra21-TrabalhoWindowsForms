namespace Entra21_TrabalhoWindowsForms
{
    public partial class CadastroAnimal : Form
    {
        private AnimalServico animalServico;

        //private Validacoes validacoes;
        public CadastroAnimal()
        {
            InitializeComponent();

            animalServico = new AnimalServico();

            //      ObterDados();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextAlignChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CadastroPets_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var cadastro = dateTimePickerDataDeCadastro.Value;
            var nascimento = dateTimePickerDataDeNascimento.Value;
            var pelagem = textBoxPelagem.Text;
            var peso = textBoxPeso.Text;
            var doenca = textBoxDoencas.Text;
            var vacinado = checkBoxVacinado.Checked;
            var especie = Convert.ToString(comboBoxEspecie.SelectedItem);
            var raca = Convert.ToString(comboBoxRaca.SelectedItem);
            var observacoes = richTextBoxObservacoes.Text;

            var dadosValidos = ValidarDados(nome, nascimento, pelagem, peso, doenca, vacinado, especie, raca);

            LimparCampos();
        }

        public bool ValidarDados(string nome, DateTime nascimento, string pelagem, string peso, string doenca, bool vacinado, string especie, string raca)
        {
            if (nome.Trim().Length < 1)
            {
                MessageBox.Show("Nome inválido, tente novamente.");
                return false;
            }
            if (pelagem.Trim().Length < 3)
            {
                MessageBox.Show("Pelagem inexistente.");
                return false;
            }
            if (doenca.Trim().Length < 2)
            {
                MessageBox.Show("Doença inválida, digite novamente.");
                return false;
            }
            if (nascimento.Date.Year == nascimento.Date.Year)
            {
                MessageBox.Show("Cadastro nulo, escolha uma data válida");
                return false;
            }
            if (comboBoxEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma espécie.");

                comboBoxEspecie.DroppedDown = true;

                return false;
            }
            if (comboBoxRaca.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma raça.");

                comboBoxRaca.DroppedDown = true;

                return false;
            }
            if (peso.Trim().Length < 0)
            {
                MessageBox.Show("Digite o peso.");
                return false;
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dateTimePickerDataDeCadastro_ValueChanged(object sender, EventArgs e)
        {
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            dateTimePickerDataDeCadastro.Value = new DateTime(2022, 06, 22);
            textBoxPelagem.Text = "";
            textBoxPeso.Text = "";
            dateTimePickerDataDeNascimento.Value = new DateTime(2022, 06, 22);
            checkBoxVacinado.Checked = false;
            comboBoxEspecie.SelectedIndex = 0;
            comboBoxRaca.SelectedIndex = 0;
            richTextBoxObservacoes.Text = "";
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEditar();
        }

        private void ApresentarDadosParaEditar()
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = animalServico.ObterPorCodigo(codigo);
        }

        private void richTextBoxObservacoes_TextChanged(object sender, EventArgs e)
        {
        }
    }
}