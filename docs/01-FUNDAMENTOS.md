# 01 — Fundamentos

## 1. IA acelera produção, não confiança

Uma IA pode criar muito código rapidamente. Isso reduz o custo de produzir alterações, mas aumenta o risco de aceitar mudanças sem evidência suficiente.

Por isso o método separa **fazer** de **provar**.

## 2. Três fontes de verdade

### Intenção
Responde: **o que deveria acontecer?**

Exemplos:
- requisito;
- issue;
- especificação;
- decisão registrada;
- regra de negócio.

### Implementação
Responde: **o que está implementado agora?**

Fonte principal:
- Git/repositório.

### Comportamento conhecido
Responde: **o que sabemos que funciona?**

Fontes:
- testes registrados;
- execução funcional;
- artefatos validados;
- versão GOLDEN.

## 3. Menor escopo possível

A IA deve começar pelo menor conjunto de arquivos capaz de explicar ou resolver o problema.

Não deve:
- varrer o repositório inteiro por padrão;
- refatorar módulos não relacionados;
- “melhorar” coisas fora da tarefa;
- alterar comportamento validado sem necessidade.

## 4. Isolamento

Toda tarefa relevante deve acontecer em branch própria e, quando houver trabalho paralelo ou risco de conflito, preferencialmente em worktree própria.

## 5. Evidência estratificada

Níveis comuns:
- BUILD;
- SMOKE/LÓGICO;
- ESTRUTURAL;
- FUNCIONAL;
- ACEITAÇÃO HUMANA.

Eles não são equivalentes.

## 6. Estado explícito

Evite frases vagas como:
- “está pronto”;
- “está funcionando”;
- “resolvido”.

Prefira:
- `BUILD OK`;
- `SMOKE 9/9 OK`;
- `FUNCIONAL PENDENTE`;
- `FUNCIONAL OK`;
- `ACEITO PELO USUÁRIO`.

## 7. Memória fora da conversa

A conversa é ferramenta de interação, não banco oficial de estado.

Estado crítico deve ir para arquivos versionados.

## 8. Decisões críticas continuam humanas

A IA pode investigar e executar muito. Mas merge, rebase, force push, tag, release, mudança de GOLDEN e exclusões relevantes devem depender da política do projeto — e no fluxo de referência exigem autorização explícita.
