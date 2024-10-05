# Projeto de Biblioteca de Classes com T4

## Visão Geral

Este projeto é uma biblioteca de classes desenvolvida em C# que implementa uma simulação da geração de código usando o T4 (Text Template Transformation Toolkit). O objetivo principal deste projeto é explorar o T4 como uma ferramenta para automatizar a criação de classes, interfaces e repositórios, melhorando assim a eficiência e a manutenção do código. 

## Objetivo do Projeto

O principal objetivo deste projeto foi **aprender a usar o T4** de maneira prática e eficiente. O T4 é uma poderosa ferramenta que permite a geração de código dinâmico a partir de templates, o que pode ser extremamente útil em projetos de software onde as classes e as interfaces precisam ser criadas repetidamente. No entanto, é fundamental ressaltar que este projeto foi desenvolvido **de maneira simplificada e serve apenas como um teste da ferramenta T4**.

## Estrutura do Projeto

A estrutura do projeto foi organizada para refletir as melhores práticas de separação de responsabilidades:

- **Models**: Esta pasta contém as classes de modelo de dados, que representam as entidades principais do sistema. Neste projeto, o modelo é simplificado e não utiliza chaves de bloco, mas apenas ponto e vírgula (`;`), servindo como um exemplo básico.
  
- **Repositories**: Aqui estão as interfaces e implementações dos repositórios. Cada repositório é responsável por gerenciar a persistência e a recuperação dos dados do modelo, encapsulando toda a lógica de acesso a dados.

- **Services**: As classes de serviço estão localizadas nesta pasta. Elas contêm a lógica de negócio do sistema e fazem a intermediação entre os repositórios e outras partes do aplicativo. Isso permite uma separação clara entre a lógica de negócio e o acesso a dados.

## Implementação do T4

O arquivo T4 (`GenerateModel.tt`) foi projetado para gerar automaticamente três componentes principais:

1. **Interface de Repositório**: Define os métodos que devem ser implementados para a manipulação de dados, como `GetAll`, `GetById`, `Add`, `Update`, e `Delete`.

2. **Implementação do Repositório**: Classes que implementam as interfaces de repositório. Estas classes contêm a lógica necessária para gerenciar a coleção de objetos do modelo em memória, como um exemplo simples de armazenamento.

3. **Classe de Serviço**: Classes que implementam a lógica de negócios, utilizando os repositórios para realizar operações em relação aos modelos. Elas fornecem uma camada de abstração entre a interface do usuário e os dados, garantindo que as regras de negócios sejam aplicadas corretamente.

## Como Observar o Funcionamento

1. **Exclua os arquivos** `ProductRepository` e `ProductService`.
2. **Abra o arquivo `GenerateModel.tt`** no seu ambiente de desenvolvimento.
3. **Salve o arquivo**: Pressione CTRL + S e verá que os arquivos foram criados novamente, como o código do arquivo T4 solicitou.