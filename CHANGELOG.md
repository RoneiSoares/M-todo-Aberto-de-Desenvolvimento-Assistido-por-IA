# CHANGELOG

## 1.1.0-dev

- alteração experimental no fallback de leitura de JSON inválido;
- regressão conhecida: `Load` sobrescreve o arquivo inválido com valores padrão;
- validações da versão em desenvolvimento estão pendentes.

## 1.0.0

- implementação inicial do `LabConfig`;
- leitura de JSON com `System.Text.Json`;
- arquivo inexistente retorna padrão sem criar arquivo;
- JSON inválido retorna padrão sem sobrescrever o arquivo original;
- versão funcionalmente validada e aceita como referência inicial.
