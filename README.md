# Projeto de Biblioteca de Classes com T4

## Vis�o Geral

Este projeto � uma biblioteca de classes desenvolvida em C# que implementa uma simula��o da gera��o de c�digo usando o T4 (Text Template Transformation Toolkit). O objetivo principal deste projeto � explorar o T4 como uma ferramenta para automatizar a cria��o de classes, interfaces e reposit�rios, melhorando assim a efici�ncia e a manuten��o do c�digo. 

## Objetivo do Projeto

O principal objetivo deste projeto foi **aprender a usar o T4** de maneira pr�tica e eficiente. O T4 � uma poderosa ferramenta que permite a gera��o de c�digo din�mico a partir de templates, o que pode ser extremamente �til em projetos de software onde as classes e as interfaces precisam ser criadas repetidamente. No entanto, � fundamental ressaltar que este projeto foi desenvolvido **de maneira simplificada e serve apenas como um teste da ferramenta T4**.

## Estrutura do Projeto

A estrutura do projeto foi organizada para refletir as melhores pr�ticas de separa��o de responsabilidades:

- **Models**: Esta pasta cont�m as classes de modelo de dados, que representam as entidades principais do sistema. Neste projeto, o modelo � simplificado e n�o utiliza chaves de bloco, mas apenas ponto e v�rgula (`;`), servindo como um exemplo b�sico.
  
- **Repositories**: Aqui est�o as interfaces e implementa��es dos reposit�rios. Cada reposit�rio � respons�vel por gerenciar a persist�ncia e a recupera��o dos dados do modelo, encapsulando toda a l�gica de acesso a dados.

- **Services**: As classes de servi�o est�o localizadas nesta pasta. Elas cont�m a l�gica de neg�cio do sistema e fazem a intermedia��o entre os reposit�rios e outras partes do aplicativo. Isso permite uma separa��o clara entre a l�gica de neg�cio e o acesso a dados.

## Implementa��o do T4

O arquivo T4 (`GenerateModel.tt`) foi projetado para gerar automaticamente tr�s componentes principais:

1. **Interface de Reposit�rio**: Define os m�todos que devem ser implementados para a manipula��o de dados, como `GetAll`, `GetById`, `Add`, `Update`, e `Delete`.

2. **Implementa��o do Reposit�rio**: Classes que implementam as interfaces de reposit�rio. Estas classes cont�m a l�gica necess�ria para gerenciar a cole��o de objetos do modelo em mem�ria, como um exemplo simples de armazenamento.

3. **Classe de Servi�o**: Classes que implementam a l�gica de neg�cios, utilizando os reposit�rios para realizar opera��es em rela��o aos modelos. Elas fornecem uma camada de abstra��o entre a interface do usu�rio e os dados, garantindo que as regras de neg�cios sejam aplicadas corretamente.

## Como Observar o Funcionamento

1. **Exclua os arquivos** `ProductRepository` e `ProductService`.
2. **Abra o arquivo `GenerateModel.tt`** no seu ambiente de desenvolvimento.
3. **Salve o arquivo**: Pressione CTRL + S e ver� que os arquivos foram criados novamente, como o c�digo do arquivo T4 solicitou.