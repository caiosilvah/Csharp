// Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
//O número de pessoas que responderam SIM;
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados


        int countSim = 0;
        int countNao = 0;
        int countMulheresSim = 0;
        int countHomens = 0;
        int countHomensNao = 0;

        const int totalEntrevistados = 10;

        for (int i = 0; i < totalEntrevistados; i++)
        {
            Console.WriteLine($"Entrevistado {i + 1}:");                          
            Console.Write("Informe o sexo da pessoa (F/M): ");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("A pessoa gostou do produto? (S/N): ");
            char resposta = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Processando a entrada
            if (resposta == 'S')
            {
                countSim++;
                if (sexo == 'F')
                {
                    countMulheresSim++;
                }
            }
            else if (resposta == 'N')
            {
                countNao++;
                if (sexo == 'M')
                {
                    countHomens++;
                    countHomensNao++;
                }
                else if (sexo == 'F')
                {
                    countHomens++; // Contar mulheres para total de entrevistados
                }
            }
            else
            {
                Console.WriteLine("Resposta inválida, por favor digite 'S' ou 'N'.");
                i--; // Decrementa o contador para repetir a iteração
                continue;
            }

            // Contando homens, mesmo que não respondam "N"
            if (sexo == 'M' && resposta == 'S')
            {
                countHomens++; // Contar homens para total de entrevistados
            }
        }

        // Cálculo da porcentagem de homens que responderam NÃO
        double porcentagemHomensNao = countHomens > 0 ? (double)countHomensNao / countHomens * 100 : 0;
