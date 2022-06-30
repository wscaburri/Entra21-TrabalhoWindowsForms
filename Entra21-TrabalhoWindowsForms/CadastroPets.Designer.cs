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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.dateTimePickerDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.labelDono = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDataDeNascimento = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDoencas = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBoxVacinado = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxEspecie = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::Entra21_TrabalhoWindowsForms.Properties.Resources.B42E7514_543A_4DBA_B672_1418E7227D59;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(229, 85);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(251, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Location = new System.Drawing.Point(515, 9);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(97, 15);
            this.labelCadastro.TabIndex = 7;
            this.labelCadastro.Text = "Data de Cadastro";
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
            // labelDono
            // 
            this.labelDono.AutoSize = true;
            this.labelDono.Location = new System.Drawing.Point(232, 9);
            this.labelDono.Name = "labelDono";
            this.labelDono.Size = new System.Drawing.Size(160, 15);
            this.labelDono.TabIndex = 9;
            this.labelDono.Text = "Dono / Cliente / Responsável";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(229, 67);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Nome";
            // 
            // labelEspecie
            // 
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.Location = new System.Drawing.Point(229, 112);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(46, 15);
            this.labelEspecie.TabIndex = 15;
            this.labelEspecie.Text = "Espécie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Raça";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cor / Pelagem";
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(229, 219);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(251, 23);
            this.textBoxCor.TabIndex = 18;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(229, 274);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(251, 23);
            this.textBoxPeso.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Doenças";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Peso";
            // 
            // labelDataDeNascimento
            // 
            this.labelDataDeNascimento.AutoSize = true;
            this.labelDataDeNascimento.Location = new System.Drawing.Point(514, 67);
            this.labelDataDeNascimento.Name = "labelDataDeNascimento";
            this.labelDataDeNascimento.Size = new System.Drawing.Size(114, 15);
            this.labelDataDeNascimento.TabIndex = 25;
            this.labelDataDeNascimento.Text = "Data de Nascimento";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(514, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 23);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // textBoxDoencas
            // 
            this.textBoxDoencas.Location = new System.Drawing.Point(229, 318);
            this.textBoxDoencas.Name = "textBoxDoencas";
            this.textBoxDoencas.Size = new System.Drawing.Size(255, 23);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(505, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 19);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fêmea";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(505, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 19);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Macho";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkBoxVacinado
            // 
            this.checkBoxVacinado.AutoSize = true;
            this.checkBoxVacinado.Location = new System.Drawing.Point(303, 373);
            this.checkBoxVacinado.Name = "checkBoxVacinado";
            this.checkBoxVacinado.Size = new System.Drawing.Size(74, 19);
            this.checkBoxVacinado.TabIndex = 32;
            this.checkBoxVacinado.Text = "Vacinado";
            this.checkBoxVacinado.UseVisualStyleBackColor = true;
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
            this.comboBoxEspecie.Location = new System.Drawing.Point(232, 130);
            this.comboBoxEspecie.Name = "comboBoxEspecie";
            this.comboBoxEspecie.Size = new System.Drawing.Size(248, 23);
            this.comboBoxEspecie.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 23);
            this.comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(229, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 23);
            this.comboBox2.TabIndex = 36;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(505, 130);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(38, 15);
            this.labelSexo.TabIndex = 37;
            this.labelSexo.Text = "label1";
            this.labelSexo.Click += new System.EventHandler(this.label11_Click);
            // 
            // CadastroPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxEspecie);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.checkBoxVacinado);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.textBoxDoencas);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.labelDataDeNascimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxCor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEspecie);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelDono);
            this.Controls.Add(this.dateTimePickerDataDeCadastro);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "CadastroPets";
            this.Opacity = 0.2D;
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.CadastroPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonEditar;
        private PictureBox pictureBox1;
        private TextBox textBoxNome;
        private Label labelCadastro;
        private DateTimePicker dateTimePickerDataDeCadastro;
        private Label labelDono;
        private Label labelNome;
        private Label labelEspecie;
        private Label label5;
        private Label label6;
        private TextBox textBoxCor;
        private TextBox textBoxPeso;
        private Label label7;
        private Label label10;
        private Label labelDataDeNascimento;
        private DateTimePicker dateTimePicker2;
        private TextBox textBoxDoencas;
        private Button buttonApagar;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBoxVacinado;
        private Button buttonCancelar;
        private ComboBox comboBoxEspecie;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label labelSexo;
    }
}