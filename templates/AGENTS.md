# AGENTS.md — <Projeto>

Leia este arquivo antes de qualquer tarefa.

## Objetivo
<o que o produto faz>

## Prioridades
1. preservar comportamento validado;
2. corrigir somente o solicitado;
3. manter código auditável/testável;
4. evitar refactors não relacionados.

## Ambiente
- Plataforma:
- Runtime:
- Projeto principal:
- Dependências:
- Comando de build:

## Git
- Repositório oficial:
- Branch oficial: `main`
- Remote de publicação: `origin`
- Não alterar `main` sem autorização.
- Cada tarefa usa branch própria.
- Merge, rebase, force push, tag e release exigem autorização explícita.

## Regra de escopo
- começar por arquivos citados e dependências diretas;
- ampliar busca somente com evidência;
- tarefa de análise não vira implementação sem autorização;
- tarefa de teste não altera código.

## Regras validadas
<liste regras de negócio/comportamento que não devem ser alteradas>

## Build
```text
<comando>
```

## Testes
```text
<comandos>
```

## CI e armazenamento
- push/PR normal: priorizar build + testes + PASS/FAIL, sem persistir binários por padrão;
- artifact temporário: somente quando necessário para validação/RC, com consumidor e retenção definidos;
- retenção padrão recomendada para artifact temporário: 1–3 dias, salvo justificativa do projeto;
- binário permanente: publicar como Release Asset de uma release aprovada;
- evitar gatilhos redundantes e usar `concurrency`/`cancel-in-progress` quando apropriado;
- ao alterar workflow, revisar frequência, tamanho, retenção e custo/cota provável.

## Forma de trabalhar
1. confirmar pasta/status/branch/remote;
2. ler este arquivo e estado;
3. identificar menor escopo;
4. fazer menor alteração suficiente;
5. compilar;
6. testar;
7. revisar diff;
8. reportar evidências e pendências.

## Relatório final
- arquivos alterados;
- resumo;
- build;
- testes;
- artifacts persistidos, se houver, com motivo e retenção;
- teste funcional;
- pendências.
