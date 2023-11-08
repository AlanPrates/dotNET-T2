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
