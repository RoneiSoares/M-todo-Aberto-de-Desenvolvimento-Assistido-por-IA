# 13 — Antipadrões

## “Compilou, então funciona”
Erro clássico. Build não prova comportamento funcional.

## “A IA disse que testou”
Pergunte qual teste, onde, com qual artefato e resultado.

## Trabalhar direto na main
Remove isolamento e aumenta risco.

## Refatoração oportunista
Tarefa pequena vira alteração ampla sem necessidade.

## Varredura total automática
Gasta contexto e aumenta chance de interferência.

## Misturar duas correções
Dificulta revisão, rollback e diagnóstico.

## Memória apenas no chat
Outra IA não consegue retomar corretamente.

## GOLDEN = última versão
Versão recente pode ser menos confiável que a anterior.

## Estado otimista
Registrar `OK` porque “deve funcionar”.

## Merge implícito
Interpretar “ótimo” como autorização de merge.

## Force push cosmético
Reescrever histórico só para deixá-lo bonito.

## Fallback prematuro
Mandar o humano executar comandos que o agente poderia executar.

## Relatório sem pendências
Dizer apenas o que passou e esconder o que não foi testado.
