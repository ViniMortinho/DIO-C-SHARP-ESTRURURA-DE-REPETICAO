# C SHARP > DIO - Estruturas de Repetição em C#

## FORMAÇÃO .NET DA [DIO](https://dio.me/curso-dot-net/AFY84PUWVGH8)


## REQUISITOS
- [.NET Core](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/download)
- [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

## Introdução

Estruturas de repetição, também conhecidas como loops, são usadas em programação para executar um mesmo bloco de código várias vezes, de acordo com uma condição ou um contador. Elas são úteis para simplificar o código, evitar repetições e automatizar tarefas.

## Como funcionam as estruturas de repetição?

Quando uma estrutura de repetição é executada, o bloco de código dentro dela é executado repetidamente até que uma condição seja satisfeita. A condição é verificada antes de cada iteração do loop. Se a condição for verdadeira, o bloco de código é executado. Se a condição for falsa, o loop é encerrado.

## Quais são os benefícios das estruturas de repetição?

As estruturas de repetição oferecem uma série de benefícios, incluindo:

* **Simplificam o código:** As estruturas de repetição permitem que você execute um mesmo bloco de código várias vezes com uma única linha de código. Isso pode simplificar o código e torná-lo mais fácil de manter.
* **Evitam repetições:** As estruturas de repetição podem ser usadas para evitar repetições no código. Isso pode tornar o código mais conciso e fácil de ler.
* **Automatizam tarefas:** As estruturas de repetição podem ser usadas para automatizar tarefas repetitivas. Isso pode economizar tempo e esforço.

## Quais são os tipos de estruturas de repetição?

Existem três tipos principais de estruturas de repetição em C#:

### For

* Usada quando sabemos o número exato ou aproximado de vezes que queremos repetir um bloco de código.

```c#

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

Esse exemplo imprime a seguinte saída:

5 x 0 = 0
5 x 1 = 5
5 x 2 = 10
...
5 x 10 = 50


Como você pode ver, o loop for começa com a inicialização do contador para 0. Em seguida, a condição verifica se o contador é menor ou igual a 10. Se a condição for verdadeira, o bloco de código dentro do loop é executado. O bloco de código dentro do loop calcula o produto do número e do contador e o exibe no console. Por fim, o contador é incrementado. O loop continua até que o contador atinja o valor 10. Nesse momento, a condição se torna falsa e o loop termina



Eu gostaria de agradecer ao professor do curso, Leonardo Buta, por compartilhar seus conhecimentos e experiências sobre o desenvolvimento .NET. Ele é um desenvolvedor .NET sênior e um tech expert da DIO, Eu aprendi muito com as suas aulas e espero continuar me aperfeiçoando nessa área. Muito obrigado, Buta!
[Leonardo Buta] (https://github.com/leonardo-buta)