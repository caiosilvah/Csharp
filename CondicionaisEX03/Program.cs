// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     
 //− Triângulo    Equilátero:    possui    os    3    lados    iguais.     
 //− Triângulo    Isóscele:    possui    2    lados    iguais.     
//− Triângulo    Escaleno:    possui    3    lados    diferentes.

  Console.Write("Digite o valor do primeiro lado: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        double lado3 = double.Parse(Console.ReadLine());

        // Verificar se é um triângulo válido
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            // Verificar o tipo de triângulo
            if (lado1 == lado2 && lado2 == lado3) {
                Console.WriteLine("O triângulo é Equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3){
                Console.WriteLine("O triângulo é Isósceles.");
            }
            else {
                Console.WriteLine("O triângulo é Escaleno.");
            }
        }
        else {
            Console.WriteLine("Os valores fornecidos não formam um triângulo válido.");
        }