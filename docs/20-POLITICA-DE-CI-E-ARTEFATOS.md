# 20 — Política de CI e artefatos

## Princípio central

> **CI produz evidência; release preserva binários.**

O fluxo de integração contínua deve provar que uma mudança compila, passa nos testes aplicáveis e mantém as verificações definidas pelo projeto. Ele não deve virar um depósito permanente de executáveis a cada commit.

## 1. Execução normal de CI

Em `push`/PR comum, por padrão:

- compilar;
- executar testes relevantes;
- executar validações estruturais necessárias;
- publicar status PASS/FAIL;
- **não persistir binários como artifact**.

A frequência alta de CI é aceitável quando ela produz evidência útil. O problema é transformar cada execução em armazenamento persistente desnecessário.

## 2. Quando um artifact temporário é permitido

Persistir um artifact de CI somente quando ele for necessário para uma etapa posterior concreta, por exemplo:

- validação funcional humana;
- teste em ambiente que não pode recompilar o projeto;
- candidata/RC que precisa ser instalada exatamente como foi gerada;
- evidência temporária que dependa do arquivo gerado.

Quando persistir, registrar:

- motivo;
- commit/branch de origem;
- conteúdo do artifact;
- tamanho aproximado quando relevante;
- retenção definida.

Retenção recomendada para artifacts temporários: **1 a 3 dias**, salvo justificativa explícita do projeto.

## 3. RC, release e GOLDEN

Uma candidata/RC pode usar artifact temporário quando necessário para validação funcional.

Uma versão aprovada para preservação permanente deve ser publicada como **Release Asset** associado à tag aprovada, e não mantida indefinidamente em GitHub Actions Artifacts.

A promoção para release/GOLDEN continua obedecendo às regras de validação, aceitação e autorização do método.

## 4. Gatilhos de workflow

Evite executar a mesma validação duas vezes para o mesmo estado sem benefício claro.

Exemplo comum de redundância:

- workflow em `push` para `feature/**`;
- e o mesmo workflow em `pull_request` para `main`;
- com PR já aberto para a mesma branch.

Quando apropriado:

- escolha o gatilho mínimo suficiente;
- use `concurrency`;
- use `cancel-in-progress` para cancelar execução obsoleta da mesma linha de trabalho.

## 5. Antes de adicionar `upload-artifact`

O agente deve conseguir responder:

1. Quem vai consumir esse arquivo depois da execução?
2. Por que o status/log/teste não é suficiente?
3. Quanto aproximadamente ele ocupa?
4. Por quanto tempo precisa existir?
5. Ele é temporário ou permanente?
6. Se permanente, por que não deve ser um Release Asset?

Se não houver resposta concreta, não persistir o artifact por padrão.

## 6. Evidência não é sinônimo de arquivo binário

Evidência pode ser:

- status do workflow;
- log de teste;
- resultado registrado em `TEST_MATRIX.md`;
- hash/commit;
- diff revisado;
- relatório persistido;
- execução funcional documentada.

Não criar binário persistente apenas para dizer que existe uma evidência.

## 7. Limites, custo e manutenção

Ao criar ou revisar CI, considerar também:

- frequência esperada das execuções;
- tamanho de artifacts/caches;
- retenção;
- gatilhos redundantes;
- orçamento/cota disponível da plataforma;
- política de limpeza.

Para projetos com muitas iterações por IA, essa revisão é especialmente importante porque dezenas de commits podem ser produzidos em pouco tempo.

## 8. Regra operacional resumida

```text
Commit / PR normal
→ build
→ testes
→ PASS/FAIL
→ sem artifact persistente por padrão

RC para teste funcional
→ build
→ testes
→ artifact temporário quando necessário
→ retenção curta

Release / GOLDEN aprovada
→ tag
→ Release
→ binário permanente como Release Asset
```

## 9. Regra para agentes

Ao criar ou alterar um workflow, não considerar a tarefa concluída sem revisar:

- gatilhos;
- duplicidade de execução;
- persistência de artifacts;
- retenção;
- tamanho/custo provável;
- destino correto de binários permanentes.

Um workflow tecnicamente correto pode ainda estar operacionalmente errado se desperdiçar armazenamento ou execução de forma evitável.
