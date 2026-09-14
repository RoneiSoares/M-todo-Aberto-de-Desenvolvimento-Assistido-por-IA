# Método Aberto de Desenvolvimento Assistido por IA

> **Versão 0.1 — experimental e aberta à crítica**

Uma proposta aberta para organizar desenvolvimento de software com participação ativa de agentes de IA, mantendo **rastreabilidade, evidência técnica, memória persistente e controle humano sobre decisões críticas**.

Este projeto nasceu de experiências reais de desenvolvimento de automações e plugins, especialmente em cenários nos quais **compilar não significa necessariamente funcionar no ambiente real**.

A proposta não é substituir TDD, BDD, SDD, CI/CD, revisão de código ou outras práticas de engenharia de software. O objetivo é discutir como essas práticas podem ser organizadas quando IAs deixam de ser apenas assistentes de texto e passam a **investigar, editar arquivos, executar builds, testar e operar sobre repositórios**.

## Status

- Versão atual: **v0.1**
- Estado: **experimental**
- Nome: **provisório**
- Desenvolvimento: **aberto à colaboração**

Nenhuma alegação de originalidade é feita sobre práticas individuais descritas aqui. Git, branches, testes, baselines, especificações, revisão humana e automação já possuem longa história. O que está sendo colocado em discussão é **a combinação e a organização dessas práticas em um fluxo de desenvolvimento fortemente assistido por IA**.

---

# 1. Princípio central

## IA pode produzir trabalho. Evidência valida o trabalho.

Uma implementação não deve ser considerada correta apenas porque uma IA informou que terminou a tarefa, porque o código foi gerado ou porque o projeto compilou.

**Geração não é validação.**

O nível de confiança em uma mudança deve ser sustentado por evidências adequadas ao risco e ao tipo de alteração realizada.

---

# 2. Três fontes de verdade

O método evita tratar um único artefato como verdade absoluta.

## 2.1 Intenção

A especificação, requisito, issue ou decisão registrada responde:

> **O que deveria acontecer?**

Exemplo:

> A rede deve respeitar recobrimento mínimo de 0,90 m.

## 2.2 Implementação

O repositório responde:

> **O que está implementado atualmente?**

Código, configurações, testes, decisões e documentação relevantes devem estar persistidos fora da conversa com a IA.

## 2.3 Comportamento conhecido

Testes e evidências funcionais respondem:

> **O que sabemos que realmente funciona?**

Quando existe uma versão previamente validada em ambiente real, ela pode assumir o papel de uma referência comportamental chamada neste método de **GOLDEN**.

---

# 3. GOLDEN

**GOLDEN** é uma versão conhecida e funcional do sistema utilizada como referência comportamental.

Ela não é necessariamente:

- o último commit;
- o último build;
- a última release;
- a versão mais nova;
- a branch principal.

Uma nova versão pode existir sem substituir a GOLDEN.

A referência só deve mudar quando houver evidência suficiente de que a nova versão mantém ou melhora o comportamento esperado.

> **Mais novo ≠ mais confiável.**

Na v0.1, GOLDEN é recomendado principalmente em projetos com forte dependência de validação em ambiente real. Ainda está em discussão se esse conceito deve ser obrigatório no método.

---

# 4. Camadas de evidência

O método separa explicitamente tipos diferentes de validação.

## BUILD

O projeto compila.

É uma evidência importante, mas não prova que o comportamento esperado ocorre no ambiente real.

## SMOKE

Uma execução básica confirma que o sistema inicia e que suas funções essenciais não falham imediatamente.

## ESTRUTURAL

Confirma propriedades internas ou artefatos esperados, como:

- arquivos presentes;
- comandos registrados;
- dependências carregadas;
- configurações corretas;
- objetos gerados;
- estrutura prevista no projeto.

## FUNCIONAL

A funcionalidade é executada no ambiente em que realmente será utilizada.

Em plugins CAD/BIM, por exemplo, isso pode significar testar dentro do próprio software hospedeiro e usando um projeto representativo.

## ACEITAÇÃO HUMANA

Quando aplicável, uma pessoa responsável confirma que o comportamento produzido atende ao objetivo pretendido.

> **BUILD OK não significa FUNCIONAL OK.**

---

# 5. Fluxo de referência

```text
INTENÇÃO
   ↓
TAREFA / ISSUE
   ↓
BRANCH ISOLADA
   ↓
IMPLEMENTAÇÃO
   ↓
BUILD
   ↓
SMOKE / ESTRUTURAL / FUNCIONAL
   ↓
EVIDÊNCIAS
   ↓
REVISÃO
   ↓
INTEGRAÇÃO
   ↓
RELEASE
   ↓
GOLDEN, quando aplicável
```

Cada projeto pode adaptar esse fluxo, mas deve deixar claro quais etapas foram executadas e quais foram omitidas.

---

# 6. Papéis

O método diferencia responsabilidades em vez de tratar todas as ferramentas de IA como uma única entidade.

## Humano

Responsável por:

- objetivo;
- prioridade;
- decisões críticas;
- contexto de negócio ou engenharia;
- validação que dependa de julgamento;
- autorização de operações sensíveis.

O humano não precisa escrever todo o código, mas permanece responsável pela aceitação de mudanças relevantes.

## IA de raciocínio / arquitetura

Pode auxiliar em:

- transformação de necessidade em requisito;
- investigação;
- arquitetura;
- decomposição de tarefas;
- análise de evidências;
- documentação.

## Agente executor

Pode, conforme autorização:

- editar arquivos;
- escrever código;
- executar comandos;
- rodar build;
- executar testes;
- criar branches e PRs;
- atualizar documentação.

O método não deve depender de uma ferramenta específica.

## Repositório

Mantém o estado persistente e auditável do projeto.

Conversas são uma interface de trabalho. **Não devem ser a única memória do projeto.**

---

# 7. Memória persistente

Contexto importante deve sobreviver a uma conversa específica, a um agente específico e a uma troca de ferramenta.

Arquivos como os seguintes podem ser usados:

```text
AGENTS.md
PROJECT_STATE.md
TEST_MATRIX.md
DECISIONS.md
```

Os nomes são apenas exemplos. O princípio é:

> **Conhecimento crítico precisa estar persistido em artefatos acessíveis e versionados.**

---

# 8. Controle de risco

Quanto maior o impacto potencial de uma operação, maior deve ser o nível de controle exigido.

Ações locais e facilmente reversíveis podem receber maior autonomia.

Operações que alteram histórico, publicam software ou substituem uma referência validada merecem controle adicional.

Exemplos:

- merge;
- rebase;
- force push;
- criação de tag;
- publicação de release;
- substituição de GOLDEN;
- remoção de artefatos relevantes.

A intenção não é impedir automação.

> **Velocidade não deve eliminar governança.**

---

# 9. Critério de conclusão

Uma tarefa não deve ser considerada concluída apenas porque o agente informou **“concluído”**.

Cada projeto deve definir o que significa **DONE**.

Um exemplo:

```text
requisito atendido
+ código persistido
+ build válido
+ validações necessárias executadas
+ documentação relevante atualizada
+ evidência registrada
= DONE
```

Quando a implementação existe, mas depende de teste externo ainda não executado, um estado explícito é preferível:

> **IMPLEMENTADO — AGUARDANDO VALIDAÇÃO FUNCIONAL**

Isso é melhor do que declarar algo funcionando sem evidência.

---

# 10. Rastreabilidade

Sempre que fizer sentido, deve existir ligação entre:

```text
PROBLEMA → REQUISITO → ALTERAÇÃO → EVIDÊNCIA → VERSÃO
```

O objetivo é permitir responder depois:

- Por que isso foi alterado?
- Qual necessidade originou a mudança?
- O que foi efetivamente modificado?
- Como sabemos que funciona?
- Qual versão foi validada?

A intenção é aumentar rastreabilidade sem transformar o processo em burocracia excessiva.

---

# 11. Assistido por IA não significa autônomo por padrão

Agentes podem possuir grande autonomia operacional para investigar, implementar e testar.

Isso não significa que toda decisão deva ser delegada.

A proposta é combinar:

> **velocidade da IA + contexto humano + evidência técnica + histórico auditável**

---

# 12. O que este método não pretende substituir

Este método não pretende substituir:

- TDD;
- BDD;
- SDD;
- CI/CD;
- GitFlow;
- Trunk-Based Development;
- revisão de código;
- testes automatizados;
- DevOps;
- práticas tradicionais de engenharia de software.

Ele pode utilizar várias dessas práticas.

A pergunta principal é outra:

> **Como organizar o desenvolvimento quando agentes de IA passam a participar ativamente da criação e manutenção do software?**

---

# 13. Independência de ferramenta

ChatGPT, Codex, Claude, Cursor, Copilot e outras ferramentas podem mudar ou desaparecer.

Por isso, princípios devem ser independentes de produtos específicos.

Exemplo:

- **Princípio:** contexto crítico deve ser persistente.
- **Implementação possível:** `AGENTS.md`.

Outro projeto pode cumprir o mesmo princípio de outra forma.

---

# 14. Critérios mínimos da v0.1

Na versão 0.1, consideramos que uma aplicação do método deve possuir, no mínimo:

1. estado relevante do projeto persistido fora da conversa com IA;
2. separação explícita entre implementação e validação;
3. evidência proporcional ao nível de conclusão alegado;
4. controle humano definido para operações consideradas críticas.

GOLDEN é recomendado, mas ainda está sendo discutido como requisito obrigatório.

---

# 15. Hipótese de uso

A hipótese inicial é que o método seja especialmente útil quando:

- agentes de IA participam intensamente do desenvolvimento;
- testes importantes dependem de software externo;
- o ambiente real é difícil de reproduzir automaticamente;
- existem integrações com CAD, BIM, engenharia, aplicações desktop ou sistemas legados;
- uma regressão funcional pode passar mesmo com build verde.

Essa hipótese ainda precisa ser testada em outros domínios.

---

# 16. Origem

A proposta surgiu durante o desenvolvimento de ferramentas e automações reais, incluindo projetos integrados ao Autodesk Civil 3D.

Alguns problemas apareceram repetidamente:

- código compilando sem garantir comportamento correto;
- contexto importante mantido apenas em conversa;
- agentes diferentes precisando reconstruir o estado do projeto;
- necessidade de preservar uma versão funcional conhecida;
- operações de alto impacto exigindo limites claros.

A v0.1 organiza as práticas que surgiram para lidar com esses problemas.

---

# 17. O que queremos descobrir

Esta versão está sendo publicada cedo de propósito.

Queremos críticas sobre:

- quais regras são realmente gerais;
- quais regras são específicas do contexto de origem;
- o que já existe com outro nome na literatura ou na indústria;
- quais partes estão burocráticas demais;
- quais riscos não estão sendo considerados;
- como adaptar o processo para equipes maiores;
- como aplicar o método fora de CAD/BIM;
- quais etapas podem ser automatizadas por CI/CD;
- se GOLDEN deve ser obrigatório ou opcional;
- quais critérios deveriam definir adesão ao método.

Discordâncias são bem-vindas.

O objetivo não é provar que a v0.1 está certa.

> **O objetivo é melhorar o método através do uso, da crítica e de evidências.**

---

# 18. Como contribuir

Você pode contribuir abrindo uma **Issue** ou propondo uma alteração via **Pull Request**.

Quando possível, use esta estrutura:

```text
Problema
→ mudança proposta
→ motivo
→ exemplo real
```

Veja também [`CONTRIBUTING.md`](CONTRIBUTING.md).

---

# 19. Próximos passos

A proposta será testada em projetos diferentes e evoluirá conforme os resultados.

A pergunta para cada regra será:

> **Essa regra continua fazendo sentido fora do projeto onde nasceu?**

Se uma regra só funcionar em um projeto específico, ela provavelmente pertence à documentação daquele projeto, e não ao método geral.

Veja o [`ROADMAP.md`](ROADMAP.md) para acompanhar as próximas discussões.

---

# Conclusão

IA está mudando rapidamente a forma como software é produzido.

A proposta deste método parte de uma ideia simples:

> **IA pode acelerar drasticamente a produção de software, mas confiança deve continuar vindo de evidência.**

Esta é apenas a versão 0.1.

Se alguma parte estiver errada, incompleta ou desnecessária, queremos descobrir agora.

---

## Autoria e colaboração

Proposta inicial organizada por **Ronei Soares**, a partir de experiências práticas de desenvolvimento assistido por IA.

A evolução do método é aberta a contribuições da comunidade.
