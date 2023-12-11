using ExemplosFundamentos.models;

// Um loop for é uma estrutura de controle que permite repetir um bloco de código um número específico de vezes.
// Ele consiste em três partes: inicialização, condição e incremento.

// Número que será usado na operação de multiplicação.
int numero = 5;

// O loop for começa com a inicialização do contador para 0.
// A condição verifica se o contador é menor ou igual a 10.
// Se a condição for verdadeira, o bloco de código dentro do loop é executado e o contador é incrementado.
// Isso continua até que a condição se torne falsa, momento em que o loop termina.
for(int contador = 0; contador <= 10; contador++)
{
    // Dentro do loop, calculamos o produto do número e do contador e o exibimos no console.
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
