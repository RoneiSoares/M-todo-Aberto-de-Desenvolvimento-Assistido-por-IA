# 15 — Adotando o método do zero

Este guia mostra como iniciar um projeto usando o método sem pressupor experiência prévia.

## Passo 1 — Crie o repositório

Crie um repositório Git e defina uma branch principal, normalmente `main`.

## Passo 2 — Copie os templates mínimos

Copie de `templates/` para a raiz do seu projeto:

- `AGENTS.md`;
- `PROJECT_STATE.md`;
- `TEST_MATRIX.md`;
- `VERSIONING.md`.

Preencha cada arquivo com dados reais do projeto.

## Passo 3 — Defina o ambiente

Registre:

- sistema operacional;
- linguagem/runtime;
- software externo necessário;
- comando de build;
- comandos de teste;
- caminhos ou dependências relevantes.

## Passo 4 — Defina o comportamento já conhecido

Se já existe uma versão funcional, registre-a em `PROJECT_STATE.md` e `TEST_MATRIX.md`.

Não chame algo de validado apenas porque compila.

## Passo 5 — Defina regras de autorização

No mínimo, indique quem pode autorizar:

- merge;
- rebase;
- force push;
- tag;
- release;
- mudança da referência funcional/GOLDEN;
- exclusões relevantes.

## Passo 6 — Faça a primeira tarefa em branch própria

Use uma tarefa pequena para testar o processo completo:

`pedido → branch → alteração → build → testes → evidências → PR → validação → integração`

## Passo 7 — Verifique se outra pessoa ou IA consegue retomar

Entregue apenas o repositório e peça para explicar:

- o que o produto faz;
- qual versão está em desenvolvimento;
- qual versão é a referência funcional;
- como compilar;
- como testar;
- quais operações exigem autorização.

Se a resposta depender de memória oral ou de chat antigo, ainda falta persistir contexto.

## Critério de adoção mínima

Um projeto está usando a base do método quando:

1. possui estado persistente fora da conversa;
2. separa implementação de validação;
3. registra evidência proporcional ao que afirma;
4. possui controle explícito para operações críticas;
5. consegue ser retomado por outra pessoa ou IA sem depender do histórico completo da conversa.
