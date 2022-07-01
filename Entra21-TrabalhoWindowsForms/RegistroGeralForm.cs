﻿using System;
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
    public partial class RegistroGeralForm : Form
    {
        private AgendamentoConsultaForm agendamentoConsultaForm;
        private AgendamentoConsultaServico 
        public RegistroGeralForm()
        {
            InitializeComponent();

            agendamentoConsultaForm = new AgendamentoConsultaForm();
        }

        private void PreencherDataGridViewComAgendamentos()
        {
            var agendamentos = agendamentoConsultaServico.ObterTodos();

            dataGridViewAgendamentoConsulta.Rows.Clear();

            for (var i = 0; i < agendamentos.Count; i++)
            {
                var agendamento = agendamentos[i];

                dataGridViewAgendamentoConsulta.Rows.Add(new object[]
                {
                        agendamento.Codigo,
                        agendamento.DataConsulta.ToString("dd/MM/yyyy"),
                        agendamento.HoraConsulta,
                        agendamento.NomeResponsavel,
                        agendamento.NomePet,
                        agendamento.NomeVeterinario
                });
            }

            dataGridViewAgendamentoConsulta.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
