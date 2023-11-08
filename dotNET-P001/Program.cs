// variável do tipo double em um tipo int, você pode usar a conversão explícita. 
// A parte fracionária será truncada, ou seja, descartada. Se a parte fracionária 
// não puder ser representada em um int, ela será arredondada para o número inteiro 
// mais próximo (para baixo em direção a zero).

double numeroDouble = 10.8;
int numeroInteiro = (int)numeroDouble;

Console.WriteLine(numeroInteiro); // O resultado será 10

