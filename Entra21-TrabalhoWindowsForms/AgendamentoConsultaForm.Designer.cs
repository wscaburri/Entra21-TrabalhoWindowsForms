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
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.labelDataConsulta = new System.Windows.Forms.Label();
            this.labelHoraConsulta = new System.Windows.Forms.Label();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.labelPet = new System.Windows.Forms.Label();
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.comboBoxPet = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelVeterinario = new System.Windows.Forms.Label();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.dateTimePickerHoraConsulta = new System.Windows.Forms.DateTimePicker();
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
            this.ColumnData,
            this.ColumnHora,
            this.ColumnResponsavel,
            this.ColumnPet,
            this.ColumnVeterinario});
            this.dataGridViewAgendamentoConsulta.Location = new System.Drawing.Point(405, 31);
            this.dataGridViewAgendamentoConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewAgendamentoConsulta.Name = "dataGridViewAgendamentoConsulta";
            this.dataGridViewAgendamentoConsulta.ReadOnly = true;
            this.dataGridViewAgendamentoConsulta.RowHeadersWidth = 51;
            this.dataGridViewAgendamentoConsulta.RowTemplate.Height = 25;
            this.dataGridViewAgendamentoConsulta.Size = new System.Drawing.Size(506, 492);
            this.dataGridViewAgendamentoConsulta.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.MinimumWidth = 6;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Width = 125;
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.MinimumWidth = 6;
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            this.ColumnHora.Width = 125;
            // 
            // ColumnResponsavel
            // 
            this.ColumnResponsavel.HeaderText = "Nome do Responsável";
            this.ColumnResponsavel.MinimumWidth = 6;
            this.ColumnResponsavel.Name = "ColumnResponsavel";
            this.ColumnResponsavel.ReadOnly = true;
            this.ColumnResponsavel.Width = 125;
            // 
            // ColumnPet
            // 
            this.ColumnPet.HeaderText = "Nome do Pet";
            this.ColumnPet.MinimumWidth = 6;
            this.ColumnPet.Name = "ColumnPet";
            this.ColumnPet.ReadOnly = true;
            this.ColumnPet.Width = 125;
            // 
            // ColumnVeterinario
            // 
            this.ColumnVeterinario.HeaderText = "Nome do Veterinário";
            this.ColumnVeterinario.MinimumWidth = 6;
            this.ColumnVeterinario.Name = "ColumnVeterinario";
            this.ColumnVeterinario.ReadOnly = true;
            this.ColumnVeterinario.Width = 125;
            // 
            // dateTimePickerDataConsulta
            // 
            this.dateTimePickerDataConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataConsulta.Location = new System.Drawing.Point(176, 114);
            this.dateTimePickerDataConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDataConsulta.Name = "dateTimePickerDataConsulta";
            this.dateTimePickerDataConsulta.Size = new System.Drawing.Size(162, 34);
            this.dateTimePickerDataConsulta.TabIndex = 1;
            // 
            // labelDataConsulta
            // 
            this.labelDataConsulta.AutoSize = true;
            this.labelDataConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataConsulta.Location = new System.Drawing.Point(12, 120);
            this.labelDataConsulta.Name = "labelDataConsulta";
            this.labelDataConsulta.Size = new System.Drawing.Size(158, 28);
            this.labelDataConsulta.TabIndex = 2;
            this.labelDataConsulta.Text = "Selecione a data:";
            // 
            // labelHoraConsulta
            // 
            this.labelHoraConsulta.AutoSize = true;
            this.labelHoraConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHoraConsulta.Location = new System.Drawing.Point(12, 178);
            this.labelHoraConsulta.Name = "labelHoraConsulta";
            this.labelHoraConsulta.Size = new System.Drawing.Size(159, 28);
            this.labelHoraConsulta.TabIndex = 4;
            this.labelHoraConsulta.Text = "Selecione a hora:";
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResponsavel.Location = new System.Drawing.Point(10, 234);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(228, 28);
            this.labelResponsavel.TabIndex = 5;
            this.labelResponsavel.Text = "Selecione o Responsável:";
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPet.Location = new System.Drawing.Point(12, 316);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(148, 28);
            this.labelPet.TabIndex = 6;
            this.labelPet.Text = "Selecione o Pet:";
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(12, 266);
            this.comboBoxResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(359, 36);
            this.comboBoxResponsavel.TabIndex = 7;
            // 
            // comboBoxPet
            // 
            this.comboBoxPet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPet.FormattingEnabled = true;
            this.comboBoxPet.Location = new System.Drawing.Point(10, 348);
            this.comboBoxPet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPet.Name = "comboBoxPet";
            this.comboBoxPet.Size = new System.Drawing.Size(361, 36);
            this.comboBoxPet.TabIndex = 8;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(195, 492);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 31);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(287, 492);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(86, 31);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(414, 556);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(86, 31);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(506, 556);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(86, 31);
            this.buttonApagar.TabIndex = 12;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelVeterinario
            // 
            this.labelVeterinario.AutoSize = true;
            this.labelVeterinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVeterinario.Location = new System.Drawing.Point(10, 400);
            this.labelVeterinario.Name = "labelVeterinario";
            this.labelVeterinario.Size = new System.Drawing.Size(216, 28);
            this.labelVeterinario.TabIndex = 13;
            this.labelVeterinario.Text = "Selecione o Veterinário:";
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(10, 431);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(361, 36);
            this.comboBoxVeterinario.TabIndex = 14;
            // 
            // dateTimePickerHoraConsulta
            // 
            this.dateTimePickerHoraConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraConsulta.Location = new System.Drawing.Point(176, 172);
            this.dateTimePickerHoraConsulta.Name = "dateTimePickerHoraConsulta";
            this.dateTimePickerHoraConsulta.Size = new System.Drawing.Size(162, 34);
            this.dateTimePickerHoraConsulta.TabIndex = 15;
            // 
            // AgendamentoConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 600);
            this.Controls.Add(this.dateTimePickerHoraConsulta);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.labelVeterinario);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxPet);
            this.Controls.Add(this.comboBoxResponsavel);
            this.Controls.Add(this.labelPet);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.labelHoraConsulta);
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
        private Label labelHoraConsulta;
        private Label labelResponsavel;
        private Label labelPet;
        private ComboBox comboBoxResponsavel;
        private ComboBox comboBoxPet;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelVeterinario;
        private ComboBox comboBoxVeterinario;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn ColumnHora;
        private DataGridViewTextBoxColumn ColumnResponsavel;
        private DataGridViewTextBoxColumn ColumnPet;
        private DataGridViewTextBoxColumn ColumnVeterinario;
        private DateTimePicker dateTimePickerHoraConsulta;
    }
}