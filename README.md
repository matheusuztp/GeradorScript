<h1>GeradorScript</h1>

<p>Este projeto é uma aplicação em C# desenvolvida com Windows Forms, que permite gerar scripts SQL a partir de dados em planilhas Excel.</p>

<h2>Funcionalidades</h2>
<ul>
  <li><strong>Leitura de arquivos Excel:</strong> A aplicação permite importar dados de arquivos Excel.</li>
  <li><strong>Geração de scripts SQL:</strong> A partir dos dados importados, é possível gerar scripts SQL para operações de INSERT, UPDATE ou DELETE.</li>
  <li><strong>Configuração personalizada:</strong> O usuário pode definir parâmetros como separadores de colunas e a faixa de linhas a serem processadas.</li>
</ul>

<h2>Estrutura do Projeto</h2>
<ul>
  <li><strong>Gerador.cs:</strong> Contém a lógica principal para a geração dos scripts.</li>
  <li><strong>Program.cs:</strong> Ponto de entrada da aplicação.</li>
  <li><strong>Properties:</strong> Armazena as configurações do projeto.</li>
  <li><strong>bin/</strong> e <strong>obj/:</strong> Diretórios gerados automaticamente pelo compilador.</li>
  <li><strong>GeradorScriptExcel.sln:</strong> Arquivo de solução do Visual Studio para o projeto.</li>
</ul>

<h2>Como Executar</h2>
<ol>
  <li>Clone ou faça o download do projeto.</li>
  <li>Abra a solução <code>GeradorScriptExcel.sln</code> no Visual Studio.</li>
  <li>Compile o projeto e execute-o.</li>
</ol>

<h2>Requisitos</h2>
<ul>
  <li>.NET 8.0 ou superior.</li>
  <li>Visual Studio 2022 ou equivalente.</li>
  <li>Biblioteca Dapper para manipulação de dados (já configurada no projeto).</li>
  <li>Biblioteca EPPlus para leitura de arquivos Excel.</li>
</ul>

<h2>Contribuições</h2>
<p>Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.</p>

<h2>Licença</h2>
<p>Este projeto está licenciado sob a <a href="LICENSE">MIT License</a>.</p>
