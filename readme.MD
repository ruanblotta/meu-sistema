#Cadastro de Notas de Alunos
Este é um simples programa de cadastro de notas de alunos desenvolvido em C# utilizando o padrão de arquitetura MVC (Model-View-Controller) para separação de responsabilidades.

#Como Clonar o Repositório
Para clonar este repositório, abra o terminal e execute o seguinte comando:

git clone https://github.com/seu-usuario/cadastro-notas-alunos.git

Substitua seu-usuario pelo seu nome de usuário do GitHub.

#Como Instalar e Executar o Programa
Este programa é executado em um ambiente .NET Core. Para instalar e executar o programa, siga estas etapas:

Certifique-se de ter o .NET Core SDK instalado. Você pode baixá-lo em dotnet.microsoft.com.

Navegue até o diretório do projeto após clonar o repositório.
Abra o terminal e execute o seguinte comando para compilar e executar o programa:

dotnet run

Isso irá compilar e executar o programa.

#Como Funciona
Este programa permite cadastrar alunos e suas notas, e exibir um boletim com as médias das notas dos alunos cadastrados. A interação com o programa ocorre no console.

#Arquitetura
O programa segue o padrão de arquitetura MVC:

Model (Modelo): Representado pela classe Aluno.cs dentro da pasta Models. Esta classe contém os dados do aluno e possui métodos para calcular a média das notas.

View (Visão): Não há arquivos de visualização separados, pois a interação com o usuário ocorre diretamente no console. A classe View.cs dentro da pasta Views contém métodos para exibir mensagens e interagir com o usuário no console.

Controller (Controlador): Representado pela classe AlunoController.cs dentro da pasta Controllers. Esta classe contém métodos para lidar com a lógica de negócios relacionada aos alunos, como cadastrar alunos e exibir o boletim.