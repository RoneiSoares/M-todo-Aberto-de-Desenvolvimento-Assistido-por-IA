# AGENTS.md — Regras operacionais do LabCalc

Leia este arquivo antes de qualquer alteração.

## Prioridades

1. preservar comportamento funcionalmente validado;
2. corrigir apenas o problema solicitado;
3. trabalhar no menor escopo suficiente;
4. manter evidências claras;
5. evitar refatoração não relacionada.

## Branch-base do produto

A branch-base deste laboratório é:

`laboratorio-metodo-ia`

Não use `main` como base de implementação deste projeto.

Para uma tarefa relevante, crie branch própria a partir de `laboratorio-metodo-ia`.

## Antes de editar

Confirme:
- repositório/local correto;
- status do Git;
- branch atual;
- remotes;
- estado persistido em `PROJECT_STATE.md`;
- evidências em `TEST_MATRIX.md`;
- referência funcional conhecida.

## Build

```bash
dotnet build ./src/LabCalc/LabCalc.csproj -c Release
```

## Smoke

```bash
dotnet run --project ./tests/LabCalc.Smoke/LabCalc.Smoke.csproj -c Release
```

## Evidências

Não trate evidências como equivalentes.

- build prova compilação;
- smoke prova os cenários automatizados executados;
- funcional prova comportamento em ambiente definido para o produto;
- aceitação humana confirma que a necessidade foi atendida.

## Operações críticas

Não executar sem autorização humana explícita:
- merge;
- rebase;
- force push;
- tag;
- release;
- mudança da referência funcional/GOLDEN;
- exclusão relevante;
- sobrescrita de histórico remoto.

## Relatório final

Informe:
- arquivos alterados;
- resumo;
- branch;
- build;
- testes;
- evidência funcional;
- pendências;
- próximo passo seguro;
- operações ainda dependentes de autorização.

Nunca declare `FUNCIONAL OK` apenas porque compilou ou porque o smoke passou.
