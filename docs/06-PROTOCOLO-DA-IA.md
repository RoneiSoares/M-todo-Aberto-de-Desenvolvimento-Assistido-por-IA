# 06 — Protocolo da IA / agente

Este arquivo pode ser fornecido diretamente a uma IA como política de trabalho.

## Regra 1 — Leia antes de agir

Antes de alterar qualquer arquivo:
- confirme local;
- confirme status;
- confirme branch;
- confirme remote;
- leia `AGENTS.md`;
- leia `PROJECT_STATE.md`;
- leia apenas documentação relevante.

## Regra 2 — Não confie na conversa acima do repositório

Se conversa e estado persistido divergirem:
- não escolha silenciosamente;
- informe a divergência;
- use o estado persistido como referência operacional até resolução.

## Regra 3 — Menor escopo

Comece no menor conjunto de arquivos.

Não faça varredura total por padrão.

## Regra 4 — Não misture tarefas

Uma branch deve representar um objetivo coerente.

## Regra 5 — Não altere `main` diretamente

Use branch específica, salvo autorização explícita diferente.

## Regra 6 — Diferencie evidências

Você só pode afirmar aquilo que a evidência prova.

Exemplos:
- build passou → “BUILD OK”;
- smoke passou → “SMOKE OK”;
- teste real não ocorreu → “FUNCIONAL PENDENTE”.

## Regra 7 — Não promova versão automaticamente

Versão nova não substitui GOLDEN apenas por ser nova.

## Regra 8 — Ações críticas

Não executar sem autorização explícita:
- merge;
- rebase;
- force push;
- tag;
- release;
- mudança de GOLDEN;
- exclusão relevante;
- sobrescrita de histórico remoto.

## Regra 9 — Execute o que puder

Se uma operação está autorizada e a ferramenta permite, execute-a.

Não transfira desnecessariamente comandos para o humano.

## Regra 10 — Fallback manual só por falha real

Se não conseguir executar:
- informe erro exato;
- informe o que já foi concluído;
- forneça somente comandos pendentes.

## Regra 11 — Relatório final obrigatório

Informe:
- arquivos alterados;
- resumo;
- build;
- testes;
- evidência funcional;
- pendências;
- artefatos gerados;
- branch/PR quando aplicável.

## Regra 12 — Linguagem de estado

Use termos precisos:
- ANALISADO;
- IMPLEMENTADO;
- BUILD OK;
- TESTES LÓGICOS OK;
- FUNCIONAL PENDENTE;
- FUNCIONAL OK;
- ACEITO;
- INTEGRADO.

Nunca use “100% funcionando” sem evidência compatível.
