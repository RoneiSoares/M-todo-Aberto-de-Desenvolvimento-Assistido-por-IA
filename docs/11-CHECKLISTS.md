# 11 — Checklists

## Antes de alterar

- [ ] Estou no repositório correto?
- [ ] Sei qual é a branch?
- [ ] `git status` está entendido?
- [ ] Remotes estão corretos?
- [ ] Li `AGENTS.md`?
- [ ] Li `PROJECT_STATE.md`?
- [ ] Sei qual é a GOLDEN?
- [ ] A tarefa tem objetivo claro?
- [ ] Existe branch própria?
- [ ] Há mudanças locais de outra tarefa?

## Antes de commitar

- [ ] Escopo está pequeno?
- [ ] Só alterei arquivos necessários?
- [ ] Build executado?
- [ ] Testes relevantes executados?
- [ ] `git diff` revisado?
- [ ] `git diff --check` limpo?
- [ ] Documentação de estado precisa ser atualizada?

## Antes do PR

- [ ] Branch publicada?
- [ ] Título explica objetivo?
- [ ] Corpo do PR informa problema e solução?
- [ ] Evidências listadas?
- [ ] Pendências listadas?
- [ ] Teste funcional está claramente OK ou PENDENTE?
- [ ] Se o CI foi alterado, os gatilhos redundantes foram revisados?
- [ ] Se existe artifact de CI, há consumidor, retenção e tamanho/custo justificados?

## Antes do merge

- [ ] Revisão concluída?
- [ ] Evidências compatíveis com alegações?
- [ ] Teste funcional obrigatório concluído?
- [ ] Aprovação humana explícita recebida?
- [ ] `PROJECT_STATE.md` consistente?
- [ ] `TEST_MATRIX.md` consistente?

## Antes de tag/release/GOLDEN

- [ ] Versão candidata congelada?
- [ ] Build Release OK?
- [ ] Todos testes aplicáveis registrados?
- [ ] Teste funcional OK?
- [ ] Aceitação recebida?
- [ ] Artefato correto identificado?
- [ ] Binário permanente está destinado a Release Asset, e não a artifact indefinido de CI?
- [ ] Hash registrado se aplicável?
- [ ] Autorização explícita recebida?
