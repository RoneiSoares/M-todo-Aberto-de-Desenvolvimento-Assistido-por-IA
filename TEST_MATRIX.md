# TEST_MATRIX

| Versão | Build | Smoke | Estrutural | Funcional | Aceitação | Referência |
|---|---|---|---|---|---|---|
| 1.0.0 | OK | OK | OK | OK | OK | GOLDEN |

## Cenários de referência

1. arquivo ausente → retorna padrão e não cria arquivo;
2. JSON válido → carrega `Theme` e `RetryCount` corretamente;
3. JSON inválido → retorna padrão e preserva exatamente o conteúdo original.

## Regra

Evidência de uma versão não valida automaticamente outra versão.
