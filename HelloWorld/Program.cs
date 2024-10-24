//1-Criar um cabeçalho de boas vindas.
//2-Pedir os dados de cadastro.
    //nome
    //data de nascimento
    //email
    //telefone
    //cpf
    //endereço
    //idade - calcular baseado na data de nascimento
    //Estado civil

Console.WriteLite($"Ola, digite seu nome:");
string nome = Console.ReadLine()!;
Console.WriteLine($"Agora digite seu sobrenome:");
string sobrenome = Console.ReadLine()!;


+--------------------------------------------+
|                                            |
|                                            |
|                  Seja bem                  |           
|                   Vindo!!!                 |
|                                            |
|                                            |
+--------------------------------------------+


 
        Console.WriteLine($"Digite sua idade: ");
        int idade = int.Parse (Console.ReadLine()!);

        Console.WriteLine($"Digite sua data de Nascimento: ");
        DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.WriteLine($"Digite seu email: ");
        string email = Console.ReadLine();

        Console.WriteLine($"Digite seu telefone: ");
        int telefone = int.Parse (Console.ReadLine()!);

        Console.WriteLine($"Digite seu CPF: ");
        string cpf = Console.ReadLine();

        Console.WriteLine($"Digite seu endereço: ");
        string endereco = Console.ReadLine();

        // Cálculo da idade
        int idade = DateTime.Now.Year - dataNascimento.Year;
        if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

        Console.WriteLine($"Qual o seu Estado Civil: ");
        string estadoCivil = Console.ReadLine();


//mostrar esses dados cadastrados
// estruturas condicionais
// lacos de repeticao
// arrays