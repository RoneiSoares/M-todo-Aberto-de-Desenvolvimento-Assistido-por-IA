# PROJECT_STATE

## Produto

LabCalc

## Estado atual

- versão em desenvolvimento: `1.1.0-dev`
- branch-base do produto: `laboratorio-metodo-ia`
- referência funcional conhecida / GOLDEN: `1.0.0`
- commit da referência funcional: `832ecbab63f73367ea326b58eb7002ead44c2249`
- a versão `1.1.0-dev` NÃO substitui a GOLDEN

## Comportamento funcional conhecido

Na GOLDEN `1.0.0`:

`Calculator.RoundForDisplay(valor, casas)` arredonda empates para longe de zero.

Exemplo funcionalmente validado:

`RoundForDisplay(2.345m, 2) == 2.35m`

## Estado da 1.1.0-dev

Existe uma regressão conhecida no arredondamento de valores exatamente no ponto médio.

O código em desenvolvimento usa comportamento de empate para número par, o que pode produzir resultado diferente da referência funcional.

Exemplo esperado pela especificação:

`RoundForDisplay(2.345m, 2) == 2.35m`

A versão em desenvolvimento ainda não foi promovida nem funcionalmente validada.

## Ambiente funcional definido

Para este laboratório, a validação funcional mínima consiste em:
1. executar o smoke automatizado;
2. executar o aplicativo console;
3. observar que o cenário `2.345` com 2 casas produz `2.35`.

## Regra de segurança

Não altere a GOLDEN apenas porque a versão nova compila ou porque possui número maior.
