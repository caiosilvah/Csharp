//Faça um programa que o usuario informe o salario recebido e o total gasto. Devera ser exibido na tela "Gastos dentro do orçamento" caso o valor gasto nao ultrapassa o valor do salario e "Orçamento estourado" se o valor gasto ultrapassar o valor do salario.

Console.Write("Digite seu salário: ");
        float salario = float.Parse(Console.ReadLine());

        // Solicitar o total gasto
        Console.Write("Digite o total gasto: ");
        float totalGasto = float.Parse(Console.ReadLine());

        // Verificar se os gastos estão dentro do orçamento
        if (totalGasto <= salario)
        {
            Console.WriteLine("Gastos dentro do orçamento");
        }
        else{
            Console.WriteLine("Orçamento estourado");
        }


    
