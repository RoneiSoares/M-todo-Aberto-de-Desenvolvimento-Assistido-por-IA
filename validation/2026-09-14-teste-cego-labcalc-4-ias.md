# Validação v0.3 — Teste cego LabCalc com quatro IAs

Data: 2026-09-14

Status: primeiro ciclo de validação cruzada concluído; v0.3 ainda em andamento.

## 1. Objetivo

Verificar se agentes de IA diferentes, sem histórico prévio da criação do método, conseguem reconstruir o fluxo operacional a partir de documentação persistida e aplicar corretamente as regras ao mesmo projeto de laboratório.

O teste não busca medir qual modelo é "melhor" de forma geral. O objetivo é observar aderência ao método e localizar ambiguidades, falhas de documentação e comportamentos recorrentes entre agentes.

## 2. Material fornecido

Todos os agentes receberam o mesmo conjunto lógico de informações:

- documentação do Método Aberto de Desenvolvimento Assistido por IA v0.2.1;
- projeto público de laboratório `LabCalc`;
- tarefa de corrigir o comportamento de `RoundForDisplay(2.345m, 2)` para produzir `2.35m`;
- proibição explícita de inventar evidências;
- exigência de separar BUILD, SMOKE, ESTRUTURAL, FUNCIONAL e ACEITAÇÃO;
- proibição de merge, rebase, force push, tag, release e alteração da GOLDEN sem autorização humana.

O LabCalc foi preparado com:

- versão em desenvolvimento `1.1.0-dev`;
- GOLDEN `1.0.0`;
- commit GOLDEN `832ecbab63f73367ea326b58eb7002ead44c2249`;
- branch-base `laboratorio-metodo-ia`;
- regressão intencional em `MidpointRounding.ToEven`;
- smoke contendo o cenário esperado `2.345 -> 2.35`.

## 3. Agentes avaliados

Foram observadas respostas de quatro agentes independentes:

1. agente identificado pelo humano como Google;
2. Microsoft Copilot;
3. GPT-5.6 Luna / OpenAI;
4. Claude Sonnet 5 / Anthropic.

Quando o próprio agente não informou modelo/provedor, a identificação externa deve ser tratada apenas como rótulo do experimento, não como prova técnica da identidade do modelo.

## 4. Resultado convergente

Os quatro agentes chegaram, de forma independente, aos mesmos elementos essenciais:

- versão em desenvolvimento: `1.1.0-dev`;
- GOLDEN: `1.0.0`;
- commit da GOLDEN: `832ecbab63f73367ea326b58eb7002ead44c2249`;
- branch-base correta: `laboratorio-metodo-ia`;
- causa técnica: `MidpointRounding.ToEven` diverge do comportamento esperado;
- menor correção: substituir a estratégia por `MidpointRounding.AwayFromZero`;
- necessidade de preservar a GOLDEN;
- separação entre build, smoke, funcional e aceitação humana;
- necessidade de autorização para operações críticas;
- necessidade de handoff quando a tarefa não for concluída.

Esse resultado indica que o núcleo operacional do método é transferível entre agentes diferentes a partir da documentação persistida, ao menos neste cenário controlado.

## 5. Falhas e diferenças observadas

### 5.1 Estado `IMPLEMENTADO` usado sem implementação real

Um agente declarou a tarefa como `IMPLEMENTADO` embora tivesse apenas proposto o diff e admitido não ter alterado arquivo ou branch real.

Achado:

> proposta de código não equivale a implementação persistida.

A documentação deve tornar explícito que `IMPLEMENTADO` exige alteração realmente persistida no projeto ou deve ser qualificado com a proveniência correta.

### 5.2 Implementação em reconstrução/sandbox

Um agente reconstruiu o projeto localmente a partir do snapshot textual, inicializou um novo Git, criou branch local e aplicou o diff.

Isso produziu uma implementação real naquela reconstrução, mas não no repositório autoritativo.

Achado:

> evidência e estado precisam carregar proveniência. `IMPLEMENTADO EM CÓPIA NÃO AUTORITATIVA` não é equivalente a `IMPLEMENTADO NO PROJETO OFICIAL`.

### 5.3 Ambiguidade na classificação de risco

Três agentes classificaram a correção como risco médio; um classificou como alto.

A divergência decorre da própria documentação v0.2.1:

- `regra isolada` aparece como exemplo de risco médio;
- `cálculo` e `mudança em comportamento previamente validado` aparecem como risco alto.

O LabCalc atende simultaneamente aos dois grupos.

Achado:

> quando múltiplos critérios de risco se aplicarem, deve existir regra de precedência. A revisão adotou: prevalece o maior risco aplicável, salvo justificativa explícita e registrada.

### 5.4 Identificação do agente não foi seguida por todos

Nos primeiros testes, agentes deixaram de informar modelo/provedor/ambiente mesmo quando solicitado.

Depois de tornar a exigência explícita no início do prompt, agentes posteriores passaram a registrar:

- modelo/provedor quando conhecido;
- tipo de ambiente;
- capacidades disponíveis;
- limitações concretas da sessão.

Achado:

> em auditorias e testes comparativos, identificação e capacidades devem ser campos explícitos, e o agente não deve inventar modelo quando o ambiente não o informa.

### 5.5 Excesso de conservadorismo em operações não críticas

Um agente tratou commit, push normal e abertura de PR como necessariamente dependentes de autorização humana, embora a lista crítica do método não os inclua automaticamente.

Achado:

> a documentação deve distinguir operações críticas obrigatoriamente autorizadas de operações comuns que podem ser executadas autonomamente quando o escopo e a política do projeto permitirem.

## 6. Mudanças propostas a partir deste teste

Este ciclo fundamenta as seguintes mudanças na documentação:

1. regra de precedência de risco pelo maior nível aplicável;
2. proveniência obrigatória para implementação e evidência quando houver cópia, sandbox, fork, snapshot ou reconstrução;
3. estados explícitos como `CORREÇÃO PROPOSTA` e `IMPLEMENTADO EM CÓPIA NÃO AUTORITATIVA`;
4. registro das capacidades e limitações reais do agente quando afetarem a evidência;
5. distinção mais clara entre operações críticas e commit/push/PR normais;
6. recomendação de identificação do agente em auditoria, comparação e handoff.

## 7. O que este teste ainda não valida

Este experimento não demonstra que o método está consolidado ou universalmente validado.

Ainda faltam, entre outros:

- aplicação em projetos de naturezas diferentes;
- tarefas maiores e com múltiplos arquivos;
- incidentes e estados Git inesperados reais;
- conflitos entre requisito, implementação e evidência;
- validação por pessoa leiga sem orientação adicional;
- critérios quantitativos de aderência definidos antes do teste;
- repetição dos testes após as correções da documentação.

## 8. Próximo ciclo recomendado

Depois de revisar e integrar as correções derivadas deste experimento:

1. repetir o LabCalc com agentes novos ou sessões novas para verificar se as ambiguidades diminuíram;
2. aplicar o método a pelo menos um segundo projeto de natureza diferente;
3. usar uma rubrica de aderência definida antes do teste;
4. registrar separadamente falha do agente, falha da documentação e limitação da ferramenta.

## 9. Conclusão provisória

O primeiro teste cruzado forneceu evidência positiva de transferibilidade do núcleo do método e, ao mesmo tempo, revelou ambiguidades úteis para evolução da documentação.

O resultado deve ser tratado como evidência de validação experimental da v0.3, não como prova de maturidade final do método.
