# 02 — Papéis e responsabilidades

## Humano

### Faz
- define o problema real;
- fornece contexto de negócio/engenharia;
- escolhe prioridades;
- decide trade-offs;
- aprova operações críticas;
- valida resultados que dependem de julgamento;
- executa ou confirma testes em software externo quando necessário.

### Não precisa fazer
- escrever todo o código;
- executar manualmente operações que o agente já pode executar;
- repetir comandos que já foram concluídos;
- reconstruir manualmente um prompt quando o orquestrador já possui o contexto necessário.

## IA de raciocínio / orquestrador

### Faz
- transforma pedido em requisito claro;
- identifica ambiguidades;
- planeja investigação;
- separa hipótese de evidência;
- ajuda a revisar resultados;
- prepara instruções para o agente executor;
- quando delegar, entrega um único prompt compacto, autocontido e pronto para copiar;
- evita repetir no prompt contexto que o executor pode obter do próprio projeto.

### Não deve
- inventar estado do repositório;
- tratar memória de conversa como superior aos arquivos atuais;
- afirmar validação que não ocorreu;
- despejar todo o histórico da conversa no executor;
- espalhar a tarefa em vários blocos que o humano precise remontar.

Quando o próximo passo for entregar trabalho ao Codex ou agente equivalente, siga `19-PROTOCOLO-DE-ENTREGA-AO-EXECUTOR.md` e prefira `templates/EXECUTOR_PROMPT.md`.

## Agente executor

### Faz
- confirma ambiente e estado Git;
- lê documentação relevante;
- investiga escopo mínimo;
- cria/usa branch correta;
- altera arquivos;
- compila;
- executa testes autorizados;
- revisa diff;
- commita/push quando autorizado pelo escopo;
- abre/atualiza PR;
- relata evidências.

### Não deve
- mergear sem autorização;
- fazer force push sem autorização;
- criar tag/release sem autorização;
- substituir GOLDEN sem autorização;
- esconder teste pendente;
- expandir escopo sem evidência;
- apagar ou sobrescrever histórico para “arrumar” o estado.

## Auditor independente

É um papel eventual, não uma etapa obrigatória de toda tarefa.

### Faz
- procura problemas concretos em requisitos, diff, testes, APIs externas, casos-limite e regressões relevantes;
- separa achado demonstrável de preferência pessoal;
- informa quando não encontra problema sustentado por evidência.

### Não deve
- reimplementar por preferência;
- exigir mudança arquitetônica apenas porque faria diferente;
- transformar auditoria em desenvolvimento paralelo sem autorização.

## Repositório

É a memória persistente do projeto.

Deve conter:
- regras de trabalho;
- estado;
- evidências;
- histórico;
- arquitetura relevante;
- documentação de versionamento.
