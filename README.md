# Agile Dead Trees — Architectural Kata

**Equipe XGH** | Arquitetura de Software | 6º Período - Engenharia de Software | Turma Quinta-feira | Sprint 4

Projeto de editora digital e e-commerce: fluxo de publicação híbrida (e-books e impressão física), integração com gráficas legadas via XML/EDI e agente de IA para recomendação e diagramação personalizada.

## Resumo da Solução Proposta

A plataforma adota arquitetura orientada a eventos com Apache Kafka (ADRs 001 e 002) para desacoplar CMS, e-commerce, importação de planilhas e gráficas legadas, absorvendo picos com nivelamento de carga. O domínio é organizado em Bounded Contexts com DDD, e a comunicação com os legados é protegida por uma ACL baseada em Adapter, Facade, Translator, Factory Method e Strategy (ADRs 003, 004, 005 e 008). Os princípios DIP e OCP são aplicados nos contratos e nos trechos de código em `snippets/`.

A inteligência artificial é híbrida: SLMs locais, LLMs e RAG ficam atrás de um AI Gateway com guardrails, mascaramento de PII e cache semântico, sem atuação autônoma no caminho crítico transacional ou industrial (ADR 010). A resiliência do elo mais fraco — as gráficas legadas — usa timeout de 2s, retry com backoff e jitter, circuit breaker e fallback em DLQ (ADR 007). A stack de integração é C#/.NET LTS (ADR 009) e as regras de dependência são verificadas por fitness functions com NetArchTest (equivalente ao ArchUnit em C#).

## Equipe

| Integrante | Função | GitHub |
|---|---|---|
| Lorena Gobara Falci | Líder | @loregbrw |
| Nilton Prudêncio Oliveira de Meira | Pesquisador | @NiltonMeira |
| Adrian Gobara Falci | Executor | @adriangobarafalci |

## Onde encontrar cada entrega

| Item do enunciado | Arquivo |
|---|---|
| Identificação da equipe | README, seção Equipe |
| 1.1 Contexto do projeto | README, seção Resumo da Solução Proposta · [Apresentação do projeto](docs/entregas/apresentacoes/apresentação-projeto.pdf) |
| 1.2 Resumo da solução proposta | README, seção Resumo da Solução Proposta |
| 2. Atributos de qualidade e matriz QAW | [Relatório 1](docs/entregas/relatorios/relatório-1.pdf) · [ADR-010](docs/adr/ADR-010.md) (métricas da IA) |
| 3. Modelo C4 (níveis 1, 2 e 3) | [Contexto](docs/arquitetura/c4-contexto.md) · [Contêineres](docs/arquitetura/c4-container.md) · [Componentes](docs/arquitetura/c4-componente.md) — diagramas Mermaid visíveis no GitHub |
| 4. DDD: subdomínios, linguagem ubíqua, mapa e ACL | [Subdomínios](docs/ddd/subdominios.md) · [Linguagem Ubíqua](docs/ddd/linguagem-ubiqua.md) · [Mapa de Contextos](docs/ddd/mapa-contextos.md) · [ADR-008](docs/adr/ADR-008.md) |
| 5. SOLID e GoF (DIP, OCP, Factory, Adapter, Strategy) | [ADR-003](docs/adr/ADR-003.md) · [ADR-004](docs/adr/ADR-004.md) · [ADR-005](docs/adr/ADR-005.md) · [código em `snippets/`](snippets/) |
| 6. Resiliência, integração e IA-Native | [ADR-006](docs/adr/ADR-006.md) · [ADR-007](docs/adr/ADR-007.md) · [ADR-010](docs/adr/ADR-010.md) · [Polly/DLQ](snippets/IntegrationService/Resilience/) · [Guardrails](snippets/IntegrationService/AiGateway/Guardrails.cs) |
| 7. ADRs (001 a 010) | [docs/adr/](docs/adr/) |
| 8. Fitness functions | [tests/ArchitectureFitnessTests.cs](tests/ArchitectureFitnessTests.cs) — NetArchTest (equivalente ao ArchUnit em C#) |
| 9. Rubrica de avaliação | Enunciado da disciplina; evidências nos itens acima |

## Entregas das Sprints 1 a 4

```text
.
├── README.md
├── docs/
│   ├── adr/            # ADR-001 a ADR-010
│   ├── arquitetura/    # C4 em Mermaid (.md)
│   ├── ddd/            # subdomínios, linguagem ubíqua e mapa de contextos
│   └── entregas/       # PDFs das entregas anteriores
│       ├── APS/
│       ├── apresentacoes/
│       ├── relatorios/
│       └── sprints/
├── snippets/           # trechos C# ilustrativos dos padrões
└── tests/              # fitness functions
```

| Entrega | Arquivo |
|---|---|
| Sprint 1 | [sprint-1.pdf](docs/entregas/sprints/sprint-1.pdf) |
| Sprint 2 | [sprint-2.pdf](docs/entregas/sprints/sprint-2.pdf) |
| Sprint 3 | [sprint-3.pdf](docs/entregas/sprints/sprint-3.pdf) |
| Sprint 4 | [sprint-4.pdf](docs/entregas/sprints/sprint-4.pdf) |
| Relatório 1 | [relatório-1.pdf](docs/entregas/relatorios/relatório-1.pdf) |
| Relatório 2 | [relatório-2.pdf](docs/entregas/relatorios/relatório-2.pdf) |
| Relatório 3 | [relatório-3.pdf](docs/entregas/relatorios/relatório-3.pdf) |
| Relatório 4 | [relatório-4.pdf](docs/entregas/relatorios/relatório-4.pdf) |
| Apresentação do projeto | [apresentação-projeto.pdf](docs/entregas/apresentacoes/apresentação-projeto.pdf) |
| Seminário — Padrões de Criação | [seminário-padrões-de-criação.pdf](docs/entregas/apresentacoes/seminário-padrões-de-criação.pdf) |
| APS2 | [APS2.pdf](docs/entregas/APS/APS2.pdf) |

## Fluxo de trabalho

Sem commits diretos na `main`: cada integrante trabalha em sua branch, abre um PR para `main` e revisa o PR de um colega (mínimo de 1 aprovação).
