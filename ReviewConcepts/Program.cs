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

Console.WriteLine($"Ola, digite seu nome: ");
string nome = Console.ReadLine()!;
Console.WriteLine($"Agora digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!;

Console.WriteLine(@"
+--------------------------------------------+
|                                            |
|                                            |
|                  Seja bem                  |           
|                   Vindo!!!                 |
|                                            |
|                                            |
+--------------------------------------------+

");

        //Idade
        Console.WriteLine($"Digite sua idade: ");
        int idade = int.Parse (Console.ReadLine()!);

        //Dt Nascimento
        Console.WriteLine($"Digite sua data de Nascimento: ");
        string DataNascimento = Console.ReadLine()!;

        //E-mail
        Console.WriteLine($"Digite seu email: ");
        string email = Console.ReadLine();

        //Telefone
        Console.WriteLine($"Digite seu telefone: ");
        UInt128 telefone = UInt128.Parse (Console.ReadLine()!);

        //CPF
        Console.WriteLine($"Digite seu CPF: ");
        UInt128 cpf = UInt128.Parse (Console.ReadLine()!);

        //Endereco
        Console.WriteLine($"Digite seu endereço: ");
        string endereco = Console.ReadLine()!;

        //Estado Civil
        Console.WriteLine($"Qual o seu Estado Civil: ");
        string estadoCivil = Console.ReadLine()!;

        //Idade
        Console.WriteLine($"Em que ano voce nasceu");
        int anoNascimento = int.Parse(Console.ReadLine());
        int anoAtual = DateTime.Now.Year;
       

//mostrar esses dados cadastrados
// estruturas condicionais
// lacos de repeticao
// arrays
