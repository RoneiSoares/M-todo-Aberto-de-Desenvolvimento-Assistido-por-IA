# 17 — Definition of Done por risco

`DONE` não significa apenas “código escrito”. Neste método, uma tarefa só pode receber o estado final compatível com as evidências exigidas para o risco daquela mudança.

## 1. Por que usar níveis de risco

Nem toda tarefa precisa do mesmo peso de validação. Corrigir um texto de documentação não exige o mesmo processo de uma alteração que muda cálculo, persistência, integração externa ou comportamento em software hospedeiro.

O objetivo é evitar dois extremos:

- validar pouco uma mudança arriscada;
- transformar uma mudança simples em burocracia desnecessária.

## 2. Classificação sugerida

### Risco baixo

Exemplos:

- documentação;
- comentários;
- texto de interface sem lógica;
- ajustes sem efeito de runtime.

Evidência mínima típica:

- diff revisado;
- formatação/estrutura válida;
- links ou referências conferidos quando aplicável.

Estado possível:

`DONE DOCUMENTAL`

### Risco médio

Exemplos:

- regra isolada;
- formatação de saída;
- comando simples;
- alteração interna com cobertura lógica confiável.

Evidência mínima típica:

- build;
- teste lógico/smoke relevante;
- diff revisado;
- teste funcional quando o ambiente real puder alterar o resultado.

Estado possível antes do teste real:

`IMPLEMENTADO — BUILD OK — SMOKE OK — FUNCIONAL PENDENTE`

### Risco alto

Exemplos:

- cálculo principal;
- persistência de dados;
- integração com software externo;
- migração;
- automação que altera projeto do usuário;
- mudança em comportamento previamente validado;
- release distribuída para terceiros.

Evidência esperada:

- build válido;
- testes lógicos/smoke aplicáveis;
- validação estrutural quando aplicável;
- teste funcional no ambiente real ou ambiente representativo definido;
- revisão das regressões relevantes;
- aceitação humana quando o resultado depende de julgamento;
- documentação de estado atualizada.

## 3. Critérios gerais de DONE

Uma tarefa pode ser considerada concluída quando, conforme seu risco:

```text
objetivo atendido
+ escopo respeitado
+ alteração persistida
+ validações obrigatórias executadas
+ evidências registradas
+ pendências explicitadas
+ documentação de estado atualizada quando necessário
= DONE compatível com o risco
```

## 4. O que impede DONE

Não declarar `DONE` quando:

- falta teste obrigatório;
- existe erro conhecido não registrado;
- o resultado depende de ambiente real ainda não testado;
- a versão executada no teste não está identificada;
- a alteração contém trabalho alheio ao escopo sem revisão;
- existe operação crítica pendente e ela é necessária para o objetivo declarado.

## 5. DONE da tarefa não é igual a release

Uma tarefa pode estar concluída dentro de sua branch e ainda não estar:

- integrada;
- publicada;
- versionada;
- promovida a GOLDEN.

Use estados separados.

Exemplo:

```text
TAREFA: FUNCIONAL OK
PR: AGUARDANDO REVISÃO
MAIN: NÃO INTEGRADO
RELEASE: NÃO PUBLICADA
GOLDEN: SEM ALTERAÇÃO
```

## 6. Regra final

> A força da palavra usada para descrever o estado nunca deve superar a força da evidência disponível.
