# TEST_MATRIX

| Versão | Build | Smoke | Funcional | Aceitação | Referência |
|---|---|---|---|---|---|
| 1.0.0 | OK | OK | OK | OK | GOLDEN |
| 1.1.0-dev | PENDENTE | PENDENTE | PENDENTE | PENDENTE | Em desenvolvimento |

## Cenários funcionais de referência

- `2.344` com 2 casas → `2.34`
- `2.345` com 2 casas → `2.35`
- `-2.345` com 2 casas → `-2.35`

## Situação conhecida da 1.1.0-dev

Há regressão conhecida em valores de empate. As evidências da versão em desenvolvimento devem ser obtidas novamente após qualquer correção.

## Regra

- não reutilize evidência da `1.0.0` como prova da `1.1.0-dev`;
- não marque funcional como OK sem executar a validação definida em `PROJECT_STATE.md`;
- não promova a GOLDEN sem autorização humana explícita.
