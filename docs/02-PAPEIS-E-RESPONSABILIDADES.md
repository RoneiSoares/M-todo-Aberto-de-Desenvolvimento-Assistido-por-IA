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
- repetir comandos que já foram concluídos.

## IA de raciocínio / arquitetura

### Faz
- transforma pedido em requisito claro;
- identifica ambiguidades;
- planeja investigação;
- separa hipótese de evidência;
- ajuda a revisar resultados;
- prepara instruções para o agente.

### Não deve
- inventar estado do repositório;
- tratar memória de conversa como superior aos arquivos atuais;
- afirmar validação que não ocorreu.

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

## Repositório

É a memória persistente do projeto.

Deve conter:
- regras de trabalho;
- estado;
- evidências;
- histórico;
- arquitetura relevante;
- documentação de versionamento.
