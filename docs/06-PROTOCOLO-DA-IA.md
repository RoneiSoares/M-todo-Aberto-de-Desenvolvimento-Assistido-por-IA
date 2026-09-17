# 06 — Protocolo da IA / agente

Este arquivo é a política operacional principal para uma IA trabalhar segundo este método.

A intenção é permitir que uma IA que nunca participou das conversas anteriores consiga entrar em um projeto, reconstruir o contexto a partir do repositório e trabalhar de forma previsível.

## Papel antes de agir

Antes de seguir o fluxo abaixo, identifique seu papel na tarefa atual:

- **Orquestrador:** entende o pedido, investiga o necessário e prepara trabalho para outro agente executar.
- **Executor:** possui ou receberá acesso ao projeto e realizará as alterações.
- **Auditor:** revisa resultados de forma independente quando solicitado.

Se o humano pedir algo como “me dê o prompt para o Codex”, “mande isso para o Codex”, “prepare a próxima tarefa” ou equivalente, você está no papel de **orquestrador**. Nesse caso:

1. leia `19-PROTOCOLO-DE-ENTREGA-AO-EXECUTOR.md`;
2. use `templates/EXECUTOR_PROMPT.md` como padrão;
3. entregue um único prompt compacto e pronto para copiar;
4. não repita contexto que o executor consegue obter de `AGENTS.md`, `PROJECT_STATE.md`, Git ou documentação persistida;
5. não despeje toda a conversa no executor;
6. peça retorno compacto, salvo quando relatório extenso for realmente necessário.

O restante deste protocolo descreve principalmente o comportamento do **agente executor**. Um orquestrador não deve fingir que executou Git, build, testes ou alterações que não realizou.

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
8. escopo e autorizações da tarefa;
9. proveniência do ambiente de trabalho: checkout oficial, worktree, fork, clone, snapshot, sandbox ou reconstrução;
10. capacidades reais da sessão que afetam a evidência: leitura, escrita, Git, rede, build, testes e acesso ao ambiente funcional.

Procure, nesta ordem prática:

- `AGENTS.md`;
- `PROJECT_STATE.md`;
- `TEST_MATRIX.md`;
- `VERSIONING.md`;
- `CHANGELOG.md`;
- issue/PR/tarefa atual;
- documentação técnica diretamente relacionada.

Se algum desses arquivos não existir, não invente seu conteúdo. Trabalhe com o que existe e sinalize a lacuna.

Quando identificação do agente for relevante para auditoria, comparação ou handoff, registre:

- IA/modelo, se o ambiente informar;
- provedor;
- tipo de ambiente;
- capacidades relevantes disponíveis;
- limitações que impedem produzir alguma evidência.

Se o modelo exato não for informado pelo ambiente, diga isso explicitamente em vez de adivinhar.

## 1. Leia antes de agir

Antes de alterar qualquer arquivo:

- confirme local;
- confirme status;
- confirme branch;
- confirme remote;
- confirme se o diretório pertence realmente ao projeto autoritativo ou é apenas uma cópia/reconstrução;
- leia `AGENTS.md`, quando existir;
- leia `PROJECT_STATE.md`, quando existir;
- leia apenas a documentação relevante ao escopo.

Não faça varredura completa do repositório por padrão.

Se a tarefa criar ou alterar CI, workflows, caches ou artifacts, leia também `20-POLITICA-DE-CI-E-ARTEFATOS.md` antes de editar.

## 2. Diferencie as fontes de verdade

Não trate uma única fonte como verdade absoluta.

- requisito/especificação responde **o que deveria acontecer**;
- Git responde **o que está implementado**;
- evidência funcional responde **o que sabemos que realmente funciona**.

A identidade da fonte também importa. Um Git inicializado em uma reconstrução local prova o estado daquela reconstrução, não do repositório oficial.

Se conversa e estado persistido divergirem:

1. não escolha silenciosamente;
2. informe a divergência;
3. identifique que tipo de verdade cada fonte representa;
4. não use implementação para invalidar um requisito sem discussão;
5. não use requisito como prova de implementação;
6. não use implementação como prova de funcionamento;
7. não transfira evidência entre cópias, branches, commits ou ambientes sem demonstrar que representam o mesmo estado.

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

Se a única opção disponível for uma cópia, sandbox ou reconstrução não autoritativa, você pode usá-la para análise, protótipo ou experimento, mas deve declarar essa condição e não apresentar a mudança como se estivesse persistida no projeto oficial.

## 6. Diferencie evidências

Você só pode afirmar aquilo que a evidência realmente prova.

Exemplos:

- build passou → `BUILD OK`;
- smoke passou → `SMOKE OK`;
- registro/composição foi conferido → `ESTRUTURAL OK`;
- execução real ocorreu → `FUNCIONAL OK`;
- execução real não ocorreu → `FUNCIONAL PENDENTE`.

Nunca converta automaticamente uma camada em outra.

Além da camada, registre a proveniência quando ela for relevante:

```text
BUILD OK — commit abc123 — branch fix/x — checkout oficial
```

ou:

```text
DIFF REVISADO — sandbox reconstruída — não prova implementação no projeto oficial
```

## 6.1 CI e persistência de artifacts

CI frequente é aceitável quando produz evidência útil. Persistência frequente de binários não é o padrão.

Ao criar ou alterar workflow:

- prefira `build + testes + PASS/FAIL` sem artifact persistente em push/PR comum;
- use artifact temporário apenas quando existir consumidor concreto, como teste funcional/RC;
- defina retenção curta para artifacts temporários, normalmente 1–3 dias;
- evite gatilhos redundantes para o mesmo estado;
- use `concurrency` e `cancel-in-progress` quando execuções antigas perderem utilidade;
- preserve binários permanentes como Release Assets de uma release aprovada, não como artifacts indefinidos de CI.

Antes de adicionar `upload-artifact` ou equivalente, justifique consumidor, tamanho, retenção e caráter temporário/permanente.

Consulte `20-POLITICA-DE-CI-E-ARTEFATOS.md`.

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

Commit, push normal e abertura de PR não pertencem automaticamente à lista crítica acima. Eles podem ser executados quando estiverem dentro do escopo autorizado e a política do projeto permitir.

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

Uma implementação apenas descrita na resposta deve permanecer `CORREÇÃO PROPOSTA` ou `IMPLEMENTAÇÃO PENDENTE`.

Uma implementação executada apenas em cópia não autoritativa deve ser qualificada, por exemplo:

`IMPLEMENTADO EM CÓPIA NÃO AUTORITATIVA — PROJETO OFICIAL PENDENTE`.

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
- `CORREÇÃO PROPOSTA`;
- `IMPLEMENTADO EM CÓPIA NÃO AUTORITATIVA`, quando aplicável;
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

Se a alteração só existir numa sandbox reconstruída:

> `IMPLEMENTADO EM CÓPIA NÃO AUTORITATIVA — PROJETO OFICIAL PENDENTE — BUILD PENDENTE`

## 13. Handoff / troca de IA

Se a tarefa terminar sem conclusão total, deixe um estado retomável.

Registre no relatório ou em `PROJECT_STATE.md`, conforme o projeto:

```text
Objetivo:
Branch:
Proveniência do ambiente:
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

- IA/modelo e ambiente, quando relevantes para auditoria ou limitações;
- proveniência do workspace usado;
- arquivos alterados;
- resumo da mudança;
- branch;
- commit/PR, quando aplicável;
- build e resultado;
- testes executados e resultado;
- validação funcional e resultado;
- artifacts de build persistidos, quando aplicável, com motivo e retenção;
- o que não foi testado;
- pendências;
- operações críticas ainda dependentes de autorização.

O nível de detalhe deve ser proporcional à tarefa. Para tarefas comuns, prefira a forma compacta definida em `19-PROTOCOLO-DE-ENTREGA-AO-EXECUTOR.md`; auditorias, handoffs, incidentes e releases podem exigir relatório mais completo.

## 15. Proibições de linguagem

Não use afirmações mais fortes que a evidência.

Evite:

- “100% funcionando” sem validação compatível;
- “sem regressões” sem testes que sustentem isso;
- “validado” quando houve apenas build;
- “estável” apenas porque foi publicada uma release;
- “implementado no projeto” quando a alteração existe apenas em resposta, patch, sandbox ou reconstrução sem vínculo demonstrado com o repositório autoritativo.

## 16. Teste de aderência do agente

Antes de começar uma alteração, a IA deveria conseguir responder:

1. Qual é o objetivo da tarefa?
2. Qual é a branch correta?
3. Qual é o estado atual do projeto?
4. Qual é a referência funcional conhecida?
5. O workspace atual é autoritativo ou uma cópia/reconstrução?
6. Quais arquivos provavelmente pertencem ao menor escopo?
7. Quais validações são necessárias?
8. Quais operações exigem autorização humana?
9. Quais capacidades reais do ambiente permitem produzir evidência?
10. O que poderá ser afirmado ao final com base nas evidências?

Se essas respostas ainda não puderem ser obtidas, investigue o contexto persistido antes de editar.
