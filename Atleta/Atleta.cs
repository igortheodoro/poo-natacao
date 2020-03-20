using System;

namespace Natacao
{
    class Atleta
    {
        private int Modalide, MelhorTempo, Idade;
        private string Nome;

        public Atleta(int Modalidade, int MelhorTempo, int Idade, string Nome){
          this.Modalide = Modalidade;
          this.MelhorTempo = MelhorTempo;
          this.Idade = Idade;
          this.Nome = Nome;
        }

        public int getModalidade(){
          return Modalide;
        }

        public string getNome(){
          return Nome;
        }

        public int getTempo(){
          return MelhorTempo;
        }

        public int getIdade(){
          return Idade;
        }

    }
}
