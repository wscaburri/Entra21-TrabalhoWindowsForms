using Newtonsoft.Json;

namespace Entra21_TrabalhoWindowsForms
{
    internal class VeterinarioServico
    {
        private List<Veterinario> veterinarios;

        public VeterinarioServico()
        {
            veterinarios = new List<Veterinario>();

            LerArquivo();
        }

        public void Adicionar(Veterinario veterinario)
        {
            veterinarios.Add(veterinario);

            SalvarArquivo();
        }

        public void Editar(Veterinario veterinarioParaEditar)
        {
            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                if (veterinario.Codigo == veterinarioParaEditar.Codigo)
                {
                    veterinario.Nome = veterinarioParaEditar.Nome;
                    veterinario.Cpf = veterinarioParaEditar.Cpf;
                    veterinario.DataAdmissao = veterinarioParaEditar.DataAdmissao;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Veterinario veterinarioParaApagar)
        {
            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                if (veterinario.Codigo == veterinarioParaApagar.Codigo)
                {
                    veterinarios.Remove(veterinario);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Veterinario> ObterTodos()
        {
            return veterinarios;
        }

        public Veterinario ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                if (veterinario.Codigo == codigo)
                    return veterinario;
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;

            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                ultimoCodigo = veterinario.Codigo;
            }

            return ultimoCodigo;
        }

        private void LerArquivo()
        {
            if (File.Exists("veterinarios.json") == false)
                return;

            var veterinariosJson = File.ReadAllText("veterinarios.json");

            veterinarios = JsonConvert.DeserializeObject<List<Veterinario>>(veterinariosJson);
        }

        private void SalvarArquivo()
        {
            var veterinariosJson = JsonConvert.SerializeObject(veterinarios);
            File.WriteAllText("veterinarios.json", veterinariosJson);
        }

        public Veterinario ObterPorNomeVeterinario(string nome)
        {
            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veretinario = veterinarios[i];

                if (veterinarios. == nome)
                {
                    return veretinario;
                }
            }
            return null;
        }
    }
}