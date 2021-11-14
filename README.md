Boa noite, meu nome é **Gabriel Leme** e esse projeto foi criado com base em um teste para a empresa Avivatec, considerando isso peço que veja o vídeo abaixo que contem explicações sobre o código.
O vídeo leva em consideração que preciso usar dados estáticos por não ter controle sobre a aplicação e a mesma talvez tenha uma rotina que reseta o banco de dados, por tal motivo gravei uma breve explicação com a automação rodando ao fundo.

**Priscila e/ou Isabela:** Independente do resultado do teste da vaga, toda e qualquer dica ou sugestão, será bem aceita; por favor opine.

https://www.youtube.com/embed/uKUZN24jAqQ

<h3>Test case:</h3>

![image](https://user-images.githubusercontent.com/94268501/141665433-03c87338-0573-4a56-ba77-c0f8f661c810.png)

**1. Explique na sua percepção qual a importância de testar de forma funcional e não funcional?**

Considero importante ambos os tipos de teste, porque através do teste funcional é possivel validar que os requisitos foram atendidos, nisso temos: o fluxo das telas, regras de negócio e outros pontos que podem ser validados; porém voltado para o aceite da aplicação em termos de funcionalidade.
Já o teste não funcional visa validar aspectos de performance, carga, confiabilidade e outras coisas que nem sempre entram como requisitos do sistema.

Considerando essa introdução, na minha opinião o software como um todo não é só o que foi definido no levantamento de requisitos, por meio de ambos os testes podemos manter o projeto vivo enquanto encontramos falhas que podem estar presentes e até mesmo encondidas; onde a pessoa que não codificou tem um olhar cético e já espera encontrar algo em toda tela na qual faz a navegação.

**2. Qual a diferença do Teste Funcional para o Não Funcional? Exemplifique.**

Com a introdução feita na pergunta anterior eu já respondi essa pergunta, porém resumindo, o teste funcional valida aspectos que estraram como requisitos da aplicação, geralmente esses itens são: regras de negócio, fluxo das telas, disposição da informação, etc.

Já o teste não funcional tem como foco aspectos que vão além, bons exemplos são: carga, performance, usabilidade.

**3. Quais são os tipos de teste possíveis dentro do Teste de Performance?**

Existe uma confusão em muito material de faculdade sobre isso, pois o termo performance faz jus a como o software performa durante a execução de determinada tarefa, para isso temos outros tipos dentro dessa categoria: capacidade, carga, stress; todos importantes na hora de tomadas de decisão.

**4. Informar qual a diferença entre Teste de Carga e Teste de Stress? Exemplifique.**

O teste de carga tem por meio de uma estimativa, simular o uso da aplicação em condições normais, ele tem base em numeros que geralmente são fornecidos como base e são usados para simular a quantidade de requisições no sistema, ele não visa quebrar a aplicação, mas ele levanta informações importantes para avaliar se o software está apto a exercer a sua função com a capacidade designada.

Já o teste de estresse é feito para levar o software ao limite, testando a usabilidade em condições extremas e fazendo ele falhar propositalmente.

**5. O que significa Teste de Caixa Preta e Teste de Caixa Branca? Exemplifique.**

Os testes de caixa branca também podem ser entendidos como testes "abertos", onde o testador tem acesso ao código da aplicação e pode fazer testes unitários e testes estáticos.

Os testes de caixa preta, testes "fechados", dão mais atenção ao que foi definido como requisito da aplicação e sem acesso ao código, isso possibilita trabalhar a entrada e saída do sistema por meio de testes de: e2e, integração, sistema, aceitação, alfa, beta.
Inclusive a automação criada para esse questionário é um teste E2E(caixa preta).

**6. Criar um Plano de Teste para uma rotina de Cadastro de um Usuário e Login do mesmo, em plataforma web de sua escolha.**

![image](https://user-images.githubusercontent.com/94268501/141665433-03c87338-0573-4a56-ba77-c0f8f661c810.png)
