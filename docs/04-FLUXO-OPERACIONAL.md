# 04 — Fluxo operacional completo

## Etapa 0 — Entrada

O humano descreve:
- problema;
- comportamento atual;
- comportamento esperado;
- restrições;
- urgência;
- como reconhecer sucesso.

## Etapa 1 — Clarificação

A IA de raciocínio converte isso em tarefa objetiva.

Saída mínima:
- objetivo;
- escopo;
- não escopo;
- riscos;
- critérios de aceitação;
- validações esperadas.

## Etapa 2 — Pré-voo do agente

Antes de alterar:

1. confirmar diretório atual;
2. confirmar `git status`;
3. confirmar branch;
4. confirmar remote;
5. ler `AGENTS.md`;
6. ler `PROJECT_STATE.md`;
7. ler apenas documentação necessária à tarefa;
8. identificar referência funcional atual;
9. confirmar se existem alterações locais alheias à tarefa.

Se existir estado inesperado, não o destrua para continuar.

## Etapa 3 — Isolamento

Criar branch própria.

Padrões de nome possíveis:
- `fix/<assunto>`;
- `feature/<assunto>`;
- `docs/<assunto>`;
- `test/<assunto>`.

Quando houver necessidade de múltiplas tarefas simultâneas, usar worktree.

## Etapa 4 — Investigação

Começar pelos arquivos citados no problema e dependências diretas.

Só ampliar busca quando existir evidência concreta.

## Etapa 5 — Implementação

Fazer a menor mudança suficiente.

Regras:
- não refatorar por gosto;
- não incluir melhorias não relacionadas;
- preservar regras validadas;
- não converter tarefa de análise em implementação sem autorização.

## Etapa 6 — Validação técnica

Executar:
- build;
- testes relevantes;
- `git diff --check` ou equivalente;
- inspeção do diff.

## Etapa 7 — Relatório intermediário

Informar:
- o que mudou;
- build;
- testes;
- pendências;
- se precisa de ambiente real.

## Etapa 8 — Versionamento da tarefa

Quando o escopo permitir:
- `git add`;
- commit claro;
- push da branch;
- abrir PR.

## Etapa 9 — Validação funcional

Quando o comportamento depende do ambiente real:
- usar a versão exata gerada;
- usar entrada representativa;
- registrar resultado;
- não substituir evidência por suposição.

## Etapa 10 — Atualização de memória

Atualizar conforme aplicável:
- `PROJECT_STATE.md`;
- `TEST_MATRIX.md`;
- `CHANGELOG.md`;
- `VERSIONING.md`.

## Etapa 11 — Revisão

Revisar:
- escopo;
- diff;
- evidências;
- regressões;
- documentação;
- pendências.

## Etapa 12 — Integração

Merge somente com autorização explícita no fluxo de referência.

## Etapa 13 — Versão / tag / release

Só depois de:
- escopo congelado;
- evidências registradas;
- aprovação;
- autorização.

## Etapa 14 — GOLDEN

A nova versão só substitui a referência funcional anterior quando a política de validação tiver sido satisfeita.
