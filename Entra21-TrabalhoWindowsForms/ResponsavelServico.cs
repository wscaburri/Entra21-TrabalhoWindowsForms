using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_TrabalhoWindowsForms
{
    public class ResponsavelServico
    {
        private List<Responsavel> responsaveis;

        public ResponsavelServico()
        {
            responsaveis = new List<Responsavel>();
        }

        private void LerArquivo()
        {
            if (File.Exists("responsaveis.json") == false)
            {
                return;
            }

            var responsavelJson = File.ReadAllText("responsaveis.json");

            responsaveis = JsonConvert.DeserializeObject<List<Responsavel>>(responsavelJson);

        }

        public List<Responsavel> ObterTodos()
        {
            return responsaveis;
        }

        public Responsavel ObterPorNomeResponsavel(string nomeResponsavel)
        {
            for (int i = 0; i < responsaveis.Count; i++)
            {
                var responsavel = responsaveis[i];

                if (responsavel.NomeCompleto == nomeResponsavel)
                {
                    return responsavel;
                }

            }
            return null;
        }

        public void Cadastrar(Responsavel responsavel)
        {
            responsaveis.Add(responsavel);
        }

        public void Editar(Responsavel responsavelParaEditar)
        {
            var responsavel = ObterPorCodigo(responsavelParaEditar.Codigo);

            responsavel.Tipo = responsavelParaEditar.Tipo;
            responsavel.NomeCompleto = responsavelParaEditar.NomeCompleto;
            responsavel.DataNascimento = responsavelParaEditar.DataNascimento;
            responsavel.Cpf = responsavelParaEditar.Cpf;
            responsavel.Cep = responsavelParaEditar.Cep;
            responsavel.Endereco = responsavelParaEditar.Endereco;
            responsavel.NumeroResidencia = responsavelParaEditar.NumeroResidencia;
            responsavel.Complemento = responsavelParaEditar.Complemento;
            responsavel.Cidade = responsavelParaEditar.Cidade;
            responsavel.Bairro = responsavelParaEditar.Bairro;
            responsavel.LocalDeTrabalho = responsavelParaEditar.LocalDeTrabalho;
            responsavel.DataDeCadastro = responsavelParaEditar.DataDeCadastro;
            responsavel.Telefone = responsavelParaEditar.Telefone;
            responsavel.Celular = responsavelParaEditar.Celular;
            responsavel.Email = responsavelParaEditar.Email;

            SalvarArquivo();


        }

        public void Apagar(int codigo)
        {
            for (int i = 0; i < responsaveis.Count; i++)
            {
                var responsavel = responsaveis[i];

                if (responsavel.Codigo == codigo)
                {
                    responsaveis.Remove(responsavel);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public int ObterPorUltimoCodigo()
        {
            var ultimoCodigo = 0;
            for (int i = 0; i < responsaveis.Count; i++)
            {
                var responsavel = responsaveis[i];

                ultimoCodigo = responsavel.Codigo;
            }
            return ultimoCodigo;
        }

        public Responsavel ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < responsaveis.Count; i++)
            {
                var responsavel = responsaveis[i];

                if (responsavel.Codigo == codigo)
                {
                    return responsavel;
                }

            }
            return null;
        }

        public void SalvarArquivo()
        {
            var responsavelJson = JsonConvert.SerializeObject(responsaveis);
            File.WriteAllText("responsaveis.json", responsavelJson);
        }
    }
}


