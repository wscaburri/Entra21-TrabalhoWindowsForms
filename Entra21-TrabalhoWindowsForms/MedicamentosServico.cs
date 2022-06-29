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

            //SalvarArquivo();
        }

        public List<Medicamentos> ObterTodos()
        {
            return medicamentos;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;

            for (var i = 0; i < ultimoCodigo; i++)
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

                    //SalvarArquivo();

                    return;
                }
            }
        }
    }
}