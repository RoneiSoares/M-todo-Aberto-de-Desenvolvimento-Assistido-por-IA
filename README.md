# Método Aberto de Desenvolvimento Assistido por IA

> **v0.2.1 — Manual Operacional em revisão**
>
> Objetivo: permitir que uma pessoa sem experiência prévia com este fluxo consiga aprender e reproduzir a forma de trabalho descrita aqui, e permitir que uma IA nova consiga operar de maneira previsível seguindo as mesmas regras.

## Comece por aqui

Se você é iniciante, leia nesta ordem:

1. `docs/00-COMECE-AQUI.md`
2. `docs/01-FUNDAMENTOS.md`
3. `docs/02-PAPEIS-E-RESPONSABILIDADES.md`
4. `docs/03-ARQUIVOS-DE-MEMORIA.md`
5. `docs/04-FLUXO-OPERACIONAL.md`
6. `docs/05-GIT-PARA-LEIGOS.md`
7. `docs/06-PROTOCOLO-DA-IA.md`
8. `docs/07-PROTOCOLO-DO-HUMANO.md`
9. `docs/08-EVIDENCIAS-E-TESTES.md`
10. `docs/09-GOLDEN-E-VERSIONAMENTO.md`
11. `docs/10-SEGURANCA-E-AUTORIZACOES.md`
12. `docs/11-CHECKLISTS.md`
13. `docs/12-GLOSSARIO.md`
14. `docs/13-ANTIPADROES.md`
15. `docs/14-EXEMPLO-COMPLETO.md`

## Princípio central

> **IA pode produzir trabalho. Evidência valida o trabalho.**

## Fluxo em uma linha

`Necessidade → requisito → branch isolada → implementação → build → testes → evidências → PR → validação funcional → aprovação → merge → versão/release/GOLDEN`

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
6. operações irreversíveis ou de alto impacto exigem autorização explícita;
7. a versão mais nova não substitui automaticamente a última versão funcional validada;
8. o relatório final deve dizer o que mudou, o que foi testado e o que ainda não foi testado;
9. quando houver dependência de ambiente real, `IMPLEMENTADO` e `FUNCIONALMENTE VALIDADO` são estados diferentes;
10. o projeto deve ser retomável por outra pessoa ou IA a partir de artefatos persistidos.

## Templates

Use os modelos em `templates/` ao iniciar um novo projeto.

## Exemplo completo

Leia `docs/14-EXEMPLO-COMPLETO.md` para ver o processo do começo ao fim.

## Status

O método continua experimental e aberto a críticas. A v0.2.1 foca em **reprodutibilidade operacional**, não em alegar originalidade acadêmica.
