namespace Entra21_TrabalhoWindowsForms
{
    public partial class CadastroAnimal : Form
    {
        private AnimalServico animalServico;
        private Animal objAnimal;

        //private Validacoes validacoes;
        public CadastroAnimal()
        {
            InitializeComponent();

            animalServico = new AnimalServico();

            
        }


        private void CadastroPets_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComAnimais();
        }

      
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var dataCadastro = Convert.ToString(dateTimePickerDataDeCadastro.Value);
            var idade = Convert.ToString( dateTimePickerDataDeNascimento.Value);
            var sexoMacho = radioButtonMacho.Text;
            var sexoFemea = radioButtonFemea.Text;
            var pelagem = textBoxPelagem.Text;
            var peso = textBoxPeso.Text;
            var doenca = textBoxDoencas.Text;
            var vacinado = checkBoxVacinado.Checked;
            var especie = Convert.ToString(comboBoxEspecie.SelectedItem);
            var raca = Convert.ToString(comboBoxRaca.SelectedItem);
           

            var dadosValidos = ValidarDados(nome, pelagem, peso, vacinado, especie, raca);
            if (dadosValidos == false)
            {
                return;
            }
           
           

            PreencherDataGridViewComAnimais();


            LimparCampos();
        }

        public bool ValidarDados(string nome, string pelagem, string peso, bool vacinado, string especie, string raca)
        {
            if (nome.Trim().Length < 1)
            {
                MessageBox.Show("Nome inválido, tente novamente.");
                return false;
            }
            if (pelagem.Trim().Length < 3)
            {
                MessageBox.Show("Pelagem inexistente.");
                textBoxPelagem.Focus();
                return false;
            }
            var dataAtual = DateTime.Now;
            if (dateTimePickerDataDeNascimento.Value == dataAtual)
            {
                MessageBox.Show("Preencha a data de nascimento");
                dateTimePickerDataDeNascimento.Focus();
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
                textBoxPeso.Focus();
                return false;
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
            if (dataGridView1.SelectedRows.Count == 0)
            {

                MessageBox.Show("Selecione um endereço para editar");

                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = animalServico.ObterPorCodigo(codigo);
        }
        public void PreencherDataGridViewComAnimais()
        {
            var animais = animalServico.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < animais.Count; i++)
            {
                var animal= animais[i];

                dataGridView1.Rows.Add(new object[]
                {
                    animal.Codigo,
                    animal.Nome,
                    animal.Especie,
                    animal.DataDeCadastro,

                });

            }
            dataGridView1.Rows.Clear();
        }
       public void CadastrarAnimais(string nomeAnimal, string especie, string raca, string pelagem, string sexoMacho, string sexoFemea, 
          string peso, string doencas, string dataCadastro, string idade, bool vacina )
        {
            var animal = new Animal();
            animal.Codigo = animalServico.ObterPorUltimoCodigo() + 1;
            animal.Nome = nomeAnimal;
            animal.Especie = especie;
            animal.Raca = raca;
            animal.Pelagem = pelagem;
            animal.Sexo = sexoMacho;
            animal.Sexo = sexoFemea;
            animal.Peso = Convert.ToDouble(peso);
            animal.Doencas = doencas;
            animal.DataDeCadastro = Convert.ToDateTime(dataCadastro);
            animal.Idade = Convert.ToDateTime(idade);
            animal.Vacinas = vacina;

           
            animalServico.Adicionar(animal);
        }

     
            private void EditarAnimais(string nomeAnimal, string especie, string raca, string pelagem, string sexoMacho,string sexoFemea,
           double peso, string doencas, string dataCadastro, string idade,  bool vacina)
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);


                var animal = new Animal();
                animal.Codigo = codigoSelecionado;
                animal.Nome = nomeAnimal;
                animal.Idade = Convert.ToDateTime(idade);
                animal.Especie = especie;
                animal.Raca = raca;
                animal.Pelagem = pelagem;
                animal.Sexo = sexoMacho;
		        animal.Sexo = sexoFemea;
                animal.Peso = Convert.ToDouble(peso);
                animal.Doencas = doencas;
                animal.DataDeCadastro = Convert.ToDateTime(dataCadastro);
                animal.Vacinas = vacina;
           
                


                animalServico.Editar(animal);
            }
        
    }
}