# 05 — Git para leigos

## Repositório
Pasta versionada pelo Git.

## Commit
Fotografia lógica de um conjunto de mudanças.

## Branch
Linha paralela de trabalho.

Pense assim:

```text
main: A---B---C
             \
fix-x:        D---E
```

`D` e `E` não alteram `main` enquanto não houver integração.

## Pull Request (PR)
Pedido para revisar e integrar uma branch em outra.

## Remote
Repositório remoto, normalmente no GitHub. Geralmente chamado `origin`.

## Push
Envia commits locais para o remoto.

## Pull/Fetch
Traz informações do remoto.

## Merge
Integra histórias.

## Rebase
Reposiciona commits sobre outra base. Pode reescrever histórico e, neste método, exige autorização explícita.

## Force push
Substitui histórico remoto. Operação de alto risco.

## Tag
Marcador imutável associado a um commit, usado para identificar versões.

## Release
Publicação associada a uma tag, normalmente com artefatos e notas.

## Worktree
Permite ter várias branches abertas em pastas diferentes ao mesmo tempo.

Útil quando:
- uma tarefa longa está em andamento;
- surge correção urgente;
- duas IAs/agentes trabalham em paralelo.

## Sequência segura mínima

```text
git status
git branch --show-current
git remote -v

# criar branch
git switch -c fix/minha-tarefa

# depois de alterar
git diff
git diff --check

# validar
<build/testes>

# versionar
git add ...
git commit -m "fix: corrigir ..."

# publicar
git push -u origin fix/minha-tarefa
```

Não execute merge/rebase/force-push/tag/release automaticamente se a política exigir autorização.
