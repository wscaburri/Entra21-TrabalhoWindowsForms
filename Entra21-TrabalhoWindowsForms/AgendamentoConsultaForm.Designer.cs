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
            this.dataGridViewAgendamentoConsulta = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomePet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAgendamentoConsulta
            // 
            this.dataGridViewAgendamentoConsulta.AllowUserToAddRows = false;
            this.dataGridViewAgendamentoConsulta.AllowUserToDeleteRows = false;
            this.dataGridViewAgendamentoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendamentoConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNomeResponsavel,
            this.ColumnNomePet,
            this.ColumnData,
            this.ColumnHora});
            this.dataGridViewAgendamentoConsulta.Location = new System.Drawing.Point(354, 31);
            this.dataGridViewAgendamentoConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewAgendamentoConsulta.Name = "dataGridViewAgendamentoConsulta";
            this.dataGridViewAgendamentoConsulta.ReadOnly = true;
            this.dataGridViewAgendamentoConsulta.RowHeadersWidth = 51;
            this.dataGridViewAgendamentoConsulta.RowTemplate.Height = 25;
            this.dataGridViewAgendamentoConsulta.Size = new System.Drawing.Size(566, 492);
            this.dataGridViewAgendamentoConsulta.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNomeResponsavel
            // 
            this.ColumnNomeResponsavel.HeaderText = "Nome do Responsável";
            this.ColumnNomeResponsavel.MinimumWidth = 6;
            this.ColumnNomeResponsavel.Name = "ColumnNomeResponsavel";
            this.ColumnNomeResponsavel.Width = 125;
            // 
            // ColumnNomePet
            // 
            this.ColumnNomePet.HeaderText = "Nome do Pet";
            this.ColumnNomePet.MinimumWidth = 6;
            this.ColumnNomePet.Name = "ColumnNomePet";
            this.ColumnNomePet.Width = 125;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.MinimumWidth = 6;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.Width = 125;
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.MinimumWidth = 6;
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.Width = 125;
            // 
            // dateTimePickerDataConsulta
            // 
            this.dateTimePickerDataConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataConsulta.Location = new System.Drawing.Point(163, 123);
            this.dateTimePickerDataConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDataConsulta.Name = "dateTimePickerDataConsulta";
            this.dateTimePickerDataConsulta.Size = new System.Drawing.Size(126, 34);
            this.dateTimePickerDataConsulta.TabIndex = 1;
            // 
            // labelDataConsulta
            // 
            this.labelDataConsulta.AutoSize = true;
            this.labelDataConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataConsulta.Location = new System.Drawing.Point(14, 133);
            this.labelDataConsulta.Name = "labelDataConsulta";
            this.labelDataConsulta.Size = new System.Drawing.Size(158, 28);
            this.labelDataConsulta.TabIndex = 2;
            this.labelDataConsulta.Text = "Selecione a data:";
            // 
            // maskedTextBoxHoraConsulta
            // 
            this.maskedTextBoxHoraConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxHoraConsulta.Location = new System.Drawing.Point(166, 191);
            this.maskedTextBoxHoraConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxHoraConsulta.Mask = "00:00";
            this.maskedTextBoxHoraConsulta.Name = "maskedTextBoxHoraConsulta";
            this.maskedTextBoxHoraConsulta.Size = new System.Drawing.Size(54, 34);
            this.maskedTextBoxHoraConsulta.TabIndex = 3;
            this.maskedTextBoxHoraConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // labelHoraConsulta
            // 
            this.labelHoraConsulta.AutoSize = true;
            this.labelHoraConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHoraConsulta.Location = new System.Drawing.Point(14, 201);
            this.labelHoraConsulta.Name = "labelHoraConsulta";
            this.labelHoraConsulta.Size = new System.Drawing.Size(159, 28);
            this.labelHoraConsulta.TabIndex = 4;
            this.labelHoraConsulta.Text = "Selecione a hora:";
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResponsavel.Location = new System.Drawing.Point(14, 267);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(228, 28);
            this.labelResponsavel.TabIndex = 5;
            this.labelResponsavel.Text = "Selecione o Responsável:";
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPet.Location = new System.Drawing.Point(14, 363);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(148, 28);
            this.labelPet.TabIndex = 6;
            this.labelPet.Text = "Selecione o Pet:";
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(14, 299);
            this.comboBoxResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(319, 36);
            this.comboBoxResponsavel.TabIndex = 7;
            // 
            // comboBoxPet
            // 
            this.comboBoxPet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPet.FormattingEnabled = true;
            this.comboBoxPet.Location = new System.Drawing.Point(14, 395);
            this.comboBoxPet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPet.Name = "comboBoxPet";
            this.comboBoxPet.Size = new System.Drawing.Size(319, 36);
            this.comboBoxPet.TabIndex = 8;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 465);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 31);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(247, 465);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(86, 31);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(354, 553);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(86, 31);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(446, 553);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(86, 31);
            this.buttonApagar.TabIndex = 12;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // AgendamentoConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 600);
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
            this.Controls.Add(this.dataGridViewAgendamentoConsulta);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AgendamentoConsultaForm";
            this.Text = "AgendamentoConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAgendamentoConsulta;
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
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNomeResponsavel;
        private DataGridViewTextBoxColumn ColumnNomePet;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn ColumnHora;
    }
}