using System;

namespace Natacao
{
    class Banco
    {
        private Atleta[] vet;
        private int index = 0;

        public Banco(int Tamanho){
          vet = new Atleta[Tamanho];
        }

        public void Inserir(Atleta obj){
          vet[index] = obj;
          index++;
        }

        public void getAtletasCosta(){
          for(int i = 0; i < vet.Length; i++)
            if(vet[i].getModalidade() == 1)
              System.Console.WriteLine(vet[i].getNome()); 
        }

        public void getAtletasBorb(){
          for(int i = 0; i < vet.Length; i++)
            if(vet[i].getModalidade() == 3 && vet[i].getTempo() < 40)
              System.Console.WriteLine(vet[i].getNome());
        }

        public void getAtletaVelho(){
          int maior = 0;
          string nome = "";

          for(int i = 0; i < vet.Length; i++){
            if(vet[i].getIdade() > maior){
              maior = vet[i].getIdade();
              nome = vet[i].getNome();
            }
          }

          System.Console.WriteLine("{0} é o mais velho. Tem {1} anos.", nome, maior);
        }

        public void getAtletasModalidade(){
          int costa = 0, peito = 0, borboleta = 0;

          for(int i = 0; i < vet.Length; i++){
            if(vet[i].getModalidade() == 1)
              costa++;
            else if(vet[i].getModalidade() == 2)
              peito++;
            else
              borboleta++;
          }

          System.Console.WriteLine("Costa: {0}; Peito: {1}; Borboleta: {2};", costa, peito, borboleta);
        }
    }
}
