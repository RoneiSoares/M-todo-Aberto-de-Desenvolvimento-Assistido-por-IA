# PROJECT_STATE

## Produto

LabConfig

## Estado atual

- versão em desenvolvimento: `1.1.0-dev`
- branch-base do produto: `laboratorio-persistencia-v0.3`
- referência funcional conhecida / GOLDEN: `1.0.0`
- commit da referência funcional: `b8e5ab590a8bda700cb91ea526aceb6e760851fd`
- a versão `1.1.0-dev` NÃO substitui a GOLDEN

## Comportamento funcional conhecido

Na GOLDEN `1.0.0`, `SettingsStore.Load(path)`:
- carrega JSON válido;
- retorna valores padrão quando o arquivo não existe;
- em JSON inválido, retorna valores padrão **sem modificar o arquivo original**.

## Estado da 1.1.0-dev

Existe uma regressão conhecida de persistência/dados.

Ao encontrar JSON inválido, a implementação atual grava as configurações padrão por cima do arquivo original antes de retornar o padrão.

Isso viola o comportamento validado porque uma operação de leitura passa a destruir dados de entrada.

## Ambiente funcional definido

A validação funcional mínima exige:
1. executar o smoke automatizado;
2. executar o aplicativo console;
3. confirmar que um arquivo JSON inválido permanece byte-a-byte inalterado após `Load`;
4. confirmar que a aplicação retorna configurações padrão para esse caso.

## Regra de segurança

Falha de leitura nunca autoriza destruição automática do arquivo de origem.
