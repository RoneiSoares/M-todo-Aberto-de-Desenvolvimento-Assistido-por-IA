# Índice do método — v0.3 em validação

## Documentos principais

- `README.md`
- `CHANGELOG.md`
- `CONTRIBUTING.md`
- `ROADMAP.md`

## Manual

- `docs/00-COMECE-AQUI.md`
- `docs/01-FUNDAMENTOS.md`
- `docs/02-PAPEIS-E-RESPONSABILIDADES.md`
- `docs/03-ARQUIVOS-DE-MEMORIA.md`
- `docs/04-FLUXO-OPERACIONAL.md`
- `docs/05-GIT-PARA-LEIGOS.md`
- `docs/06-PROTOCOLO-DA-IA.md`
- `docs/07-PROTOCOLO-DO-HUMANO.md`
- `docs/08-EVIDENCIAS-E-TESTES.md`
- `docs/09-GOLDEN-E-VERSIONAMENTO.md`
- `docs/10-SEGURANCA-E-AUTORIZACOES.md`
- `docs/11-CHECKLISTS.md`
- `docs/12-GLOSSARIO.md`
- `docs/13-ANTIPADROES.md`
- `docs/14-EXEMPLO-COMPLETO.md`
- `docs/15-ADOTANDO-DO-ZERO.md`
- `docs/16-RECUPERACAO-E-INCIDENTES.md`
- `docs/17-DEFINITION-OF-DONE.md`
- `docs/18-HANDOFF-E-RETOMADA.md`
- `docs/19-PROTOCOLO-DE-ENTREGA-AO-EXECUTOR.md`

## Validação experimental

- `validation/2026-09-14-teste-cego-labcalc-4-ias.md` — primeiro ciclo cruzado com quatro agentes;
- `validation/RUBRICA-ADERENCIA-v0.3.md` — critérios prospectivos de aderência para os próximos testes.

## Exemplos

- `examples/EXEMPLO-AGENTS.md`

## Templates

- `templates/AGENTS.md`
- `templates/PROJECT_STATE.md`
- `templates/TEST_MATRIX.md`
- `templates/VERSIONING.md`
- `templates/TASK_PROMPT.md`
- `templates/EXECUTOR_PROMPT.md`
- `templates/FINAL_REPORT.md`
- `templates/HANDOFF.md`
- `templates/RISK_ASSESSMENT.md`
- `templates/DECISION_RECORD.md`

## Rotas rápidas

**Pessoa leiga:** `00 → 01 → 02 → 05 → 04 → 14 → 15`

**IA executora:** `06 → AGENTS do projeto → PROJECT_STATE → TEST_MATRIX → VERSIONING → tarefa atual`

**IA orquestradora preparando tarefa para Codex/Executor:** `06 → 19 → EXECUTOR_PROMPT → contexto persistido do projeto`

**Incidente:** `16`

**Conclusão/DONE:** `17`

**Troca de pessoa ou IA:** `18`

**Auditoria de aderência:** `validation/RUBRICA-ADERENCIA-v0.3.md`
