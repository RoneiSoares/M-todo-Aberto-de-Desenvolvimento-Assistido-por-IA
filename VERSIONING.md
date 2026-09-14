# VERSIONING

## Estados usados

- Em desenvolvimento
- Candidata
- Funcionalmente validada
- Integrada
- Publicada
- GOLDEN

## Regra de promoção

Uma versão nova não substitui a GOLDEN por número maior, build, smoke, merge ou release isoladamente.

Para promover a GOLDEN deste laboratório é necessário:
1. build válido;
2. smoke relevante válido;
3. validação funcional definida em `PROJECT_STATE.md`;
4. ausência de regressão conhecida nos cenários relevantes;
5. autorização humana explícita para mudança da referência.
