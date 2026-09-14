# PROJECT_STATE

## Produto

LabConfig

## Estado atual

- versão atual: `1.0.0`
- branch-base: `laboratorio-persistencia-v0.3`
- estado: funcionalmente validada
- referência funcional / GOLDEN: `1.0.0`

## Comportamento funcional conhecido

`SettingsStore.Load(path)`:
- carrega JSON válido;
- retorna valores padrão quando o arquivo não existe;
- em JSON inválido, retorna valores padrão **sem modificar o arquivo original**.

## Ambiente funcional definido

A validação funcional mínima exige:
1. executar o smoke;
2. executar o aplicativo console;
3. confirmar que um arquivo JSON inválido permanece byte-a-byte inalterado após `Load`;
4. confirmar que a aplicação retorna configurações padrão para esse caso.

## Regra de segurança

Falha de leitura nunca autoriza destruição automática do arquivo de origem.
