# LabConfig — Laboratório Público v0.3

Projeto didático para validar o Método Aberto de Desenvolvimento Assistido por IA em um cenário de persistência de dados.

Método de referência:
https://github.com/RoneiSoares/M-todo-Aberto-de-Desenvolvimento-Assistido-por-IA

## Branch-base

A branch-base deste laboratório é `laboratorio-persistencia-v0.3`.

Não use `main` como base de implementação deste produto.

## Produto

`LabConfig` carrega configurações JSON de um arquivo local. O comportamento funcional de referência exige que um arquivo JSON inválido nunca seja sobrescrito automaticamente durante uma tentativa de leitura.

## Ambiente

- .NET 8
- C#
- `System.Text.Json`
- sem dependências externas de NuGet

## Build

```bash
dotnet build ./src/LabConfig/LabConfig.csproj -c Release
```

## Smoke

```bash
dotnet run --project ./tests/LabConfig.Smoke/LabConfig.Smoke.csproj -c Release
```

## Antes de qualquer tarefa

Leia, nesta ordem:
1. `AGENTS.md`
2. `PROJECT_STATE.md`
3. `TEST_MATRIX.md`
4. `VERSIONING.md`
5. `CHANGELOG.md`
6. a tarefa fornecida pelo humano

Não confunda implementação em sandbox ou cópia reconstruída com implementação no repositório autoritativo.
