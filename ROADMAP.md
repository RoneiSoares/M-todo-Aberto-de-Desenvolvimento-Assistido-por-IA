# Roadmap

## v0.2 — Reprodutibilidade operacional
- [x] manual para leigos
- [x] protocolo da IA
- [x] protocolo humano
- [x] templates
- [x] exemplo completo
- [x] guia de adoção do zero
- [x] recuperação e incidentes
- [x] Definition of Done por risco
- [x] handoff e retomada
- [x] rota de leitura separada para leigo e IA
- [ ] revisão externa por pessoas que não participaram da criação

## v0.3 — Validação cruzada
- [ ] aplicar em projetos de naturezas diferentes
- [ ] registrar falhas e contraexemplos de múltiplos ciclos
  - [x] primeiro ciclo: LabCalc com quatro agentes
- [ ] separar regras gerais de regras contextuais
- [x] testar onboarding com uma IA sem histórico prévio
- [ ] testar adoção por uma pessoa leiga sem orientação adicional
- [x] definir critérios objetivos de aderência ao método
- [ ] repetir o teste após incorporar as correções descobertas

### Achados do primeiro ciclo

- classificação de risco precisava de regra de precedência;
- `IMPLEMENTADO` precisava carregar proveniência quando a alteração ocorre fora do projeto autoritativo;
- identificação e capacidades do agente ajudam a auditar limitações reais da ferramenta;
- operações críticas precisam permanecer claramente separadas de commit/push/PR comuns quando estes estiverem autorizados;
- quatro agentes independentes reconstruíram de forma convergente o estado, a GOLDEN, a branch-base, o diagnóstico técnico e as validações essenciais do LabCalc.

Evidência: `validation/2026-09-14-teste-cego-labcalc-4-ias.md`.

Rubrica prospectiva: `validation/RUBRICA-ADERENCIA-v0.3.md`.

## v0.4 — Automação
- [ ] CI mínimo
- [ ] validação automática de links/documentação
- [ ] checks de PR
- [ ] relatório de evidências automático
- [ ] detectar divergências entre PROJECT_STATE e TEST_MATRIX quando possível

## v0.5 — Comparação formal
- [ ] SDD
- [ ] TDD/BDD
- [ ] GitFlow/Trunk-Based
- [ ] práticas agentic/AI-assisted
- [ ] identificar conceitos já consolidados com outros nomes

## Pergunta permanente

> Esta regra continua fazendo sentido fora do projeto onde nasceu?
