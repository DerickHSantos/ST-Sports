using System;
using System.Linq;
using System.Collections.Generic;

namespace Selva_de_Tecnologia_Esports
{
    public static class Program
    {
    	//Função para inserir o nome do torneio,
    	//quantidade de participantes
    	//e o nome dos participantes
    	//Além do chaveamento de forma aleatória
        private static void Conceito()
        {
        	//Setup
        	int j = 0;
        	
        	//Cabeçalho
            Console.WriteLine("\t\t\t\t\tBem-vindo a Plataforma de Torneios '\tSelva de Tecnologia'");
            
            //Leitura do nome do torneio
            Console.WriteLine("Insira aqui o nome do torneio: ");
            string torneio = Console.ReadLine();
            
            //Leitura da quantidade de participantes
            Console.WriteLine("\t\tInsira aqui a quantidade de participantes: ");
            if (!int.TryParse(Console.ReadLine(), out int participantes))
            {
                Console.WriteLine("A quantidade de participantes deve ser um número inteiro");
                return;
            }
            string[] nomes = new string[participantes];
            
            //Leitura do nome de todos os participantes
            for (int i = 0; i < participantes; i++)
            {
                j = i + 1;
                Console.WriteLine("\t\tInsira o nome do " + j + " participante: ");
                nomes[i] = Console.ReadLine();
            }
	
            Console.Clear();
            
            //Geração de números aleatórios
            int rndCount = 0;
            Random random = new Random();
            
            //Uso de Hashset para garantir que os números gerados sejam únicos
            HashSet<int> hashRng = new HashSet<int>();

            while (hashRng.Count < participantes)
            {
                int rng = random.Next(participantes);
                if (!hashRng.Contains(rng))
                {
                    hashRng.Add(rng);
                }
            }

			//Transferir os números do Hashset para Array
            int[] listRng = hashRng.ToArray();

			//Mostrar o Chaveamento
            Console.WriteLine("\n\t\t\t\t\t\tChaveamento");
            
            //Setup
            j = 0;
            int k = 1;
            
            //Loop
            for (int i = 0; i < participantes / 2; i++)
            {
            	//Setup
                int l = i + 1;
                
                //Mostrar as partidas
                Console.WriteLine("\n\t\t\t\t\t\tPartida " + l);
                Console.WriteLine("\t\t\t\t\t\t\t " + nomes[listRng[j]] + " vs " + nomes[listRng[k]]);
                
                //Aumentar de 2 em 2 para não repetir participantes
                j = j + 2;
                k = k + 2;
            }
        }

        public static void Main()
        {
        	//Chamar a função
            Conceito();
        }
    }
}
//Produzido por: Selva de Tecnologia
//Programador Chefe: Dérick Heliodoro dos Santos
//Criado em 13/02/2023