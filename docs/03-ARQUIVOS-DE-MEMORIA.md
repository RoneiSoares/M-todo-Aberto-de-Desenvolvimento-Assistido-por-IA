# 03 — Arquivos de memória do projeto

## Estrutura recomendada

```text
README.md
AGENTS.md
PROJECT_STATE.md
TEST_MATRIX.md
VERSIONING.md
CHANGELOG.md
ARCHITECTURE.md          # quando necessário
docs/
tests/
tools/
```

## AGENTS.md

É o manual do agente para aquele repositório.

Deve registrar:
- objetivo do produto;
- prioridades;
- ambiente;
- caminhos importantes;
- comandos de build/teste;
- regras validadas;
- operações proibidas;
- regra de escopo;
- formato do relatório final.

## PROJECT_STATE.md

Deve responder:
- versão em desenvolvimento;
- referência funcional atual;
- o que mudou;
- o que já foi validado;
- o que ainda está pendente;
- qual ambiente é necessário.

Regra: não chame uma versão de funcionalmente validada apenas porque compilou.

## TEST_MATRIX.md

Tabela recomendada:

| Versão | Build | Smoke/Lógico | Estrutural | Funcional | Aceitação |
|---|---|---|---|---|---|
| 1.2.0 | OK | 8/8 | OK | Pendente | Pendente |

## VERSIONING.md

Defina estados como:
- Em desenvolvimento;
- Candidata;
- Funcionalmente validada;
- Tag;
- Release;
- GOLDEN.

## CHANGELOG.md

Registra mudanças relevantes por versão.

## ARCHITECTURE.md

Use para explicar:
- módulos;
- dependências;
- fluxos;
- decisões arquiteturais;
- restrições.

## Regra de atualização

Se uma tarefa muda o estado real do projeto, atualize o arquivo correspondente.

Não atualize evidência por expectativa. Só registre o que realmente ocorreu.
