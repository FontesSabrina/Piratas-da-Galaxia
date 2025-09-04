using System;
using System.Collections.Generic;

namespace PiratasDaGalaxia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo(a) a Piratas da Galáxia!");
            Console.WriteLine("----------------------------------");

            // 0. ORIENTAÇÃO A OBJETOS: Objeto vs Instância
            // 'heroes' é uma lista que irá conter *instâncias* de heróis.
            var heroes = new List<Hero>
            {
                // 1. ABSTRAÇÃO: A classe 'Hero' (e suas filhas como Guardian, Adventurous, Gentleman)
                // é uma abstração de um "personagem jogável" no seu jogo. Ela define o que
                // um herói "é" (nome, tipo, atributos) e o que ele "faz" (atacar, etc.).
                // Cada 'new Hero()', 'new Guardian()', etc., cria uma *instância* (um objeto concreto)
                // da respectiva classe.
                new Hero("Cecília Cerulius", "Capitã do Vento Estelar", 100, 75, 85, 60, 30, 45),
                // 2. HERANÇA: 'Guardian' é um tipo de 'Hero'. Ele herda as características
                // e comportamentos definidos na classe 'Hero'.
                new Guardian("Ivy Skye", "Guardiã Astral", 100, 20, 35, 50, 80, 80),
                // 2. HERANÇA: 'Adventurous' herda de 'Hero'.
                new Adventurous("Soren", "O Aventureiro", 100, 80, 70, 75, 60, 85),
                // 2. HERANÇA: 'Gentleman' herda de 'Hero'.
                new Gentleman("Nero", "Cavalheiro da Galáxia", 100, 85, 65, 55, 65, 90)
            };

            Console.WriteLine("\nEscolha seu herói:");
            for (int i = 0; i < heroes.Count; i++)
            {
                // 4. POLIMORFISMO: Embora 'heroes' seja uma lista de 'Hero', ela pode conter
                // objetos de suas classes filhas (Guardian, Adventurous, Gentleman).
                // Ao acessar 'heroes[i].Name' ou 'heroes[i].HeroType', o sistema sabe qual
                // 'Name' ou 'HeroType' específico de cada objeto deve exibir, pois todos
                // compartilham essa interface comum da classe 'Hero'.
                Console.WriteLine($"{i + 1}. {heroes[i].Name} - {heroes[i].HeroType}");
            }

            Console.Write("\nDigite o número do seu herói: ");
            if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > heroes.Count)
            {
                Console.WriteLine("Escolha inválida. O programa será encerrado.");
                return;
            }
            Hero heroiDoJogador = heroes[escolha - 1];

            Console.Clear();
            Console.WriteLine($"Você escolheu: {heroiDoJogador.Name}!");
            Console.WriteLine("A aventura começa!");

            Random dado = new Random();
            int rodadaAtual = 1;
            int totalRodadas = 6;

            while (rodadaAtual <= totalRodadas)
            {
                Console.WriteLine($"\n--- Rodada {rodadaAtual} de {totalRodadas} ---");
                // 1. ABSTRAÇÃO (Propriedades): 'Health', 'Strength', 'Agility', 'Vitality',
                // 'Intelligence', 'Charisma' são as propriedades que representam o estado
                // abstrato de um herói.
                Console.WriteLine($"Vida atual de {heroiDoJogador.Name}: {heroiDoJogador.Health}");
                Console.WriteLine($"Atributos atuais: Força({heroiDoJogador.Strength}) | Agilidade({heroiDoJogador.Agility}) | Vitalidade({heroiDoJogador.Vitality}) | Inteligência({heroiDoJogador.Intelligence}) | Carisma({heroiDoJogador.Charisma})");
                
                Console.WriteLine("\nNavegando pela galáxia...");
                Console.WriteLine("Pressione Enter para rolar o dado e ver o que acontece...");
                Console.ReadLine();

                int resultadoDado = dado.Next(1, 7);
                Console.WriteLine($"O dado rolou: {resultadoDado}!");

                // 3. ENCAPSULAMENTO (Regras de Negócio): As regras de como os atributos
                // do herói são modificados (e.g., "perdeu 20 de Vida", "ganhou 10 de Agilidade")
                // estão "encapsuladas" dentro dos blocos 'case' do switch.
                // O código externo ao 'switch' não precisa saber os detalhes de como
                // o buraco negro afeta a agilidade, apenas que o evento "buraco negro" ocorre.
                switch (resultadoDado)
                {
                    case 1:
                    case 2:
                        Console.WriteLine($"Você entra em um buraco negro! Seus equipamentos falham.");
                        heroiDoJogador.Health -= 30;
                        heroiDoJogador.Agility -= 5;
                        Console.WriteLine("Você perdeu 20 de Vida e 5 de Agilidade.");
                        break;
                    case 3:
                        Console.WriteLine("Você encontra um acampamento de piratas amigáveis e consegue um atalho!");
                        heroiDoJogador.Health += 10;
                        heroiDoJogador.Charisma += 5;
                        Console.WriteLine("Você ganhou 10 de Vida e 5 de Carisma.");
                        break;
                    case 4:
                        Console.WriteLine("Um monstro espacial ataca a Aurora! Prepare-se para o combate!");
                        heroiDoJogador.Health -= 40;
                        heroiDoJogador.Strength -= 5;
                        Console.WriteLine("Você perdeu 30 de Vida e 5 de Força.");
                        break;
                    case 5:
                        Console.WriteLine("Você encontra um baú de tesouro! Ele contém equipamentos valiosos.");
                        heroiDoJogador.Agility += 10;
                        heroiDoJogador.Intelligence += 10;
                        Console.WriteLine("Você ganhou 10 de Agilidade e 10 de Inteligência.");
                        break;
                    case 6:
                        Console.WriteLine("Você encontra um antigo templo celestial e absorve sua energia!");
                        heroiDoJogador.Health += 30;
                        heroiDoJogador.Intelligence += 10;
                        heroiDoJogador.Charisma += 5;
                        Console.WriteLine("Você ganhou 30 de Vida, 10 de Inteligência e 5 de Carisma!");
                        break;
                }

                // As verificações de derrota também são parte das regras de negócio encapsuladas.
                if (heroiDoJogador.Health <= 0)
                {
                    Console.WriteLine($"\n{heroiDoJogador.Name} foi derrotado por falta de Vida! Fim de jogo.");
                    break;
                }
                if (heroiDoJogador.Strength <= 0 || heroiDoJogador.Agility <= 0 || heroiDoJogador.Vitality <= 0 || heroiDoJogador.Intelligence <= 0 || heroiDoJogador.Charisma <= 0)
                {
                    Console.WriteLine($"\n{heroiDoJogador.Name} perdeu um atributo importante e não pode continuar a aventura. Fim de jogo.");
                    break;
                }

                rodadaAtual++;
            }

            if (heroiDoJogador.Health > 0 && heroiDoJogador.Strength > 0 && heroiDoJogador.Agility > 0 && heroiDoJogador.Vitality > 0 && heroiDoJogador.Intelligence > 0 && heroiDoJogador.Charisma > 0)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine($"Parabéns! {heroiDoJogador.Name} sobreviveu à aventura!");
                Console.WriteLine($"Vida restante: {heroiDoJogador.Health}");
                Console.WriteLine("----------------------------------");
            }
            
            Console.WriteLine("\nFim do programa. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}