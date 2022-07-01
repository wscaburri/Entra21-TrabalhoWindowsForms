﻿using Newtonsoft.Json;

namespace Entra21_TrabalhoWindowsForms
{
    internal class MedicamentosServico
    {
        private List<Medicamentos> medicamentos;

        public MedicamentosServico()
        {
            medicamentos = new List<Medicamentos>();
        }

        public void Adicionar(Medicamentos medicamento)
        {
            medicamentos.Add(medicamento);

            SalvarArquivo();
        }

        public void Editar(Medicamentos medicamentoParaEditar)
        {
            for (var i = 0; i < medicamentos.Count; i++)
            {
                var medicamento = medicamentos[i];

                if (medicamento.Codigo == medicamentoParaEditar.Codigo)
                {
                    medicamento.Nome = medicamentoParaEditar.Nome;
                    medicamento.Tipo = medicamentoParaEditar.Tipo;
                    medicamento.Forma = medicamentoParaEditar.Forma;
                    medicamento.Recomendacao = medicamentoParaEditar.Recomendacao;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Medicamentos> ObterTodos()
        {
            return medicamentos;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;

            for (var i = 0; i < medicamentos.Count; i++)
            {
                var medicamento = medicamentos[i];

                ultimoCodigo = medicamento.Codigo;
            }

            return ultimoCodigo;
        }

        public Medicamentos ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < medicamentos.Count; i++)
            {
                var medicamento = medicamentos[i];

                if (medicamento.Codigo == codigo)
                    return medicamento;
            }

            return null;
        }

        public void Apagar(Medicamentos medicamentoParaApagar)
        {
            for (var i = 0; i < medicamentos.Count; i++)
            {
                var medicamento = medicamentos[i];

                if (medicamento.Codigo == medicamentoParaApagar.Codigo)
                {
                    medicamentos.Remove(medicamento);

                    SalvarArquivo();

                    return;
                }
            }
        }    

        private void LerArquivo()
        {
            if (File.Exists("medicamentos.json") == false)
                return;

            var medicamentosJson = File.ReadAllText("medicamentos.json");

            medicamentos = JsonConvert.DeserializeObject<List<Medicamentos>>(medicamentosJson);
        }

        private void SalvarArquivo()
        {
            var medicamentosJson = JsonConvert.SerializeObject(medicamentos);
            File.WriteAllText("medicamentos.json", medicamentosJson);
        }
    }
}