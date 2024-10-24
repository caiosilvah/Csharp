//Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário.     A     senha     válida     é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     
//ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
//ACESSO    NEGADO    caso    a    senha    seja    inválida

  // Definindo a senha válida
        const string senhaValida = "1234";
        
        // Leitura da senha fornecida pelo usuário
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();
        
        // Verificando a validade da senha
        if (senha == senhaValida)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }