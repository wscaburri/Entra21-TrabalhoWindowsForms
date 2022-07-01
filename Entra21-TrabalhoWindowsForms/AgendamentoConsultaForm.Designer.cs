namespace Entra21_TrabalhoWindowsForms
{
    partial class AgendamentoConsultaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.labelDataConsulta = new System.Windows.Forms.Label();
            this.maskedTextBoxHoraConsulta = new System.Windows.Forms.MaskedTextBox();
            this.labelHoraConsulta = new System.Windows.Forms.Label();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.labelPet = new System.Windows.Forms.Label();
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.comboBoxPet = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePickerDataConsulta
            // 
            this.dateTimePickerDataConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataConsulta.Location = new System.Drawing.Point(164, 100);
            this.dateTimePickerDataConsulta.Name = "dateTimePickerDataConsulta";
            this.dateTimePickerDataConsulta.Size = new System.Drawing.Size(111, 29);
            this.dateTimePickerDataConsulta.TabIndex = 1;
            // 
            // labelDataConsulta
            // 
            this.labelDataConsulta.AutoSize = true;
            this.labelDataConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataConsulta.Location = new System.Drawing.Point(33, 108);
            this.labelDataConsulta.Name = "labelDataConsulta";
            this.labelDataConsulta.Size = new System.Drawing.Size(125, 21);
            this.labelDataConsulta.TabIndex = 2;
            this.labelDataConsulta.Text = "Selecione a data:";
            // 
            // maskedTextBoxHoraConsulta
            // 
            this.maskedTextBoxHoraConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxHoraConsulta.Location = new System.Drawing.Point(166, 151);
            this.maskedTextBoxHoraConsulta.Mask = "00:00";
            this.maskedTextBoxHoraConsulta.Name = "maskedTextBoxHoraConsulta";
            this.maskedTextBoxHoraConsulta.Size = new System.Drawing.Size(48, 29);
            this.maskedTextBoxHoraConsulta.TabIndex = 3;
            this.maskedTextBoxHoraConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // labelHoraConsulta
            // 
            this.labelHoraConsulta.AutoSize = true;
            this.labelHoraConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHoraConsulta.Location = new System.Drawing.Point(33, 159);
            this.labelHoraConsulta.Name = "labelHoraConsulta";
            this.labelHoraConsulta.Size = new System.Drawing.Size(127, 21);
            this.labelHoraConsulta.TabIndex = 4;
            this.labelHoraConsulta.Text = "Selecione a hora:";
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResponsavel.Location = new System.Drawing.Point(33, 208);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(183, 21);
            this.labelResponsavel.TabIndex = 5;
            this.labelResponsavel.Text = "Selecione o Responsável:";
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPet.Location = new System.Drawing.Point(33, 280);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(117, 21);
            this.labelPet.TabIndex = 6;
            this.labelPet.Text = "Selecione o Pet:";
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(33, 232);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(280, 29);
            this.comboBoxResponsavel.TabIndex = 7;
            // 
            // comboBoxPet
            // 
            this.comboBoxPet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPet.FormattingEnabled = true;
            this.comboBoxPet.Location = new System.Drawing.Point(33, 304);
            this.comboBoxPet.Name = "comboBoxPet";
            this.comboBoxPet.Size = new System.Drawing.Size(280, 29);
            this.comboBoxPet.TabIndex = 8;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(33, 357);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(114, 357);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(367, 415);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(448, 415);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 12;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // AgendamentoConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxPet);
            this.Controls.Add(this.comboBoxResponsavel);
            this.Controls.Add(this.labelPet);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.labelHoraConsulta);
            this.Controls.Add(this.maskedTextBoxHoraConsulta);
            this.Controls.Add(this.labelDataConsulta);
            this.Controls.Add(this.dateTimePickerDataConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AgendamentoConsultaForm";
            this.Text = "AgendamentoConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerDataConsulta;
        private Label labelDataConsulta;
        private MaskedTextBox maskedTextBoxHoraConsulta;
        private Label labelHoraConsulta;
        private Label labelResponsavel;
        private Label labelPet;
        private ComboBox comboBoxResponsavel;
        private ComboBox comboBoxPet;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonApagar;
    }
}