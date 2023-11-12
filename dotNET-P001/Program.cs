// variável do tipo double em um tipo int, você pode usar a conversão explícita. 
// A parte fracionária será truncada, ou seja, descartada. Se a parte fracionária 
// não puder ser representada em um int, ela será arredondada para o número inteiro 
// mais próximo (para baixo em direção a zero).

double numeroDouble = 10.8;
int numeroInteiro = (int)numeroDouble;

Console.WriteLine(numeroInteiro); // O resultado será 10

// Definindo as variáveis x e y
int x = 10;
int y = 3;

// Realizando as operações matemáticas
int soma = x + y; // Soma de x e y
int subtracao = x - y; // Subtração de x por y
int multiplicacao = x * y; // Multiplicação de x e y
double divisao = (double)x / y; // Divisão de x por y, convertendo para double para obter resultado decimal se necessário

// Exibindo os resultados
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");

// Definindo as variáveis a e b
int a = 5;
int b = 8;

// Verificando se a é maior que b
bool aMaiorQueB = a > b;

// Exibindo o resultado
Console.WriteLine($"A é maior que B: {aMaiorQueB}");
// Definindo as strings str1 e str2
string str1 = "Hello";
string str2 = "World";

// Verificando se as strings são iguais
bool saoIguais = str1 == str2;

// Exibindo o resultado
Console.WriteLine($"As strings são iguais: {saoIguais}");

// Definindo as variáveis booleanas condicao1 e condicao2
bool condicao1 = true;
bool condicao2;
// Definindo as variáveis num1, num2 e num3
int num1 = 7;
int num2 = 3;
int num3 = 10;

// Verificando se num1 é maior que num2 e se num3 é igual a num1 + num2
bool resultado = num1 > num2 && num3 == num1 + num2;

// Exibindo o resultado
Console.WriteLine($"A expressão é verdadeira: {resultado}");
