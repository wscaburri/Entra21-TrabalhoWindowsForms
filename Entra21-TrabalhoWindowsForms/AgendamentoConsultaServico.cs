using Newtonsoft.Json;

namespace Entra21_TrabalhoWindowsForms
{
    internal class AgendamentoConsultaServico
    {
        private List<AgendamentoConsulta> agendamentosConsultas;

        public AgendamentoConsultaServico()
        {
            agendamentosConsultas = new List<AgendamentoConsulta>();

            LerArquivo();
        }

        public void Adicionar(AgendamentoConsulta agendamentoConsulta)
        {
            agendamentosConsultas.Add(agendamentoConsulta);

            SalvarArquivo();
        }

        public void Editar(AgendamentoConsulta agendamentoConsultaParaEditar)
        {
            for (var i = 0; i < agendamentosConsultas.Count; i++)
            {
                var agendamentoConsulta = agendamentosConsultas[i];

                if (agendamentoConsulta.Codigo == agendamentoConsultaParaEditar.Codigo)
                {
                    agendamentoConsulta.DataConsulta = agendamentoConsultaParaEditar.DataConsulta;
                    agendamentoConsulta.HoraConsulta = agendamentoConsultaParaEditar.HoraConsulta;
                    agendamentoConsulta.NomeResponsavel = agendamentoConsultaParaEditar.NomeResponsavel;
                    agendamentoConsulta.NomePet = agendamentoConsultaParaEditar.NomePet;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(AgendamentoConsulta agendamentoConsultaParaApagar)
        {
            for (var i = 0; i < agendamentosConsultas.Count; i++)
            {
                var agendamentoConsulta = agendamentosConsultas[i];

                if (agendamentoConsulta.Codigo == agendamentoConsultaParaApagar.Codigo)
                {
                    agendamentosConsultas.Remove(agendamentoConsulta);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<AgendamentoConsulta> ObterTodos()
        {
            return agendamentosConsultas;
        }

        public AgendamentoConsulta ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < agendamentosConsultas.Count; i++)
            {
                var agendamentoConsulta = agendamentosConsultas[i];

                if (agendamentoConsulta.Codigo == codigo)
                    return agendamentoConsulta;
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;

            for (var i = 0; i < agendamentosConsultas.Count; i++)
            {
                var agendamentoConsulta = agendamentosConsultas[i];

                ultimoCodigo = agendamentoConsulta.Codigo;
            }

            return ultimoCodigo;
        }

        private void LerArquivo()
        {
            if (File.Exists("agendamento.json") == false)
                return;

            var agendamentosJson = File.ReadAllText("agendamento.json");

            agendamentosConsultas = JsonConvert.DeserializeObject<List<AgendamentoConsulta>>(agendamentosJson);
        }

        private void SalvarArquivo()
        {
            var agendamentosJson = JsonConvert.SerializeObject(agendamentosConsultas);
            File.WriteAllText("agendamento.json", agendamentosJson);
        }
    }
}