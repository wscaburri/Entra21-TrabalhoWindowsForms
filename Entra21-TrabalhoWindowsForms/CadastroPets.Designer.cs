namespace Entra21_TrabalhoWindowsForms
{
    partial class CadastroPets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPets));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.dateTimePickerDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.labelRaca = new System.Windows.Forms.Label();
            this.labelPelagem = new System.Windows.Forms.Label();
            this.textBoxPelagem = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelDoencas = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelDataDeNascimento = new System.Windows.Forms.Label();
            this.dateTimePickerDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxDoencas = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.radioButtonFemea = new System.Windows.Forms.RadioButton();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.checkBoxVacinado = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxEspecie = new System.Windows.Forms.ComboBox();
            this.comboBoxRaca = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.richTextBoxObservacoes = new System.Windows.Forms.RichTextBox();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(109, 395);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 43);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(606, 395);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(88, 43);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(222, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(270, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCadastro.Location = new System.Drawing.Point(515, 9);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(100, 15);
            this.labelCadastro.TabIndex = 7;
            this.labelCadastro.Text = "Data de Cadastro:";
            // 
            // dateTimePickerDataDeCadastro
            // 
            this.dateTimePickerDataDeCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeCadastro.Location = new System.Drawing.Point(515, 27);
            this.dateTimePickerDataDeCadastro.Name = "dateTimePickerDataDeCadastro";
            this.dateTimePickerDataDeCadastro.Size = new System.Drawing.Size(113, 23);
            this.dateTimePickerDataDeCadastro.TabIndex = 8;
            this.dateTimePickerDataDeCadastro.ValueChanged += new System.EventHandler(this.dateTimePickerDataDeCadastro_ValueChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelNome.Location = new System.Drawing.Point(222, 12);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(95, 15);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Nome / Apelido:";
            // 
            // labelEspecie
            // 
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelEspecie.Location = new System.Drawing.Point(222, 67);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(49, 15);
            this.labelEspecie.TabIndex = 15;
            this.labelEspecie.Text = "Espécie:";
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelRaca.Location = new System.Drawing.Point(338, 133);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(35, 15);
            this.labelRaca.TabIndex = 16;
            this.labelRaca.Text = "Raça:";
            // 
            // labelPelagem
            // 
            this.labelPelagem.AutoSize = true;
            this.labelPelagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelPelagem.Location = new System.Drawing.Point(384, 67);
            this.labelPelagem.Name = "labelPelagem";
            this.labelPelagem.Size = new System.Drawing.Size(86, 15);
            this.labelPelagem.TabIndex = 17;
            this.labelPelagem.Text = "Cor / Pelagem:";
            // 
            // textBoxPelagem
            // 
            this.textBoxPelagem.Location = new System.Drawing.Point(360, 88);
            this.textBoxPelagem.Name = "textBoxPelagem";
            this.textBoxPelagem.Size = new System.Drawing.Size(132, 23);
            this.textBoxPelagem.TabIndex = 18;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(222, 215);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(270, 23);
            this.textBoxPeso.TabIndex = 19;
            // 
            // labelDoencas
            // 
            this.labelDoencas.AutoSize = true;
            this.labelDoencas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelDoencas.Location = new System.Drawing.Point(222, 256);
            this.labelDoencas.Name = "labelDoencas";
            this.labelDoencas.Size = new System.Drawing.Size(55, 15);
            this.labelDoencas.TabIndex = 20;
            this.labelDoencas.Text = "Doenças:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelPeso.Location = new System.Drawing.Point(338, 194);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(35, 15);
            this.labelPeso.TabIndex = 23;
            this.labelPeso.Text = "Peso:";
            // 
            // labelDataDeNascimento
            // 
            this.labelDataDeNascimento.AutoSize = true;
            this.labelDataDeNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelDataDeNascimento.Location = new System.Drawing.Point(514, 67);
            this.labelDataDeNascimento.Name = "labelDataDeNascimento";
            this.labelDataDeNascimento.Size = new System.Drawing.Size(117, 15);
            this.labelDataDeNascimento.TabIndex = 25;
            this.labelDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // dateTimePickerDataDeNascimento
            // 
            this.dateTimePickerDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeNascimento.Location = new System.Drawing.Point(514, 85);
            this.dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            this.dateTimePickerDataDeNascimento.Size = new System.Drawing.Size(113, 23);
            this.dateTimePickerDataDeNascimento.TabIndex = 27;
            // 
            // textBoxDoencas
            // 
            this.textBoxDoencas.Location = new System.Drawing.Point(222, 274);
            this.textBoxDoencas.Name = "textBoxDoencas";
            this.textBoxDoencas.Size = new System.Drawing.Size(270, 23);
            this.textBoxDoencas.TabIndex = 28;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(700, 395);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(88, 43);
            this.buttonApagar.TabIndex = 29;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemea
            // 
            this.radioButtonFemea.AutoSize = true;
            this.radioButtonFemea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButtonFemea.Location = new System.Drawing.Point(505, 156);
            this.radioButtonFemea.Name = "radioButtonFemea";
            this.radioButtonFemea.Size = new System.Drawing.Size(63, 19);
            this.radioButtonFemea.TabIndex = 30;
            this.radioButtonFemea.TabStop = true;
            this.radioButtonFemea.Text = "Fêmea.";
            this.radioButtonFemea.UseVisualStyleBackColor = false;
            // 
            // radioButtonMacho
            // 
            this.radioButtonMacho.AutoSize = true;
            this.radioButtonMacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButtonMacho.Location = new System.Drawing.Point(505, 181);
            this.radioButtonMacho.Name = "radioButtonMacho";
            this.radioButtonMacho.Size = new System.Drawing.Size(65, 19);
            this.radioButtonMacho.TabIndex = 31;
            this.radioButtonMacho.TabStop = true;
            this.radioButtonMacho.Text = "Macho.";
            this.radioButtonMacho.UseVisualStyleBackColor = false;
            this.radioButtonMacho.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkBoxVacinado
            // 
            this.checkBoxVacinado.AutoSize = true;
            this.checkBoxVacinado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBoxVacinado.Location = new System.Drawing.Point(505, 219);
            this.checkBoxVacinado.Name = "checkBoxVacinado";
            this.checkBoxVacinado.Size = new System.Drawing.Size(77, 19);
            this.checkBoxVacinado.TabIndex = 32;
            this.checkBoxVacinado.Text = "Vacinado.";
            this.checkBoxVacinado.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(15, 395);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 43);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxEspecie
            // 
            this.comboBoxEspecie.FormattingEnabled = true;
            this.comboBoxEspecie.Location = new System.Drawing.Point(222, 88);
            this.comboBoxEspecie.Name = "comboBoxEspecie";
            this.comboBoxEspecie.Size = new System.Drawing.Size(132, 23);
            this.comboBoxEspecie.TabIndex = 34;
            // 
            // comboBoxRaca
            // 
            this.comboBoxRaca.FormattingEnabled = true;
            this.comboBoxRaca.Location = new System.Drawing.Point(222, 156);
            this.comboBoxRaca.Name = "comboBoxRaca";
            this.comboBoxRaca.Size = new System.Drawing.Size(270, 23);
            this.comboBoxRaca.TabIndex = 35;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSexo.Location = new System.Drawing.Point(515, 133);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(35, 15);
            this.labelSexo.TabIndex = 37;
            this.labelSexo.Text = "Sexo:";
            this.labelSexo.Click += new System.EventHandler(this.label11_Click);
            // 
            // richTextBoxObservacoes
            // 
            this.richTextBoxObservacoes.Location = new System.Drawing.Point(505, 274);
            this.richTextBoxObservacoes.Name = "richTextBoxObservacoes";
            this.richTextBoxObservacoes.Size = new System.Drawing.Size(283, 67);
            this.richTextBoxObservacoes.TabIndex = 38;
            this.richTextBoxObservacoes.Text = "";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelObservacoes.Location = new System.Drawing.Point(606, 256);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(77, 15);
            this.labelObservacoes.TabIndex = 39;
            this.labelObservacoes.Text = "Observações:";
            // 
            // CadastroPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelObservacoes);
            this.Controls.Add(this.richTextBoxObservacoes);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.comboBoxRaca);
            this.Controls.Add(this.comboBoxEspecie);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.checkBoxVacinado);
            this.Controls.Add(this.radioButtonMacho);
            this.Controls.Add(this.radioButtonFemea);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.textBoxDoencas);
            this.Controls.Add(this.dateTimePickerDataDeNascimento);
            this.Controls.Add(this.labelDataDeNascimento);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDoencas);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxPelagem);
            this.Controls.Add(this.labelPelagem);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.labelEspecie);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dateTimePickerDataDeCadastro);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "CadastroPets";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.CadastroPets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonEditar;
        private TextBox textBoxNome;
        private Label labelCadastro;
        private DateTimePicker dateTimePickerDataDeCadastro;
        private Label labelNome;
        private Label labelEspecie;
        private Label labelRaca;
        private Label labelPelagem;
        private TextBox textBoxPelagem;
        private TextBox textBoxPeso;
        private Label labelDoencas;
        private Label labelPeso;
        private Label labelDataDeNascimento;
        private DateTimePicker dateTimePickerDataDeNascimento;
        private TextBox textBoxDoencas;
        private Button buttonApagar;
        private RadioButton radioButtonFemea;
        private RadioButton radioButtonMacho;
        private CheckBox checkBoxVacinado;
        private Button buttonCancelar;
        private ComboBox comboBoxEspecie;
        private ComboBox comboBoxRaca;
        private Label labelSexo;
        private RichTextBox richTextBoxObservacoes;
        private Label labelObservacoes;
    }
}