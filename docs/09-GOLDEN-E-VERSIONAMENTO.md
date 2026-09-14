# 09 — GOLDEN e versionamento

## GOLDEN

É a referência comportamental mais confiável conhecida.

Não é automaticamente:
- `main`;
- última versão;
- última tag;
- última release;
- último build.

## Estados de versão

### Em desenvolvimento
Código ainda sujeito a mudança.

### Candidata
Versão delimitada para avaliação, com build/testes aplicáveis registrados.

### Funcionalmente validada
Candidata aprovada no ambiente real definido.

### Tag
Marcador Git imutável autorizado.

### Release
Pacote publicado a partir de tag aprovada.

### GOLDEN
Referência comportamental escolhida para comparação/regressão.

## Promoção da GOLDEN

Antes de substituir:
1. definir candidata;
2. congelar escopo;
3. registrar build;
4. registrar testes;
5. executar teste funcional;
6. revisar resultado;
7. obter aceitação;
8. atualizar `PROJECT_STATE.md` e `TEST_MATRIX.md`;
9. somente então promover.

## Regra importante

Uma nova versão pode coexistir com uma GOLDEN anterior por semanas ou meses.

Isso não é erro. É proteção contra regressão.
