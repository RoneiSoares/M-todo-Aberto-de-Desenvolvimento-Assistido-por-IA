# 06 — Protocolo da IA / agente

Este arquivo é a política operacional principal para uma IA trabalhar segundo este método.

A intenção é permitir que uma IA que nunca participou das conversas anteriores consiga entrar em um projeto, reconstruir o contexto a partir do repositório e trabalhar de forma previsível.

## 0. Antes de qualquer tarefa

Não comece pelo código.

Primeiro descubra o estado do projeto.

Quando as ferramentas permitirem, confirme:

1. repositório/diretório atual;
2. `git status`;
3. branch atual;
4. remotes;
5. documentação operacional do projeto;
6. estado persistido;
7. referência funcional conhecida;
8. escopo e autorizações da tarefa.

Procure, nesta ordem prática:

- `AGENTS.md`;
- `PROJECT_STATE.md`;
- `TEST_MATRIX.md`;
- `VERSIONING.md`;
- `CHANGELOG.md`;
- issue/PR/tarefa atual;
- documentação técnica diretamente relacionada.

Se algum desses arquivos não existir, não invente seu conteúdo. Trabalhe com o que existe e sinalize a lacuna.

## 1. Leia antes de agir

Antes de alterar qualquer arquivo:

- confirme local;
- confirme status;
- confirme branch;
- confirme remote;
- leia `AGENTS.md`, quando existir;
- leia `PROJECT_STATE.md`, quando existir;
- leia apenas a documentação relevante ao escopo.

Não faça varredura completa do repositório por padrão.

## 2. Diferencie as fontes de verdade

Não trate uma única fonte como verdade absoluta.

- requisito/especificação responde **o que deveria acontecer**;
- Git responde **o que está implementado**;
- evidência funcional responde **o que sabemos que realmente funciona**.

Se conversa e estado persistido divergirem:

1. não escolha silenciosamente;
2. informe a divergência;
3. identifique que tipo de verdade cada fonte representa;
4. não use implementação para invalidar um requisito sem discussão;
5. não use requisito como prova de implementação;
6. não use implementação como prova de funcionamento.

## 3. Menor escopo possível

Comece pelos arquivos citados na tarefa e pelas dependências diretas.

Só amplie a busca quando houver evidência concreta de que o problema está fora desse escopo.

Não:

- refatore por gosto;
- “aproveite” para corrigir coisas não relacionadas;
- mude comportamento validado sem necessidade explícita;
- transforme tarefa de análise em implementação sem autorização.

## 4. Não misture tarefas

Uma branch deve representar um objetivo coerente.

Correções não relacionadas devem ser separadas.

## 5. Trabalhe de forma isolada

Por padrão, use branch específica para tarefas relevantes.

Não altere `main` diretamente salvo autorização explícita do projeto.

Quando houver múltiplas tarefas simultâneas ou risco de conflito, use worktree se o ambiente suportar.

## 6. Diferencie evidências

Você só pode afirmar aquilo que a evidência realmente prova.

Exemplos:

- build passou → `BUILD OK`;
- smoke passou → `SMOKE OK`;
- registro/composição foi conferido → `ESTRUTURAL OK`;
- execução real ocorreu → `FUNCIONAL OK`;
- execução real não ocorreu → `FUNCIONAL PENDENTE`.

Nunca converta automaticamente uma camada em outra.

## 7. Não promova versão automaticamente

Uma versão nova não substitui a última versão funcionalmente validada apenas porque:

- possui número maior;
- compilou;
- passou em smoke tests;
- foi mergeada;
- recebeu tag;
- recebeu release.

A referência funcional/GOLDEN só muda quando a política de validação do projeto for satisfeita.

## 8. Operações críticas

No fluxo de referência deste método, não execute sem autorização explícita:

- merge;
- rebase;
- force push;
- tag;
- release;
- mudança da GOLDEN;
- exclusão relevante;
- sobrescrita de histórico remoto.

Se o projeto possuir política diferente, ela deve estar registrada explicitamente.

## 9. Execute o que estiver autorizado

Se uma operação está dentro do escopo autorizado e a ferramenta permite executá-la, execute-a.

Não transfira desnecessariamente para o humano comandos que o agente consegue realizar.

Não peça ao usuário para repetir uma operação que já foi concluída.

## 10. Fallback manual apenas por falha real

Se a ferramenta não conseguir executar uma etapa:

- informe o erro exato;
- informe o que já foi concluído;
- preserve o estado alcançado;
- forneça apenas as etapas/comandos ainda pendentes.

Não transforme limitação da ferramenta em trabalho manual desnecessário.

## 11. Estado inesperado

Se encontrar:

- alterações locais desconhecidas;
- branch diferente da esperada;
- commits que não pertencem à tarefa;
- conflito entre documentação e Git;
- evidência funcional incompatível com a versão atual;

pare antes de destruir ou sobrescrever qualquer coisa.

Primeiro entenda e reporte o estado.

Consulte `16-RECUPERACAO-E-INCIDENTES.md`.

## 12. Critério de conclusão

Não use apenas “pronto” ou “concluído”.

Use o estado mais forte que as evidências permitem:

- `ANALISADO`;
- `IMPLEMENTADO`;
- `BUILD OK`;
- `TESTES LÓGICOS/SMOKE OK`;
- `ESTRUTURAL OK`;
- `FUNCIONAL PENDENTE`;
- `FUNCIONAL OK`;
- `ACEITO`;
- `INTEGRADO`;
- `PUBLICADO`.

Se faltar uma validação obrigatória, declare a pendência.

Exemplo:

> `IMPLEMENTADO — BUILD OK — SMOKE OK — FUNCIONAL PENDENTE`

## 13. Handoff / troca de IA

Se a tarefa terminar sem conclusão total, deixe um estado retomável.

Registre no relatório ou em `PROJECT_STATE.md`, conforme o projeto:

```text
Objetivo:
Branch:
Arquivos relevantes:
O que foi feito:
Evidências obtidas:
O que falta:
Próximo passo seguro:
Autorizações ainda necessárias:
```

Outra IA deve conseguir continuar sem reconstruir toda a conversa anterior.

## 14. Relatório final obrigatório

Informe, de forma objetiva:

- arquivos alterados;
- resumo da mudança;
- branch;
- commit/PR, quando aplicável;
- build e resultado;
- testes executados e resultado;
- validação funcional e resultado;
- artefatos gerados;
- o que não foi testado;
- pendências;
- operações críticas ainda dependentes de autorização.

## 15. Proibições de linguagem

Não use afirmações mais fortes que a evidência.

Evite:

- “100% funcionando” sem validação compatível;
- “sem regressões” sem testes que sustentem isso;
- “validado” quando houve apenas build;
- “estável” apenas porque foi publicada uma release.

## 16. Teste de aderência do agente

Antes de começar uma alteração, a IA deveria conseguir responder:

1. Qual é o objetivo da tarefa?
2. Qual é a branch correta?
3. Qual é o estado atual do projeto?
4. Qual é a referência funcional conhecida?
5. Quais arquivos provavelmente pertencem ao menor escopo?
6. Quais validações são necessárias?
7. Quais operações exigem autorização humana?
8. O que poderá ser afirmado ao final com base nas evidências?

Se essas respostas ainda não puderem ser obtidas, investigue o contexto persistido antes de editar.
