# 07 — Protocolo do humano

## Antes da tarefa

Explique:
- o problema;
- o que você esperava;
- o que aconteceu;
- exemplos;
- limitações;
- o que não quer alterar.

## Durante a investigação

Evite pedir “arruma tudo”.

Prefira:
- “investigue sem alterar”;
- “corrija apenas X”;
- “não mexa em Y”;
- “mantenha Z como está”.

## Quando a IA trouxer resultado

Cheque:
- branch correta;
- escopo;
- arquivos alterados;
- build;
- testes;
- pendências;
- necessidade de teste funcional.

## Teste funcional

Quando só você possui o software/ambiente:
1. use exatamente o artefato informado;
2. use arquivo de teste adequado;
3. reproduza o cenário;
4. registre resultado;
5. informe defeitos de forma objetiva.

## Autorização

Use mensagens claras:
- “Pode criar a branch e implementar.”
- “Pode commitar e fazer push.”
- “Pode abrir o PR.”
- “Pode fazer merge do PR X.”
- “Pode criar a tag v1.2.3.”
- “Pode publicar a release.”

Não deixe autorização implícita quando a ação é crítica.

## Se algo der errado

Não peça para a IA “voltar tudo” sem primeiro entender o estado.

Peça:
- mostre `git status`;
- mostre branch;
- mostre diff;
- identifique commits envolvidos;
- proponha recuperação sem apagar histórico.

## Regra de ouro do humano

Não aceite conforto verbal como substituto de evidência.
