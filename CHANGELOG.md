# Changelog

## [Unreleased] — v0.3 em validação

### Validação cruzada
- executado primeiro teste cego do LabCalc com quatro agentes de IA independentes;
- registrado relatório do experimento em `validation/2026-09-14-teste-cego-labcalc-4-ias.md`;
- adicionada rubrica objetiva de aderência de 100 pontos para os próximos ciclos.

### Ajustado a partir de evidência do teste
- classificação de risco agora usa o maior nível aplicável quando múltiplos critérios coexistem, salvo justificativa explícita;
- `IMPLEMENTADO` passa a exigir proveniência clara quando a alteração ocorre em sandbox, snapshot, fork, cópia ou reconstrução;
- adicionados estados `CORREÇÃO PROPOSTA` e `IMPLEMENTADO EM CÓPIA NÃO AUTORITATIVA`;
- protocolo da IA passa a registrar proveniência do workspace e capacidades reais da sessão quando afetarem a evidência;
- esclarecida a distinção entre operações críticas e commit/push/abertura de PR quando permitidos pela política do projeto.

## [0.2.1] - 2026-09-14

### Adicionado
- protocolo da IA ampliado para entrada, retomada, estado inesperado e handoff;
- guia de adoção do método do zero;
- guia de recuperação e incidentes;
- Definition of Done proporcional ao risco;
- protocolo de handoff e retomada entre pessoas ou IAs;
- rota de leitura específica para iniciantes e para agentes no README.

### Corrigido
- referência interna do guia de incidentes para o capítulo de handoff;
- distinção mais explícita entre implementação, evidência e validação funcional.

## [0.2.0] - 2026-09-14

### Adicionado
- manual para leigos;
- protocolo operacional da IA;
- protocolo do humano;
- guia Git;
- modelo de evidências;
- GOLDEN/versionamento;
- segurança/autorização;
- checklists;
- glossário;
- antipadrões;
- exemplo completo;
- templates de AGENTS, PROJECT_STATE, TEST_MATRIX, VERSIONING, tarefa e relatório.

## [0.1.0] - 2026-09-14
- base conceitual inicial do método.
