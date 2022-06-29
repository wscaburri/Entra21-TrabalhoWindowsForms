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
        public void ObterPorUltimoCodigo()
        {

        }
        public void Editar()
        {

        }

        public void Cadastrar()
        {

        }
        public bool ValidarCpf(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool valido = true;
            for (int i = 1; i < 11 && valido; i++)
                if (valor[i] != valor[0])
                    valido = false;

            if (valido && valor == "12345678909")
                return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1  && resultado == 0)
              {
                if (numeros[9] != 0)
                    return false;
            }


            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;
            return true;
        }
    }
}


