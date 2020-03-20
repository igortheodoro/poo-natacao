using System;

namespace Natacao
{
    class Program
    {

        static void gerarAtleta(int tamanho, Banco bancoDados){

            int modalidade, tempo, idade;
            string nome;
            string vogais = "AEIOU";
            string consoante = "BCDFGHJKLMNPQRSTVWXYZ";
            Atleta nadador;
            
            for(int i = 0; i < tamanho; i++){

                Random random = new Random();
                
                 modalidade = random.Next(0,4);

                 tempo = random.Next(1,50);

                 idade = random.Next(1,80);

                 nome = "" + consoante[random.Next(0,21)] 
                 + vogais[random.Next(0,5)] 
                 + consoante[random.Next(0,21)] 
                 + vogais[random.Next(0,5)] 
                 + consoante[random.Next(0,21)] 
                 + vogais[random.Next(0,5)];

                 nadador = new Atleta(modalidade, tempo, idade, nome);
                 bancoDados.Inserir(nadador);
            }
        }
        static void Main(string[] args)
        {
            int tamanho;
            Banco bancoDados;

            Console.WriteLine("Quantos atletas deseja cadastrar?");
            tamanho = int.Parse(Console.ReadLine());

            // Loop se ultrapassar o limite
            while(tamanho >= 210){
            System.Console.WriteLine("No máximo 250 atletas.");
            Console.WriteLine("Quantos atletas deseja cadastrar?");
            tamanho = int.Parse(Console.ReadLine());
            }

            // Instanciando o objeto já com o parâmetro do construtor
            bancoDados = new Banco(tamanho);

            // Procedimento para gerar objetos com dados aleatórios
            gerarAtleta(tamanho, bancoDados);

            // Escrever na tela o que é pedido no exercício

            System.Console.WriteLine("Atletas da modalidade costas:");
            bancoDados.getAtletasCosta();

            System.Console.WriteLine("Atletlas da modalidade borboleta e com tempo menor que 40s:");
            bancoDados.getAtletasBorb();
            
            bancoDados.getAtletaVelho();

            System.Console.WriteLine("Quantidade de nadadores em cada modalidade: ");
            bancoDados.getAtletasModalidade();
        }
    }
}
