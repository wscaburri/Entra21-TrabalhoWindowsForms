using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_TrabalhoWindowsForms
{
    public class Responsavel
    {
        public int Codigo;
        public string Tipo;
        public string NomeCompleto;
        public DateTime DataNascimento;
        public string Cpf;
        public string Cep;
        public string Endereco;
        public string NumeroResidencia;
        public string Complemento;
        public string Cidade;
        public string Bairro;
        public string LocalDeTrabalho;
        public DateTime DataDeCadastro;
        public string Telefone;
        public string Celular;
        public string Email;
        public Animal Pet;

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

            if (valido || valor == "12345678909")
                return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
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
