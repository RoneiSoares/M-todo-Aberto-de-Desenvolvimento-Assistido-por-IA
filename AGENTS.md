# AGENTS.md — Regras operacionais do LabConfig

Leia este arquivo antes de qualquer alteração.

## Prioridades

1. preservar dados do usuário;
2. preservar comportamento funcionalmente validado;
3. corrigir apenas o problema solicitado;
4. trabalhar no menor escopo suficiente;
5. manter evidências claras;
6. evitar refatoração não relacionada.

## Branch-base do produto

`laboratorio-persistencia-v0.3`

Não use `main` como base de implementação deste projeto.

Para tarefa relevante, crie branch própria a partir da branch-base.

## Antes de editar

Confirme, quando as ferramentas permitirem:
- repositório/workspace e sua proveniência;
- `git status`;
- branch atual;
- remotes;
- `PROJECT_STATE.md`;
- `TEST_MATRIX.md`;
- referência funcional conhecida.

Se estiver trabalhando em snapshot, sandbox ou reconstrução, declare isso explicitamente e não trate a cópia como repositório autoritativo.

## Build

```bash
dotnet build ./src/LabConfig/LabConfig.csproj -c Release
```

## Smoke

```bash
dotnet run --project ./tests/LabConfig.Smoke/LabConfig.Smoke.csproj -c Release
```

## Evidências

- build prova compilação;
- smoke prova apenas os cenários automatizados executados;
- estrutural pode verificar integridade de arquivos/artefatos;
- funcional prova comportamento no ambiente definido;
- aceitação humana confirma a necessidade real.

## Operações críticas

Não executar sem autorização humana explícita:
- merge;
- rebase;
- force push;
- tag;
- release;
- mudança da GOLDEN;
- exclusão relevante;
- sobrescrita de histórico remoto.

Commit, push normal e abertura de PR não são automaticamente operações críticas; dependem do escopo e das permissões da tarefa.

## Relatório final

Informe também a proveniência do workspace onde qualquer alteração ou evidência foi produzida.
