//As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

 // Declaração da variável para a quantidade de maçãs
        int quantidadeMaças;
        double precoPorMaçã;

        // Leitura da quantidade de maçãs
        Console.Write("Digite o número de maçãs compradas: ");
        quantidadeMaças = Convert.ToInt32(Console.ReadLine());

        // Definindo o preço por maçã com base na quantidade
        if (quantidadeMaças < 12)
        {
            precoPorMaçã = 0.30; // Preço para menos de uma dúzia
        }
        else
        {
            precoPorMaçã = 0.25; // Preço para pelo menos uma dúzia
        }

        // Cálculo do valor total da compra
        double valorTotal = quantidadeMaças * precoPorMaçã;
