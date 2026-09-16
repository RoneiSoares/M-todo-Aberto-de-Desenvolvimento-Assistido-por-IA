# Método Aberto de Desenvolvimento Assistido por IA

> **v0.2.1 — Manual Operacional em revisão**
>
> Objetivo: permitir que uma pessoa sem experiência prévia com este fluxo consiga aprender e reproduzir a forma de trabalho descrita aqui, e permitir que uma IA nova consiga operar de maneira previsível seguindo as mesmas regras.

## Comece por aqui

### Se você é iniciante

Leia nesta ordem:

1. `docs/00-COMECE-AQUI.md`
2. `docs/01-FUNDAMENTOS.md`
3. `docs/02-PAPEIS-E-RESPONSABILIDADES.md`
4. `docs/03-ARQUIVOS-DE-MEMORIA.md`
5. `docs/04-FLUXO-OPERACIONAL.md`
6. `docs/05-GIT-PARA-LEIGOS.md`
7. `docs/07-PROTOCOLO-DO-HUMANO.md`
8. `docs/08-EVIDENCIAS-E-TESTES.md`
9. `docs/09-GOLDEN-E-VERSIONAMENTO.md`
10. `docs/10-SEGURANCA-E-AUTORIZACOES.md`
11. `docs/11-CHECKLISTS.md`
12. `docs/12-GLOSSARIO.md`
13. `docs/13-ANTIPADROES.md`
14. `docs/14-EXEMPLO-COMPLETO.md`
15. `docs/15-ADOTANDO-DO-ZERO.md`
16. `docs/16-RECUPERACAO-E-INCIDENTES.md`
17. `docs/17-DEFINITION-OF-DONE.md`
18. `docs/18-HANDOFF-E-RETOMADA.md`
19. `docs/19-PROTOCOLO-DE-ENTREGA-AO-EXECUTOR.md`

### Se você é uma IA / agente

Comece por `docs/06-PROTOCOLO-DA-IA.md` e identifique primeiro seu papel atual.

- Se você vai **executar** alterações, no projeto real leia também `AGENTS.md`, `PROJECT_STATE.md`, `TEST_MATRIX.md` e `VERSIONING.md`, quando existirem.
- Se você vai **preparar uma tarefa para Codex/Claude Code/outro executor**, leia também `docs/19-PROTOCOLO-DE-ENTREGA-AO-EXECUTOR.md` e use `templates/EXECUTOR_PROMPT.md`.
- Se você vai **auditar**, procure problemas concretos e não reimplemente por preferência.

Quando o humano pedir um prompt para o Codex ou equivalente, não apenas descreva o que ele deve fazer: entregue **um único prompt compacto, autocontido e pronto para copiar**, sem repetir contexto que já está persistido no projeto.

Antes de editar, você deve conseguir responder:

- qual é o objetivo da tarefa;
- qual é o estado atual do projeto;
- qual é a referência funcional conhecida;
- qual é o menor escopo inicial;
- quais validações são necessárias;
- quais decisões ainda dependem do humano.

Se não conseguir responder, investigue o contexto persistido antes de alterar arquivos.

## Princípio central

> **IA pode produzir trabalho. Evidência valida o trabalho.**

## Fluxo em uma linha

`Necessidade → requisito → branch isolada → implementação → build → testes → evidências → PR → validação funcional → aprovação → integração → versão/release/GOLDEN`

## Três fontes de verdade

- **Intenção:** requisito, issue, especificação, decisão.
- **Implementação:** repositório Git.
- **Comportamento conhecido:** evidências e versão funcional validada.

## Regras que definem o método

1. contexto crítico não pode existir apenas na conversa;
2. cada tarefa relevante deve ser isolada;
3. o agente deve trabalhar no menor escopo possível;
4. build, smoke, estrutural e funcional são evidências diferentes;
5. uma evidência nunca deve ser apresentada como se fosse outra;
6. operações de alto impacto exigem política explícita de autorização;
7. a versão mais nova não substitui automaticamente a última versão funcional validada;
8. o relatório final deve dizer o que mudou, o que foi testado e o que ainda não foi testado;
9. quando houver dependência de ambiente real, `IMPLEMENTADO` e `FUNCIONALMENTE VALIDADO` são estados diferentes;
10. o projeto deve ser retomável por outra pessoa ou IA a partir de artefatos persistidos;
11. o critério de DONE deve ser proporcional ao risco da alteração;
12. uma troca de pessoa, sessão ou IA deve deixar handoff suficiente para retomada;
13. quando um orquestrador delegar trabalho a outro agente, deve enviar somente o delta necessário em um único prompt copiável, sem duplicar o contexto persistido do projeto.

## Templates

Use os modelos em `templates/` ao iniciar um novo projeto.

Para passagem de tarefa entre IA/orquestrador e Codex/Executor, use `templates/EXECUTOR_PROMPT.md`.

## Exemplo completo

Leia `docs/14-EXEMPLO-COMPLETO.md` para ver o processo do começo ao fim.

## Situações especiais

- Para começar um projeto do zero: `docs/15-ADOTANDO-DO-ZERO.md`.
- Se algo der errado: `docs/16-RECUPERACAO-E-INCIDENTES.md`.
- Para decidir quando algo está concluído: `docs/17-DEFINITION-OF-DONE.md`.
- Para trocar de pessoa ou IA sem perder contexto: `docs/18-HANDOFF-E-RETOMADA.md`.
- Para preparar um prompt econômico e pronto para Codex/Executor: `docs/19-PROTOCOLO-DE-ENTREGA-AO-EXECUTOR.md`.

## Status

O método continua experimental e aberto a críticas. A v0.2.1 foca em **reprodutibilidade operacional**, não em alegar originalidade acadêmica.
