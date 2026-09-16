# Prompt compacto para executor

> Use este template quando uma IA/orquestrador precisar entregar uma tarefa para Codex, Claude Code ou agente equivalente.
>
> Regra: não duplique contexto que já exista em `AGENTS.md`, `PROJECT_STATE.md`, Git ou documentação persistida. Envie apenas o delta necessário para a tarefa atual.

```text
Siga o AGENTS.md e o estado persistido do projeto antes de alterar arquivos.

Tarefa:
<o que deve ser feito>

Objetivo:
<resultado esperado — omita se já estiver óbvio>

Escopo:
- <limite importante>
- <o que deve permanecer intacto, se necessário>

Validação:
- <build/testes/evidências necessárias>

Git:
- <autorizações relevantes>

Ao final, responda de forma compacta com:
STATUS
BRANCH
COMMIT
PR
VALIDAÇÕES
PENDÊNCIAS
```

## Regras de compactação

- omita campos desnecessários;
- não reproduza o método inteiro;
- não reproduza histórico de conversa sem efeito na execução;
- não envie alternativas já descartadas;
- não peça varredura completa do repositório por padrão;
- se o projeto ainda não adotou o método, informe o link do Método Aberto e peça adoção mínima antes da tarefa.
