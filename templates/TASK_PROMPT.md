# Prompt de tarefa

Este template registra uma **especificação completa de tarefa**. Ele pode ser útil para issue, planejamento, documentação ou uma tarefa que precise manter todos os detalhes abaixo.

Quando uma IA/orquestrador estiver apenas passando uma tarefa para Codex/Claude Code/outro executor em um projeto que já possui contexto persistido, **não copie este formulário inteiro por padrão**. Use `EXECUTOR_PROMPT.md` e envie somente o delta necessário.

## Contexto
<explique o problema>

## Comportamento atual
<o que acontece>

## Comportamento esperado
<o que deveria acontecer>

## Escopo permitido
<onde pode mexer>

## Fora do escopo
<onde não deve mexer>

## Validações esperadas
- [ ] build
- [ ] smoke/lógico
- [ ] estrutural
- [ ] funcional
- [ ] aceitação

## Autorizações
- criar branch: SIM/NÃO
- alterar arquivos: SIM/NÃO
- commit: SIM/NÃO
- push: SIM/NÃO
- abrir PR: SIM/NÃO
- merge: SIM/NÃO
- tag: SIM/NÃO
- release: SIM/NÃO

## Entrega ao executor

Se o próximo passo for delegar a execução, converta esta especificação para o formato econômico de `EXECUTOR_PROMPT.md`, removendo contexto que já existe em `AGENTS.md`, `PROJECT_STATE.md`, Git ou documentação do projeto.
