# Subdomínios — Agile Dead Trees

Fonte: consolidado da Sprint 3 (arquivo `docs/sprints/sprint-3.pdf`).

O projeto integra o sistema de autoria da editora, o comércio eletrônico, as planilhas e os sistemas legados das gráficas, reduzindo o tempo entre a criação e a publicação dos livros.

## Core Domain

**Publicação Ágil de Livros** — representa o principal objetivo de negócio: reduzir o tempo entre a autoria e a disponibilização dos livros para venda.

## Classificação das funcionalidades

| Funcionalidade | Classificação | Justificativa |
|---|---|---|
| Publicação de livros | Core Domain | Principal funcionalidade do projeto; reduz o tempo entre a autoria e a disponibilização para venda. |
| Integração entre CMS e e-commerce | Supporting Subdomain | Permite compartilhar informações dos livros entre os sistemas. |
| Importação e validação de planilhas | Supporting Subdomain | Permite receber, validar e integrar dados de arquivos eletrônicos. |
| Integração com as gráficas | Supporting Subdomain | Permite encaminhar ordens de impressão para sistemas legados. |
| Mensageria com Apache Kafka | Generic Subdomain | Solução pronta para comunicação e distribuição de eventos. |
| Leitura de arquivos CSV, XLSX e ODS | Generic Subdomain | Bibliotecas existentes interpretam os diferentes formatos de arquivo. |
| Autenticação e controle de acesso | Generic Subdomain | Soluções prontas para controlar o acesso aos sistemas. |

A classificação considera que a publicação dos livros representa o principal valor do projeto. As integrações são necessárias para viabilizar esse processo, enquanto as funcionalidades genéricas podem utilizar tecnologias já existentes.
