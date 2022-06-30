using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21_TrabalhoWindowsForms
{
    public partial class CadastroPets : Form
    {
        private AnimalServico animalServico;
        public CadastroPets()
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

            LimparCampos();
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
            dateTimePickerDataDeCadastro.Text = "00/00/0000";
            textBoxPelagem.Text = "";
            textBoxPeso.Text = "";
            dateTimePickerDataDeNascimento.Text = "00/00/0000";
            textBoxDoencas.Text = "";
            checkBoxVacinado.Checked = false;
            comboBoxEspecie.SelectedIndex = 0;
            comboBoxRaca.SelectedIndex = 0;
            richTextBoxObservacoes.Text = "";
        }
    }
}
