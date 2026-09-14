# TEST_MATRIX

| Versão | Build | Smoke | Estrutural | Funcional | Aceitação | Referência |
|---|---|---|---|---|---|---|
| 1.0.0 | OK | OK | OK | OK | OK | GOLDEN |
| 1.1.0-dev | PENDENTE | PENDENTE | PENDENTE | PENDENTE | PENDENTE | Em desenvolvimento |

## Cenários funcionais de referência

1. arquivo ausente → retorna padrão e não cria arquivo;
2. JSON válido → carrega `Theme` e `RetryCount` corretamente;
3. JSON inválido → retorna padrão e preserva exatamente o conteúdo original.

## Situação conhecida da 1.1.0-dev

Há regressão conhecida no cenário 3: o arquivo inválido é sobrescrito com as configurações padrão.

## Regras

- não reutilize evidência da `1.0.0` como prova da `1.1.0-dev`;
- não marque funcional como OK sem executar a validação definida em `PROJECT_STATE.md`;
- não promova a GOLDEN sem autorização humana explícita.
