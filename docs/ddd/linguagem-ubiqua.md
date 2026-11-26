# Linguagem Ubíqua — Publicação Ágil de Livros

Fonte: consolidado da Sprint 3 (arquivo `docs/sprints/sprint-3.pdf`).

A Linguagem Ubíqua é o conjunto de termos usados pela equipe para representar os conceitos do negócio. Esses termos devem aparecer de forma consistente na documentação e no código-fonte.

| Termo | Significado |
|---|---|
| Livro | Obra que será publicada pela editora. |
| MetadadosEditoriais | Informações utilizadas para identificar e descrever o livro. |
| Publicação | Processo de disponibilização do livro para os sistemas consumidores. |
| ValidacaoEditorial | Verificação das informações necessárias para publicar o livro. |
| LivroPreparado | Livro que possui as informações necessárias para seguir para publicação. |
| LivroPublicado | Livro cuja publicação foi concluída. |
| OrdemDePublicacao | Solicitação para realizar a publicação de um livro. |
| EventoLivroPublicado | Evento que informa aos sistemas interessados que um livro foi publicado. |

Esses termos devem ser usados nos nomes de classes, métodos e eventos relacionados ao domínio editorial, mantendo linguagem comum entre equipe e código — por exemplo, `Livro`, `MetadadosEditoriais` e `ValidarParaPublicacao()`.
