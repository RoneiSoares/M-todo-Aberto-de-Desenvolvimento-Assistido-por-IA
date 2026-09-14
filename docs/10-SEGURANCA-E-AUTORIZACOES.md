# 10 — Segurança e autorizações

## Nível baixo de risco
Normalmente permitidos dentro do escopo:
- leitura;
- busca;
- edição em branch isolada;
- build;
- testes;
- diff;
- commit/push quando o escopo autorizar.

## Nível médio
Pode exigir confirmação conforme projeto:
- criação de branch;
- alteração de configuração compartilhada;
- geração de artefatos;
- atualização de documentação de estado.

## Nível alto
No fluxo de referência exige autorização explícita:
- merge;
- rebase;
- force push;
- apagar branch importante;
- deletar arquivos relevantes;
- criar/mover tag;
- publicar release;
- substituir GOLDEN;
- sobrescrever histórico.

## Nunca destrua evidência para “limpar”

Não:
- apague commits para esconder tentativa;
- force-push para corrigir aparência;
- sobrescreva tag;
- substitua artefato validado sem registro.

## Princípio

> Quanto maior o custo de reversão ou o impacto, maior a necessidade de controle humano.
