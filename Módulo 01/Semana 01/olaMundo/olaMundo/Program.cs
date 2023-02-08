// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numeroInteiro = 10; // Declaração de variável inteira, recebe o valor 10
long numeroMaior = 1099999L;//Declaração de variável long, recebendo valor 1099999
float numeroQuebrado = 6.8f;//Declaração variável de tipo float,
double numeroQuebradomaior = 101.9999999D;// declaração de variavel do tipo double
char letra = 'z';// Char recebendo um caracter
string texto = "A turma estreito é a melhor."; // Recebendo texto
bool variavelBooleana = true; //Booleano, true or false
DateTime data = DateTime.Now;//datetime declara até os segundos do momento da aplicação
DateTime outraData = new DateTime(2023, 01, 31);//Instanciando 
texto.ToUpper();//Convertendo o texto para letras maiusculas
Console.WriteLine("Frase com letras maiusculas: "+texto.ToUpper());

string nomeCompleto; //Declaração de variável
Console.WriteLine ("Digite o seu nome: ");//Instrução ao usuário
nomeCompleto = Console.ReadLine();//aguardando o usuario digitar no terminal
Console.WriteLine("O seu nome é: " + nomeCompleto);//Saída de dados concatenando texto com variável


