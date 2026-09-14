# 14 — Exemplo completo

## Cenário

Um plugin mostra profundidade com uma casa decimal. O usuário quer duas casas.

### Pedido inicial

> “A label aparece como 1,2 m. Quero 1,20 m. Não altere mais nada.”

## 1. Clarificação

Objetivo:
- alterar somente formatação numérica da label.

Não escopo:
- cálculo de profundidade;
- estilos;
- outras labels.

Critério:
- valor 1,2 deve ser exibido como 1,20.

## 2. Pré-voo

Agente verifica:
- pasta;
- status;
- branch;
- remote;
- `AGENTS.md`;
- `PROJECT_STATE.md`.

## 3. Branch

`fix/label-duas-casas`

## 4. Investigação

Busca somente:
- classe da label;
- formatador usado;
- testes relacionados.

## 5. Implementação

Troca formato de uma casa para duas.

Não refatora outras classes.

## 6. Build

Resultado:

`BUILD: OK, 0 erros`

## 7. Teste lógico

Entrada: `1.2`
Esperado: `1.20`

Resultado:

`SMOKE/LÓGICO: OK`

## 8. Estado correto antes do software real

`IMPLEMENTADO`
`BUILD OK`
`LÓGICO OK`
`FUNCIONAL PENDENTE`

## 9. Commit e PR

Commit:
`fix: exibir profundidade com duas casas decimais`

PR informa:
- problema;
- arquivo alterado;
- build;
- teste;
- pendência funcional.

## 10. Teste funcional

Humano:
- abre arquivo representativo;
- carrega exatamente o novo artefato;
- executa comando;
- observa label;
- confirma `1,20 m`.

## 11. Registro

`TEST_MATRIX.md`:
- Build OK;
- Smoke OK;
- Funcional OK.

`PROJECT_STATE.md`:
- candidata validada, se aplicável.

## 12. Merge

Só depois de autorização explícita.

## 13. Promoção

Se a política do projeto considerar essa versão nova referência:
- atualizar estado;
- tag/release quando autorizado;
- promover GOLDEN somente após evidência suficiente.

## O que uma IA não poderia dizer antes do passo 10

“Está 100% funcionando no Civil 3D.”

Ela poderia dizer:

“Implementação concluída; build e teste lógico passaram; validação funcional no Civil 3D ainda é necessária.”
