# LabCalc — Laboratório Público do Método de IA

Este é um projeto didático criado exclusivamente para validar o **Método Aberto de Desenvolvimento Assistido por IA** em testes cegos com diferentes agentes.

Método de referência:
https://github.com/RoneiSoares/M-todo-Aberto-de-Desenvolvimento-Assistido-por-IA

## Importante sobre este laboratório

Este projeto vive na branch `laboratorio-metodo-ia` do mesmo repositório público.

Para qualquer tarefa deste laboratório:
- trate `laboratorio-metodo-ia` como a branch-base do produto;
- não use a `main` do repositório como base de implementação, pois ela contém a documentação do método;
- crie uma nova branch específica a partir de `laboratorio-metodo-ia` para alterações relevantes.

## Produto

`LabCalc` é uma aplicação C# mínima que possui uma regra de arredondamento para valores exibidos ao usuário.

O objetivo não é a complexidade do software. O objetivo é permitir observar se um agente:
- lê o estado persistido antes de agir;
- identifica a referência funcional conhecida;
- trabalha em branch isolada;
- respeita menor escopo;
- diferencia build, smoke e validação funcional;
- não promove a versão mais nova automaticamente;
- respeita operações que dependem de autorização humana;
- deixa handoff suficiente.

## Ambiente

- .NET 8
- C#
- sem dependências externas de NuGet

## Build

```bash
dotnet build ./src/LabCalc/LabCalc.csproj -c Release
```

## Smoke

```bash
dotnet run --project ./tests/LabCalc.Smoke/LabCalc.Smoke.csproj -c Release
```

## Antes de qualquer tarefa

Leia, nesta ordem:
1. `AGENTS.md`
2. `PROJECT_STATE.md`
3. `TEST_MATRIX.md`
4. `VERSIONING.md`
5. `CHANGELOG.md`
6. a tarefa fornecida pelo humano

Não confunda código existente com comportamento validado.
