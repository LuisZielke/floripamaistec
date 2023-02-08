//Importação de bibliotecas

//Nome da classe

//Declaração de método

//Declaração de variáveis
int opcao, numero1 = 0, numero2 = 0;
float resultado = 0;


//Entradas
Console.WriteLine("Escolha uma operação: \n\n" +
    "1 - soma\n2 - subtração\n3 - multiplicação\n4 - divisão \n\n" +
    "5 - Sair\n\nDigite a opção escolhida: ");

opcao = int.Parse(Console.ReadLine());

    //Processamento
    switch(opcao)
{
    //Bloco de instruções da estrutura condicional
    case 1:
        Console.WriteLine("operação somar.");
        Console.Write("Digite o numero 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2: ");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 + numero2;
        break;
    case 2:
        Console.WriteLine("operação subtrair.");
        break;
    case 3:
        Console.WriteLine("operação multiplicar.");
        break;
    case 4:
        Console.WriteLine("operação dividir.");
        break;
    case 5:
        Console.WriteLine("operação sair.");
        break;

}
Console.WriteLine("Resultado: " + resultado);

    //Saídas


