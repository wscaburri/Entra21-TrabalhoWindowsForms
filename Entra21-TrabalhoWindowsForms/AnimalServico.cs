﻿using Newtonsoft.Json;

namespace Entra21_TrabalhoWindowsForms
{
    internal class AnimalServico
    {

        private List<Animal> animais;

        public AnimalServico()
        {
            animais = new List<Animal>();

            //LerArquivo();
        }

        public List<Animal> ObterTodos()
        {
            return animais;
        }
        public Animal ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < animais.Count; i++)
            {
                var animal = animais[i];
                if (animal.Codigo == codigo)
                {
                    return animal;
                }
            }
            return null;
        }
        public void Editar(Animal animalParaEditar)
        {
            var animal = ObterPorCodigo(animalParaEditar.Codigo);

            animal.Nome = animalParaEditar.Nome;
            animal.Porte = animalParaEditar.Porte;
            animal.Peso = animalParaEditar.Peso;
            animal.Idade = animalParaEditar.Idade;
            animal.Pelagem = animalParaEditar.Pelagem;
            animal.Raca = animalParaEditar.Raca;
            animal.Doencas = animalParaEditar.Doencas;
            animal.Vacinas = animalParaEditar.Vacinas;
            animal.Alergias = animalParaEditar.Alergias;

            SalvarArquivo();
        }

        public void Cadastrar(Animal animal)
        {

           animais.Add(animal);
        }
        public void Apagar(int codigo)
        {
            for (int i = 0; i < animais.Count; i++)
            {
                var animal = animais[i];

                if (animal.Codigo == codigo)
                {
                    animais.Remove(animal);

                    SalvarArquivo();

                    return;
                }
            }
        }
        private void SalvarArquivo()
        {
            var animalJson = JsonConvert.SerializeObject(animais);
            File.WriteAllText("animal.json", animalJson);
        }
        private void LerArquivo()
        {
            if (File.Exists("animais.json") == false)
                return;

            var animaisJson = File.ReadAllText("animais.json");

            animais = JsonConvert.DeserializeObject<List<Animal>>(animaisJson);


        }

    }
}
