# 18 — Handoff e retomada

O método deve permitir que outra pessoa ou outra IA continue uma tarefa sem depender do histórico completo de conversa.

## 1. Objetivo

Um bom handoff deve responder rapidamente:

- o que estamos tentando fazer;
- onde o trabalho está;
- o que já foi alterado;
- o que foi validado;
- o que ainda falta;
- qual é o próximo passo seguro;
- quais ações ainda exigem autorização.

## 2. Handoff mínimo

Use este formato:

```text
Projeto:
Objetivo da tarefa:
Branch:
Commit atual:
PR:
Arquivos principais:

O que já foi feito:
- ...

Evidências:
- Build:
- Smoke/Lógico:
- Estrutural:
- Funcional:
- Aceitação:

Pendências:
- ...

Próximo passo seguro:
- ...

Não fazer sem autorização:
- ...
```

## 3. Quando registrar

Registre handoff quando:

- a tarefa termina sem estar totalmente concluída;
- a conversa ficará longa ou será encerrada;
- outra IA/agente assumirá;
- houver bloqueio de ferramenta;
- o teste funcional depender do humano;
- houver mudança de sessão, máquina ou worktree;
- existir investigação importante ainda não implementada.

## 4. Onde registrar

Escolha conforme o projeto:

- `PROJECT_STATE.md` para estado durável do produto;
- PR para estado da mudança;
- issue para investigação/tarefa;
- relatório final para a sessão;
- arquivo próprio de handoff em projetos que precisem disso.

Não polua `PROJECT_STATE.md` com detalhes temporários que pertencem apenas a um PR.

## 5. Como a nova IA deve retomar

Antes de continuar:

1. leia a documentação operacional;
2. confirme branch/status/remote;
3. leia o handoff;
4. confira se o Git ainda corresponde ao handoff;
5. confira evidências registradas;
6. não repita trabalho já concluído sem motivo;
7. não assuma que uma pendência foi resolvida fora do registro;
8. prossiga do próximo passo seguro.

## 6. Divergência na retomada

Se o handoff disser uma coisa e o repositório mostrar outra:

- o estado real do Git deve ser verificado;
- a divergência deve ser reportada;
- nenhuma alteração desconhecida deve ser apagada automaticamente;
- evidências antigas devem ser associadas à versão/commit correto.

## 7. Exemplo

```text
Projeto: Plugin X
Objetivo: corrigir arredondamento da label
Branch: fix/label-arredondamento
Commit: abc123
PR: ainda não aberto

O que já foi feito:
- formatador corrigido;
- teste lógico criado.

Evidências:
- Build: OK
- Smoke/Lógico: OK
- Funcional: PENDENTE

Pendências:
- testar no aplicativo hospedeiro;
- atualizar TEST_MATRIX se aprovado.

Próximo passo seguro:
- carregar o artefato do commit abc123 no ambiente real.

Não fazer sem autorização:
- merge;
- tag;
- release.
```

## 8. Regra final

> Se outra pessoa ou IA precisa perguntar “onde paramos?” para reconstruir tudo do zero, o handoff foi insuficiente.
