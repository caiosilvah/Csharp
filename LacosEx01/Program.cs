//Faça um programa que rode 10 vezes e pergunte o sexo das pessoas e pergunte tambem se ela gosta de esportes. Ao final informe: Quantidade de pessoas do sexo feminino, Quantidade de pessoas do sexo masculino, A quantidade de pessoas que gosta de esportes, Total de entrevistados

int qntHomem = 0;
int qntMulher = 0;
int esportes = 0;
int qntNaoGostaDeEsportes = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qntDeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qntDeEntrevistados ; i++)
{
  Console.WriteLine($"Qual e o seu sexo? m/f"); 
  string sexo = Console.ReadLine();

  if (sexo == "f")
   {
   qntMulher++;
   }
    else
     {
    qntHomem++;
     }
  }

  Console.WriteLine($"Voce gosta de esportes ?");
  string Resposta = Console.ReadLine();

  if (Resposta == "sim")
{
    esportes++;
}
  else
{
    qntNaoGostaDeEsportes++;
}


        Console.WriteLine($"Quantidade de pessoas do sexo feminino: {qntHomem}");
        Console.WriteLine($"Quantidade de pessoas do sexo masculino: {qntMulher}");
        Console.WriteLine($"Quantidade de Entrevistados: {qntHomem + qntMulher}");
        Console.WriteLine($"Quantidade de pessoas que gostam de esportes: {esportes}");
        