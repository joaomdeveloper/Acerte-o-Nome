using System;

namespace AcertePalavra
{
    class Program
    {
        static void Main(string[] args)
        {
            int tema, modo,tentativas=0;
            string sistema,usuario,secreto,DicaSecreta;
            char opc;

        modos:
            Console.Clear();
            Console.Write("Modos de Jogo: [1] - Single Player / [2] - Co-Op: ");
            modo = int.Parse(Console.ReadLine());
            if(modo == 1)
            {
                singlePlayer:
                Console.Clear();
                Console.Write("Temas disponiveis: [1] - Filmes, [2] - Frases, [3] - Games: ");
                tema = int.Parse(Console.ReadLine());
                if(tema == 1)
                {
                    do
                    {
                        Console.Clear();
                        sistema = "Os Trezentos de Esparta";
                        Console.WriteLine("Dica: Filme americano sobre a Batalha das Termópilas");
                        Console.Write("Digite o nome do filme: ");
                        usuario = Console.ReadLine();
                        tentativas++;
                    } while (usuario != sistema);
                    if(usuario == sistema)
                    {
                        Console.Clear();
                        Console.Write("Você Ganhou! A palavra era {0} e você tentou {1}x", sistema, tentativas);
                    }
                }else if(tema == 2)
                {
                    do
                    {
                        Console.Clear();
                        sistema = "Descartes";
                        Console.WriteLine("Dica: 'Penso, logo existo!'");
                        Console.Write("Digite o nome do autor: ");
                        usuario = Console.ReadLine();
                        tentativas++;
                    } while (usuario != sistema);
                    if (usuario == sistema)
                    {
                        Console.Clear();
                        Console.Write("Você Ganhou! A palavra era {0} e você tentou {1}x\n", sistema, tentativas);
                    }
                }
                else if(tema == 3)
                {
                    do
                    {
                        Console.Clear();
                        sistema = "God of War";
                        Console.WriteLine("Dica: Ligação com a religião grega!");
                        Console.Write("Digite o nome do jogo: ");
                        usuario = Console.ReadLine();
                        tentativas++;
                    } while (usuario != sistema);
                    if (usuario == sistema)
                    {
                        Console.Clear();
                        Console.Write("Você Ganhou! A palavra era {0} e você tentou {1}x\n", sistema, tentativas);
                    }
                }
                else{
                    Console.Write("O Tema selecionado não existe, deseja escolher novamente? [s/n]: ");
                    opc = char.Parse(Console.ReadLine());
                    if(opc == 's' | opc == 'S')
                    {
                        goto singlePlayer;
                    }
                    else{
                    }

                }
            }else if(modo == 2)
            {
                Console.Clear();
                Console.Write("Temas disponiveis: [1] - Filmes, [2] - Frases, [3] - Games: ");
                tema = int.Parse(Console.ReadLine());
                if (tema == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Não deixe seu colega visualizar a palavra: ");
                        secreto = Console.ReadLine();
                        Console.Write("Digite a dica para seu colega: ");
                        DicaSecreta = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Dioa: {0}\n", DicaSecreta);
                        Console.Write("Digite o nome do filme: ");
                        usuario = Console.ReadLine();
                        tentativas++;
                    } while (usuario != secreto);
                    if (usuario == secreto)
                    {
                        Console.Clear();
                        Console.Write("Você Ganhou! A palavra era {0} e você tentou {1} vezes", secreto, tentativas);
                    }
                }
                else if(tema == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Não deixe seu colega visualizar a palavra: ");
                        secreto = Console.ReadLine();
                        Console.Write("Digite a dica para seu colega: ");
                        DicaSecreta = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Dioa: {0}\n", DicaSecreta);
                        Console.Write("Digite o nome do autor: ");
                        usuario = Console.ReadLine();
                        tentativas++;
                    } while (usuario != secreto);
                    if (usuario == secreto)
                    {
                        Console.Clear();
                        Console.Write("Você Ganhou! A palavra era {0} e você tentou {1} vezes", secreto, tentativas);
                    }
                }else if(tema == 3)
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Não deixe seu colega visualizar a palavra: ");
                        secreto = Console.ReadLine();
                        Console.Write("Digite a dica para seu colega: ");
                        DicaSecreta = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Dioa: {0}\n", DicaSecreta);
                        Console.Write("Digite o nome do jogo: ");
                        usuario = Console.ReadLine();
                        tentativas++;
                    } while (usuario != secreto);
                    if (usuario == secreto)
                    {
                        Console.Clear();
                        Console.Write("Você Ganhou! A palavra era {0} e você tentou {1} vezes", secreto, tentativas);
                    }
                }
                else
                {
                    Console.Write("Não foi possível selecionar o tema escolhido!");
                }
            }
            else
            {
                Console.Write("Não foi possível selecionar o modo digitado! Deseja tentar selecionar novamente? [s/n]: ");
                opc = char.Parse(Console.ReadLine());
                if(opc == 's' | opc == 'S')
                {
                    goto modos;
                }
            }

            Console.Write("\nPrograma finalizado!");
        }
    }
}
