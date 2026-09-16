# Relatório final

Use detalhe proporcional à tarefa. Para tarefas comuns executadas por Codex/agente equivalente, prefira primeiro o formato compacto abaixo. Expanda apenas quando auditoria, handoff, incidente, release ou complexidade da tarefa exigir.

## Formato compacto

```text
STATUS: <estado mais forte sustentado pela evidência>
BRANCH: <branch>
COMMIT: <sha ou pendente>
PR: <número/link ou pendente>

ALTERADO:
- <resumo curto>

VALIDAÇÕES:
- build: <resultado>
- testes: <resultado>
- funcional: <resultado ou pendente>

PENDÊNCIAS:
- <somente o que realmente falta>
```

## Formato completo

### Alterações
- arquivos:
- resumo:

### Git
- branch:
- commit:
- PR:

### Evidências
- Build:
- Smoke/Lógico:
- Estrutural:
- Funcional:
- Aceitação:

### Artefatos
- caminho/nome:
- hash, se aplicável:

### Pendências
- ...

### Estado correto
<ANALISADO / IMPLEMENTADO / FUNCIONAL PENDENTE / FUNCIONAL OK / ACEITO / INTEGRADO>
