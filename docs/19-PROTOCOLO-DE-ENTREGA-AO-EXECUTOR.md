# 19 — Protocolo de entrega ao executor

Este protocolo define como uma IA de raciocínio/orquestração deve entregar uma tarefa para um agente executor, como Codex, Claude Code ou equivalente.

O objetivo é reduzir ruído, evitar repetição de contexto já persistido no projeto e entregar um único prompt pronto para copiar e executar.

## 1. Papéis

- **Orquestrador:** entende o pedido humano, investiga o necessário, transforma intenção em tarefa e prepara a entrega.
- **Executor:** trabalha no repositório, altera arquivos, executa validações e relata evidências.
- **Auditor:** entra apenas quando solicitado para procurar problemas concretos; não deve reimplementar por preferência.

Uma mesma IA pode assumir mais de um papel em momentos diferentes, mas deve saber qual papel está exercendo.

## 2. Regra principal de entrega

Quando o próximo passo depender de outro agente executar a tarefa, o orquestrador deve terminar a resposta com **um único bloco de prompt autocontido, compacto e pronto para copiar**.

Não deve:

- espalhar instruções em vários blocos;
- pedir ao humano para montar o prompt;
- repetir todo o histórico da conversa;
- copiar para o prompt informações que o executor consegue obter de `AGENTS.md`, `PROJECT_STATE.md`, Git ou documentação persistida;
- incluir explicações, justificativas ou alternativas descartadas que não mudem a execução;
- exigir que o executor releia o repositório inteiro sem necessidade.

## 3. Princípio de economia de contexto

> **Envie ao executor apenas o delta necessário para a tarefa atual.**

O projeto deve carregar o contexto persistente. O prompt deve carregar principalmente o que mudou ou o que precisa ser feito agora.

Se o projeto já adotou o Método Aberto, prefira referências curtas como:

```text
Siga o AGENTS.md e o estado persistido do projeto antes de alterar arquivos.
```

Não reenvie o método inteiro em cada tarefa.

## 4. Estrutura mínima do prompt

Use apenas os campos necessários:

```text
Siga o AGENTS.md e o estado persistido do projeto antes de alterar arquivos.

Tarefa:
<o que deve ser feito>

Objetivo:
<resultado esperado, quando necessário>

Escopo:
<limites importantes>

Validação:
<build/testes/evidências realmente necessários>

Git:
<autorizações relevantes>

Ao final, responda de forma compacta com:
STATUS
BRANCH
COMMIT
PR
VALIDAÇÕES
PENDÊNCIAS
```

Campos vazios ou óbvios devem ser omitidos.

## 5. Primeira adoção versus uso normal

### Primeira adoção

Quando o projeto ainda não possui os artefatos do método, o prompt pode apontar para o repositório do Método Aberto e pedir adoção mínima antes da implementação.

### Uso normal

Quando `AGENTS.md`, estado persistido e demais artefatos já existem, não repita o método no prompt. Envie somente a tarefa atual e as exceções relevantes.

## 6. Quando incluir detalhes adicionais

Inclua contexto extra apenas quando ele não estiver persistido no projeto e for necessário para evitar interpretação errada, por exemplo:

- comportamento atual versus esperado;
- arquivo ou módulo que deve permanecer intocado;
- caso real que reproduz o bug;
- decisão humana tomada nesta conversa e ainda não registrada;
- autorização específica para operação que normalmente exigiria confirmação.

## 7. Formato da resposta do orquestrador

A resposta ao humano pode conter uma explicação curta antes do prompt. Depois disso, deve haver um único bloco copiável.

Padrão:

```text
<explicação curta ao humano, se necessária>

PROMPT PARA O EXECUTOR
<um único bloco pronto para copiar>
```

Não repita o mesmo prompt fora do bloco.

## 8. Resposta compacta do executor

Quando a tarefa não exigir relatório extenso, peça ao executor para responder no formato:

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

O relatório completo do método continua disponível quando a tarefa, auditoria, handoff ou release exigir mais detalhe.

## 9. Auditoria

Quando outro agente for usado como auditor, o prompt deve deixar claro:

- procure problemas concretos;
- não refatore por preferência;
- não reimplemente apenas porque faria diferente;
- verifique requisitos, diff, testes, APIs externas, casos-limite e regressões relevantes;
- se não houver problema demonstrável, diga isso.

## 10. Teste de aderência

Uma IA que recebeu apenas o link deste método e foi solicitada a preparar trabalho para o Codex deve conseguir:

1. identificar que está no papel de orquestrador;
2. não tratar o Codex como destinatário de todo o histórico da conversa;
3. produzir um único prompt copiável;
4. evitar duplicar contexto persistido;
5. informar escopo, validação e autorizações relevantes;
6. pedir um retorno compacto do executor.

Se não fizer isso, a entrega ao executor não está aderente ao método.
