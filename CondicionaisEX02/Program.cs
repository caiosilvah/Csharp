//Desenvolva um programa que recebe do usuario, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitoria foi do primeiro time ou segundo time.

        Console.Write("Digite o número de gols do primeiro time: ");
        int golsTime1 = int.Parse(Console.ReadLine());

        // Solicitar o placar do segundo time
        Console.Write("Digite o número de gols do segundo time: ");
        int golsTime2 = int.Parse(Console.ReadLine());

        // Verificar o resultado do jogo
        if (golsTime1 > golsTime2)
        {
            Console.WriteLine("A vitória foi do primeiro time.");
        }
        else if (golsTime1 < golsTime2)
        {
            Console.WriteLine("A vitória foi do segundo time.");
        }
        else{
            Console.WriteLine("O jogo terminou em empate.");
        }