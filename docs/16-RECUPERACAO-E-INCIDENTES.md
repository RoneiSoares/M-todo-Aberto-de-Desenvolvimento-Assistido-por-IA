# 16 — Recuperação e incidentes

Erros acontecem. O método deve dizer como recuperar sem destruir evidência.

## Regra principal

> Primeiro entenda o estado. Depois recupere.

Nunca comece um incidente com comandos destrutivos apenas para “voltar ao normal”.

## Caso 1 — Trabalhei na branch errada

1. pare novas alterações;
2. registre `git status` e a branch atual;
3. identifique arquivos/commits envolvidos;
4. preserve as mudanças;
5. mova ou reaplique o trabalho para a branch correta usando a opção menos destrutiva disponível;
6. só limpe a branch errada depois de confirmar que o trabalho foi preservado.

## Caso 2 — Alterações locais inesperadas

Não use `reset --hard`, `checkout` destrutivo ou exclusão para continuar.

Primeiro determine:
- quem/qual tarefa gerou as alterações;
- se estão commitadas;
- se pertencem ao seu escopo.

Se não pertencerem, isole sua tarefa sem sobrescrevê-las.

## Caso 3 — Build quebrou após a mudança

1. confirme que o ambiente/dependências estão presentes;
2. confirme que o erro foi introduzido pela sua alteração;
3. reduza o problema ao menor conjunto possível;
4. corrija sem expandir escopo desnecessariamente;
5. reexecute build e testes relevantes.

Não marque a tarefa como concluída com build quebrado, salvo se o objetivo explícito era apenas investigação.

## Caso 4 — Smoke passou e funcional falhou

O teste funcional tem precedência para a afirmação de comportamento real.

Registre:
- `SMOKE OK`;
- `FUNCIONAL FALHOU`;
- cenário da falha;
- artefato/versão usada.

Não altere a matriz para esconder a inconsistência.

## Caso 5 — Versão nova regrediu

Mantenha a referência funcional/GOLDEN anterior.

A versão nova volta ao estado de desenvolvimento/candidata até que a regressão seja corrigida e validada.

## Caso 6 — Merge feito por engano

Não reescreva histórico remoto automaticamente.

Primeiro:
1. identifique o merge/commit;
2. avalie impacto;
3. escolha recuperação reversível quando possível;
4. obtenha autorização humana para ações de alto impacto.

## Caso 7 — Tag ou release incorreta

Não sobrescreva silenciosamente.

Registre o problema e use a política do projeto para correção. Tags e releases devem permanecer auditáveis.

## Caso 8 — A IA perdeu contexto

Não tente reconstruir tudo por memória.

Leia:
- `AGENTS.md`;
- `PROJECT_STATE.md`;
- `TEST_MATRIX.md`;
- branch/status;
- PR/issue da tarefa;
- commits relevantes.

Veja também `18-TROCA-DE-IA-E-RETOMADA.md`.

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
