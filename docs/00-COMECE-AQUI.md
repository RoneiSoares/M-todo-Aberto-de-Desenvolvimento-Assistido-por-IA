# 00 — Comece aqui

Este é o ponto de entrada para quem nunca trabalhou com Git, GitHub, branches, Pull Requests ou agentes de IA.

## Objetivo

Você não precisa virar programador profissional antes de usar o método. Precisa entender **como o trabalho é organizado**.

Ao final, você deve saber:

- quem decide o que deve ser feito;
- quem investiga;
- quem executa;
- onde o estado do projeto fica registrado;
- como uma mudança é isolada;
- como uma mudança é validada;
- quando algo pode ser chamado de funcional;
- quando uma IA deve parar e pedir autorização.

## Os quatro papéis

### Humano
Define objetivo, contexto, prioridade, aceita ou rejeita resultados e autoriza operações críticas.

### IA de raciocínio / arquitetura
Ajuda a transformar uma necessidade em tarefa técnica clara, investigar alternativas, analisar resultados e organizar próximos passos.

### Agente executor
Opera no repositório e ambiente de desenvolvimento: lê arquivos, edita código, compila, testa, versiona e abre PRs.

### Git/GitHub
Mantém o histórico persistente e auditável.

## Modelo mental

Errado:

`Pedi → IA respondeu “pronto” → acabou`

Correto:

`Necessidade → intenção clara → alteração isolada → evidência → teste real → aceitação → integração`

## As cinco perguntas quando alguém disser “pronto”

1. O que foi alterado?
2. O projeto compilou?
3. Quais testes foram executados?
4. O que ainda não foi testado?
5. Foi validado no ambiente real?

Se a resposta à última for “não”, use um estado explícito, como:

> **IMPLEMENTADO — AGUARDANDO VALIDAÇÃO FUNCIONAL**

## Regra principal

> Nunca confunda **produção de código** com **prova de funcionamento**.
