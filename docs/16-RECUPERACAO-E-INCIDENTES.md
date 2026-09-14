# 16 — Recuperação e incidentes

Erros acontecem. O método deve dizer como recuperar sem destruir evidência.

## Regra principal

> Primeiro entenda o estado. Depois recupere.

Nunca comece um incidente apagando, sobrescrevendo ou reescrevendo estado apenas para “voltar ao normal”.

## Caso 1 — Trabalhei na branch errada

1. pare novas alterações;
2. registre o estado atual e a branch;
3. identifique arquivos e commits envolvidos;
4. preserve as mudanças;
5. mova ou reaplique o trabalho para a branch correta usando a opção mais reversível disponível;
6. só limpe a branch errada depois de confirmar que o trabalho foi preservado.

## Caso 2 — Alterações locais inesperadas

Não descarte alterações desconhecidas para continuar.

Primeiro determine:
- quem ou qual tarefa gerou as alterações;
- se estão persistidas;
- se pertencem ao seu escopo.

Se não pertencerem, isole sua tarefa sem sobrescrevê-las.

## Caso 3 — Build quebrou após a mudança

1. confirme que ambiente e dependências estão presentes;
2. confirme se o erro foi introduzido pela alteração;
3. reduza o problema ao menor conjunto possível;
4. corrija sem expandir o escopo desnecessariamente;
5. reexecute build e testes relevantes.

Não marque a tarefa como concluída com build quebrado, salvo quando o objetivo explícito era apenas investigação.

## Caso 4 — Smoke passou e funcional falhou

O teste funcional tem precedência para a afirmação de comportamento real.

Registre:
- `SMOKE OK`;
- `FUNCIONAL FALHOU`;
- cenário da falha;
- artefato ou versão usada.

Não altere a matriz para esconder a inconsistência.

## Caso 5 — Versão nova regrediu

Mantenha a referência funcional/GOLDEN anterior.

A versão nova volta ao estado de desenvolvimento ou candidata até que a regressão seja corrigida e validada.

## Caso 6 — Integração feita por engano

Não reescreva histórico remoto automaticamente.

Primeiro:
1. identifique a alteração integrada;
2. avalie o impacto;
3. prefira recuperação reversível;
4. obtenha autorização humana para ações de alto impacto.

## Caso 7 — Versão publicada incorretamente

Não sobrescreva silenciosamente.

Registre o problema e siga a política do projeto para correção, mantendo o histórico auditável.

## Caso 8 — A IA perdeu contexto

Não tente reconstruir tudo por memória.

Leia:
- `AGENTS.md`;
- `PROJECT_STATE.md`;
- `TEST_MATRIX.md`;
- estado Git atual;
- PR ou issue da tarefa;
- commits relevantes.

Veja também [`18-HANDOFF-E-RETOMADA.md`](18-HANDOFF-E-RETOMADA.md).

## Relatório de incidente

Registre:

```text
O que aconteceu:
Estado encontrado:
Impacto:
Evidências preservadas:
Ação de recuperação:
Validações após recuperação:
Pendências:
```
