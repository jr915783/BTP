# Desafio


- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.

- Para enviar a resposta, abra uma Pull Request para este repositório.



# Questionário



1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.



**Resposta:**



1. **Código Base**: Um único repositório de código versionado, com branches para diferentes versões.

2. **Dependências**: Declaração e isolamento explícito de todas as dependências da aplicação.

3. **Configuração**: Armazenamento de configurações em variáveis de ambiente, separando-as do código.

4. **Backing Services**: Tratamento de serviços auxiliares como recursos externos acessíveis via URL.

5. **Build, Release, Run**: Separação clara entre as etapas de build, release e run da aplicação.

6. **Processos**: Execução da aplicação em processos sem estado, que podem ser facilmente iniciados ou parados.


.



2. Quais são as principais camadas no desenvolvimento de um software?



**Resposta:**



As Principais camadas no desenvolvimento de um software esta no back-end na parte da controller com as validações necessárias e camada DAO onde é feito a comunicação com o banco de dados 





3. Diferencie Arquitetura SOA X Arquitetura microserviços.



**Resposta:**

A principal diferença é que uma arquitetura SOA engloba varias parte de um sistema fazendo tudo no mesmo lugar, enquanto o microserviços é desacoplado tendo responsabilidades únicas e separadas do resto do sistema





4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.



**Resposta:**



O objetivo de um API Management na arquitetura de serviços distribuídos é descentralizaçãouma responsabilidade única de um sistema





5. Qual a diferença entre uma Struct e uma Class?





**Resposta:**



A diferença entre uma struct e uma class é que struct  é um tipo de dado enquanto uma class é com conjunto de códigos obtendo métodos e objetos







6. Explique a grande diferença entre .NET e .NET CORE.



**Resposta:**



A diferença entre .NET e .NET CORE é que .net é uma versão mais antiga voltada para Windows enquanto NET CORE é uma versão mais atualizada tendo suporte para mais sistemas operações e multiplataformas



7. Quais as principais diferenças entre REST e GRPC?



**Resposta:**

As principais diferenças entre REST e gRPC estão relacionadas à forma como o cliente e o servidor se comunicam, ao desempenho e à representação de dados

resumindo 

REST: Funciona de forma unidirecional, com chamadas de cliente para servidor.

gRPC: Suporta comunicação bidirecional e streaming, permitindo chamadas assíncronas.





8. Explique como funciona um gerenciamento de rotas de uma SPA.



**Resposta:**

SPA ultiliza as suas rotas sem precisar atualizar a tela chamando componentes dentro de componentes como uma única tela



9. Falando sobre DevOps, comente o que conhece sobre.



**Resposta:**

Tive experiência com Azure DevOps e Jenkis com automação de pipilines para publicação do projeto





10. Explique sobre um método agile.



**Resposta:**



método agile é um framework que tem como modelo formas de trabalho 





11. Comente sobre CI e CD e algumas ferramentas do dia a dia.



**Resposta:**

Sobre CI e CD já ultilizei o gitFlow, Jenkis e SonarCube para qualidade de código





12. Qual a diferença entre Docker e Containers.



**Resposta:**



Docker é a ferramenta que facilita o uso de containers, enquanto containers são a tecnologia que permite a virtualização leve e a portabilidade de aplicações





13. Qual a diferença entre Kubernetes e Openshift?



**Resposta:**



Kubernetes e Openshift tem a mesma finalidade que é o orquestração de contêineres, porém o Openshift é uma ferramente mais robusta com mais recursos e mais cara enquanto o Kubernetes é uma ferramenta open source





14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?



**Resposta:**



Vantagens de usar uma api é que não importa qual tecnologia você esteja utilizando sempre é posivel consumir uma api sem atraves de um front end ou de um back end

Desvantagens que uma alteração feita na api pode impactar em outros sistema que ultiliza essa Api e na parte de seguração porque qualquer pessoa com permissão pode acessar essa Api





15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?





**Resposta:**

Adicionando permissão de acessa a essa Api como, por exemplo o JWT usando o token validos no consumo da api



16. Para que serve uma arquitetura de mensagerias?



**Resposta:**



Serve para facilitar a comunicação entre serviços, componetes etc... 





17. Explique a estratégia SAGA em arquitetura de microservice.



**Resposta:**



SAGA é uma abordagem eficaz para gerenciar transações em sistemas de microserviços, garantindo integridade e consistência sem a necessidade de um gerenciamento transacional global.





18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.





**Resposta:**



Não tive oportunidade de ultilizar o GitOps
