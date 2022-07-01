namespace Entra21_TrabalhoWindowsForms
{
    partial class RegistroGeralForm
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
            this.ColumnDataConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoraConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeResponsável = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomePet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDataConsulta,
            this.ColumnHoraConsulta,
            this.ColumnNomeResponsável,
            this.ColumnNomePet});
            this.dataGridView1.Location = new System.Drawing.Point(29, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(780, 663);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnDataConsulta
            // 
            this.ColumnDataConsulta.HeaderText = "Data da Consulta:";
            this.ColumnDataConsulta.MinimumWidth = 6;
            this.ColumnDataConsulta.Name = "ColumnDataConsulta";
            this.ColumnDataConsulta.ReadOnly = true;
            this.ColumnDataConsulta.Width = 125;
            // 
            // ColumnHoraConsulta
            // 
            this.ColumnHoraConsulta.HeaderText = "Hora da Consulta:";
            this.ColumnHoraConsulta.MinimumWidth = 6;
            this.ColumnHoraConsulta.Name = "ColumnHoraConsulta";
            this.ColumnHoraConsulta.ReadOnly = true;
            this.ColumnHoraConsulta.Width = 125;
            // 
            // ColumnNomeResponsável
            // 
            this.ColumnNomeResponsável.HeaderText = "Nome do Responsável";
            this.ColumnNomeResponsável.MinimumWidth = 6;
            this.ColumnNomeResponsável.Name = "ColumnNomeResponsável";
            this.ColumnNomeResponsável.ReadOnly = true;
            this.ColumnNomeResponsável.Width = 125;
            // 
            // ColumnNomePet
            // 
            this.ColumnNomePet.HeaderText = "Nome do Pet:";
            this.ColumnNomePet.MinimumWidth = 6;
            this.ColumnNomePet.Name = "ColumnNomePet";
            this.ColumnNomePet.ReadOnly = true;
            this.ColumnNomePet.Width = 125;
            // 
            // RegistroGeralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 724);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegistroGeralForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "RegistroGeral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnDataConsulta;
        private DataGridViewTextBoxColumn ColumnHoraConsulta;
        private DataGridViewTextBoxColumn ColumnNomeResponsável;
        private DataGridViewTextBoxColumn ColumnNomePet;
    }
}