# 08 — Evidências e testes

## BUILD

Prova:
- compilação bem-sucedida.

Não prova:
- regra de negócio correta;
- integração real;
- comportamento visual;
- ausência de regressão.

## SMOKE / teste lógico

Prova uma regra ou caminho básico isolado.

Exemplos:
- função retorna valor esperado;
- comando está registrado;
- regra hidráulica produz cálculo previsto.

## ESTRUTURAL

Verifica composição/configuração.

Exemplos:
- arquivos presentes;
- assembly contém comando;
- configuração foi persistida;
- artefato contém estrutura esperada.

## FUNCIONAL

Executa o produto em seu ambiente real ou equivalente representativo.

Exemplos:
- carregar plugin no Civil 3D;
- abrir aplicação desktop;
- executar fluxo em browser real;
- chamar serviço real de homologação.

## ACEITAÇÃO HUMANA

Confirma que o resultado resolve a necessidade real.

## Matriz de validação

Use:

| Versão | Build | Smoke | Estrutural | Funcional | Aceitação |
|---|---|---|---|---|---|

## Regra de não substituição

Nenhuma coluna substitui outra.

## Estados recomendados

- `OK`;
- `FALHA`;
- `PENDENTE`;
- `N/A`;
- `WARN`;
- `BLOCK`.

## Evidência mínima para afirmar “funcional”

Deve existir execução no ambiente definido pela política do projeto.

Se essa execução não ocorreu, use “funcional pendente”.
