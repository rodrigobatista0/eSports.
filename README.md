# Gestão de Campeonatos de eSports
 
Aplicação Windows Forms em C# para gerir campeonatos, torneios, equipas, jogadores, partidas, resultados e classificações. **Não usa base de dados**: todos os dados são lidos e guardados em ficheiros **XML** e **JSON**.
 
Projeto de grupo de XML e JSON, INETE, 12.º ano, Curso Profissional de Gestão e Programação de Sistemas Informáticos.
 
## Índice
 
1. [Funcionalidades](#funcionalidades)
2. [Requisitos](#requisitos)
3. [Como abrir e executar](#como-abrir-e-executar)
4. [Guia de utilização](#guia-de-utilização)
5. [Ficheiros de dados](#ficheiros-de-dados)
6. [Regras de validação](#regras-de-validação)
7. [Estrutura do projeto](#estrutura-do-projeto)
8. [Modelo de dados](#modelo-de-dados)
9. [Formatos XML e JSON](#formatos-xml-e-json)
10. [LINQ usado](#linq-usado)
11. [Testes realizados](#testes-realizados)
12. [Decisões técnicas](#decisões-técnicas)
13. [Divisão de tarefas](#divisão-de-tarefas)
14. [Problemas conhecidos](#problemas-conhecidos)
---
 
## Funcionalidades
 
- **Campeonatos, torneios, equipas e jogadores:** adicionar, editar, remover e consultar.
- **Partidas:** agendar entre duas equipas inscritas no torneio e registar o resultado.
- **Estatísticas:** classificação por equipa, Top 3 de jogadores, média geral de pontuações e pesquisa por nickname, com filtro por torneio.
- **XML e JSON:** importar, exportar e converter entre os dois formatos.
- **Importação de resultados:** o ficheiro `resultados.json` junta as partidas aos torneios já carregados.
- **Persistência automática:** os dados são carregados ao abrir e guardados ao fechar, sem perda de informação.
- **Validação e erros:** ficheiros malformados ou com dados inválidos mostram uma mensagem de erro e a aplicação não fecha.
- **Registo de logs:** cada ação fica em `logs.txt` e pode ser consultada entre duas datas.
## Requisitos
 
| Item | Versão |
|---|---|
| Sistema operativo | Windows 10 ou superior |
| Visual Studio | 2022 (Community serve) com a carga de trabalho **Desenvolvimento para desktop com .NET** |
| .NET Framework | 4.7.2 |
| Pacotes NuGet | Restaurados automaticamente (ver `packages.config`), incluindo `System.Text.Json` |
 
## Como abrir e executar
 
1. Descompactar o projeto (ou clonar o repositório).
2. Abrir o ficheiro `eSports.sln` no Visual Studio.
3. Se o Visual Studio não restaurar os pacotes sozinho: **Ferramentas → Gestor de Pacotes NuGet → Restaurar Pacotes NuGet**.
4. Compilar com **Ctrl + Shift + B**.
5. Executar com **F5**. O formulário de arranque é o `FormMain`.
Os ficheiros `dados.json` e `logs.txt` ficam ao lado do executável (normalmente `bin\Debug`). Na primeira execução não existe `dados.json`, por isso a aplicação abre vazia e mostra "Sem dados. Importe um ficheiro XML ou JSON.".
 
### Primeiros passos rápidos
 
1. Menu **Ficheiro → Importar XML...** e escolher `FilesOthers\campeonatos.xml` (ou o `.json` equivalente).
2. Menu **Ficheiro → Importar JSON...** e escolher `FilesOthers\resultados.json` para juntar as partidas.
3. Abrir **Estatísticas** para ver a classificação e o Top 3.
4. Fechar a aplicação. Ao voltar a abrir, os dados continuam lá.
## Guia de utilização
 
### Janela principal (FormMain)
 
**Campeonatos.** A grelha lista os campeonatos com o número de torneios e de equipas. Ao clicar numa linha, os dados aparecem nas caixas por baixo. Os botões **Adicionar**, **Editar** e **Remover** atuam sobre o campeonato escolhido. Remover um campeonato apaga também os seus torneios, por isso pede confirmação.
 
**Abrir.** Os botões levam aos outros formulários: Equipas e Jogadores, Torneios, Partidas e Estatísticas. Também estão no menu **Gestão**.
 
**Resumo.** Mostra os totais de campeonatos, torneios, equipas, jogadores, partidas e pontuações.
 
**Menu Ficheiro**
 
| Opção | O que faz |
|---|---|
| Importar XML... | Substitui os dados atuais pelos do ficheiro XML (pede confirmação). |
| Importar JSON... | Substitui os dados pelos do JSON. Se o ficheiro for de resultados (lista de partidas), junta as partidas aos torneios já carregados. |
| Exportar XML... / Exportar JSON... | Guarda todos os dados atuais no formato escolhido. |
| Converter XML → JSON... / JSON → XML... | Lê um ficheiro, valida-o e grava-o no outro formato, sem alterar os dados abertos. |
| Sair | Fecha a aplicação (os dados são guardados). |
 
**Menu Ajuda:** **Registos / Logs** abre o histórico de ações e **Acerca de...** mostra a informação do projeto.
 
### Equipas e Jogadores (FormTeam)
 
1. Escolher o **Campeonato** e o **Torneio** nas caixas de cima.
2. Separador **Equipas:** preencher Id, Nome e País e usar **Adicionar**, **Editar**, **Remover** ou **Limpar**. Adicionar uma equipa ao torneio é inscrevê-la nele.
3. Separador **Jogadores:** escolher a equipa e preencher Id, Nome, Nickname e Idade. As pontuações juntam-se com o botão **+** e retiram-se com **−**. A caixa **Pesquisar nickname** filtra a grelha enquanto se escreve.
4. Uma equipa com partidas registadas **não pode ser removida**.
### Torneios (FormTournaments)
 
Escolher o campeonato e criar, editar ou remover torneios (Id, Nome e Jogo). O ecrã mostra quantas equipas estão inscritas: **verde com 4 ou mais, vermelho com menos de 4**. As equipas inscrevem-se no formulário Equipas e Jogadores.
 
### Partidas (FormMatches)
 
1. Escolher o campeonato e o torneio.
2. Em **Agendar partida**, definir o Id, a data e as equipas A e B, e carregar em **Agendar**. Só aparecem as equipas inscritas no torneio e o torneio precisa de pelo menos 4.
3. Para registar o resultado, selecionar a partida na grelha, indicar os valores de cada equipa e carregar em **Guardar resultado**.
4. A coluna **Vencedor** mostra o nome da equipa vencedora ("Empate" se for igual e "-" se ainda não houver resultado).
### Estatísticas (FormStatistics)
 
Escolher "Todos os torneios" ou um torneio específico em **Filtrar por torneio**.
 
- **Classificação:** posição, equipa, jogos, vitórias, derrotas, pontos e média de rondas. Ordena por pontos, depois vitórias, depois média.
- **Top 3 jogadores:** os três melhores pela média de pontuações, com a média geral e o número de jogadores.
- **Pesquisar nickname:** pesquisa parcial, sem distinguir maiúsculas de minúsculas.
### Registo de logs (FormLogs)
 
Escolher as datas **De** e **Até** (os dois dias contam inteiros) e carregar em **Pesquisar**. Os botões **Hoje** e **Últimos 7 dias** são atalhos. Os registos mais recentes aparecem primeiro.
 
## Ficheiros de dados
 
### Ficheiros usados pela aplicação
 
| Ficheiro | Onde | Função |
|---|---|---|
| `dados.json` | Ao lado do `.exe` | Dados da aplicação. Carregado ao abrir e guardado ao fechar. |
| `dados.json.erro` | Ao lado do `.exe` | Cópia de segurança criada se o `dados.json` estiver inválido ao abrir. |
| `logs.txt` | Ao lado do `.exe` | Registo de ações, uma linha por ação: `data hora|Ação|Detalhes`. |
 
### Ficheiros de exemplo e de teste
 
| Ficheiro | Conteúdo | Resultado esperado |
|---|---|---|
| `campeonatos.json` e `FilesOthers\campeonatos.xml` | 2 campeonatos, 6 torneios, 24 equipas, 120 jogadores, 600 pontuações e sem partidas | Importa sem erros. |
| `FilesOthers\resultados.json` | Partidas e resultados ligados aos torneios por ID | Importar depois dos campeonatos. Juntam-se as partidas. |
| `FilesOthers\dados_completos.xml` e `.json` | Dados completos com 60 partidas | Importam sem erros. |
| `FilesOthers\dados_invalidos.xml` e `.json` | Vários erros nos dados | Mensagem de erro e dados atuais mantidos. |
| `FilesOthers\invalido_so_idade.json` | Um jogador com idade 60 | Erro: a idade tem de estar entre 15 e 45. |
| `FilesOthers\mal_formado.xml` e `.json` | Ficheiros truncados ou com a marcação partida | Mensagem de erro, sem fechar a aplicação. |
 
## Regras de validação
 
- Ids únicos no respetivo âmbito: campeonato nos dados, torneio no campeonato, equipa no torneio, jogador na equipa e partida no torneio.
- Id maior que 0. O ano do campeonato entre 2000 e 2100.
- Nome obrigatório em todas as entidades. Nickname obrigatório nos jogadores. Jogo obrigatório nos torneios.
- Idade entre **15 e 45** anos.
- Pontuações entre **0 e 100**. Resultados de partidas entre 0 e 99.
- Torneio com pelo menos **4 equipas** para agendar partidas.
- Uma equipa não joga contra si própria e só jogam equipas inscritas no torneio.
- Uma equipa com partidas registadas não pode ser removida.
- Uma partida tem os dois resultados ou nenhum.
Um erro durante a importação mostra uma `MessageBox` com o sítio exato do problema, por exemplo `Campeonato 1 > Torneio 101 > Equipa 2 > Jogador 5: a idade tem de estar entre 15 e 45.`. Os dados em memória não são alterados.
 
## Estrutura do projeto
 
```
eSports/
├── Models/        Dados, Campeonato, Torneio, Equipa, Jogador, Partida,
│                  StandingRow, PlayerRow, LogEntry
├── Services/      DataService, XmlService, JsonService, StatisticsService,
│                  Validations, LogService, UiHelper
├── FormMain, FormTeam, FormTournaments, FormMatches,
│   FormStatistics, FormLogs        (interface, sem lógica de negócio)
├── FilesOthers/   Ficheiros de exemplo e de teste
├── campeonatos.json
└── Program.cs     Arranca o FormMain
```
 
A interface só chama métodos dos `Services` e mostra o resultado. Toda a lógica de negócio, validação e persistência está em `Services/`.
 
## Modelo de dados
 
```
Dados
 └── Campeonato (Id, Nome, Ano)
      └── Torneio (Id, Nome, Jogo)
           ├── Equipa (Id, Nome, Pais)
           │    └── Jogador (Id, Nome, Nickname, Idade)
           │         └── Pontuacoes: List<int>
           └── Partida (Id, Data, IdEquipaA, IdEquipaB, ResultadoA, ResultadoB)
```
 
As partidas guardam só os **identificadores** das equipas, sem duplicar objetos. `ResultadoA` e `ResultadoB` são `int?`: `null` significa partida ainda por jogar.
 
## Formatos XML e JSON
 
### XML
 
```xml
<Campeonatos>
  <Campeonato>
    <Id>1</Id><Nome>Liga Nacional eSports</Nome><Ano>2026</Ano>
    <Torneios><Torneio>
      <Id>101</Id><Nome>CS2 Masters</Nome><Jogo>Counter-Strike 2</Jogo>
      <Equipas><Equipa>
        <Id>1</Id><Nome>Dragons</Nome><Pais>Portugal</Pais>
        <Jogadores><Jogador>
          <Id>10</Id><Nome>Joao Silva</Nome><Nickname>Fire</Nickname><Idade>18</Idade>
          <Pontuacoes><Ponto>90</Ponto><Ponto>85</Ponto></Pontuacoes>
        </Jogador></Jogadores>
      </Equipa></Equipas>
    </Torneio></Torneios>
  </Campeonato>
</Campeonatos>
```
 
### JSON
 
```json
{
  "campeonatos": [{
    "id": 1, "nome": "Liga Nacional eSports", "ano": 2026,
    "torneios": [{
      "id": 101, "nome": "CS2 Masters", "jogo": "Counter-Strike 2",
      "equipas": [{
        "id": 1, "nome": "Dragons", "pais": "Portugal",
        "jogadores": [{
          "id": 10, "nome": "Joao Silva", "nickname": "Fire",
          "idade": 18, "pontuacoes": [90, 85]
        }]
      }]
    }]
  }]
}
```
 
### Ficheiro de resultados
 
```json
{
  "partidas": [
    { "idTorneio": 101, "id": 1, "data": "2026-03-04T00:00:00",
      "idEquipaA": 1, "idEquipaB": 2, "resultadoA": 11, "resultadoB": 16 }
  ]
}
```
 
## LINQ usado
 
| O quê | LINQ |
|---|---|
| Classificação | `SelectMany`, `GroupBy`, `Where` (partidas com resultado), `Count`, `Sum`, `OrderByDescending`, `ThenByDescending` |
| Pontos e médias | `Sum`, `Average` |
| Top 3 jogadores | `Where`, `OrderByDescending(p => p.Average)` e escolha dos três primeiros |
| Pesquisa por nickname | `Where(p => p.Nickname.ToLower().Contains(texto))` |
| Equipa tem partidas? | `Any` |
| Totais e próximos Ids | `SelectMany`, `Sum`, `Select`, `Max` |
| Validação de Ids repetidos | `Count`, `Any` |
 
## Testes realizados
 
> Preencher a coluna **Resultado obtido** depois de executar cada teste na aplicação.
 
| # | Teste | Resultado esperado | Resultado obtido |
|---|---|---|---|
| 1 | Importar `campeonatos.xml` | 2 campeonatos, 6 torneios, 24 equipas, 120 jogadores, 600 pontuações | |
| 2 | Importar `campeonatos.json` | Mesmos totais do teste 1 | |
| 3 | Importar `resultados.json` depois do teste 1 | Partidas juntas aos torneios, totais de partidas atualizados | |
| 4 | Importar `resultados.json` sem dados carregados | Erro a pedir para importar primeiro os campeonatos | |
| 5 | Importar `dados_completos.xml` | 60 partidas | |
| 6 | Importar `dados_invalidos.json` | Erro com o local do problema, dados mantidos | |
| 7 | Importar `dados_invalidos.xml` | Erro com o local do problema, dados mantidos | |
| 8 | Importar `invalido_so_idade.json` | Erro de idade (60) | |
| 9 | Importar `mal_formado.xml` | Mensagem de erro, aplicação não fecha | |
| 10 | Importar `mal_formado.json` | Mensagem de erro, aplicação não fecha | |
| 11 | Converter XML → JSON e voltar a JSON → XML | Ficheiros finais com os mesmos dados | |
| 12 | Importar XML, exportar JSON, importar o JSON | Sem perda de informação | |
| 13 | Fechar e reabrir a aplicação | Os dados continuam carregados | |
| 14 | Remover uma equipa com partidas | Mensagem a recusar a remoção | |
| 15 | Agendar partida com a mesma equipa nos dois lados | Erro | |
| 16 | Agendar partida num torneio com menos de 4 equipas | Erro | |
| 17 | Adicionar jogador com idade 14 ou 46 | Erro | |
| 18 | Adicionar pontuação 101 | Erro | |
| 19 | Adicionar jogador sem nickname | Erro | |
| 20 | Pesquisar "fire" nas Estatísticas | Mostra os nicknames que contêm "fire" | |
| 21 | Consultar logs de hoje | Aparecem as ações feitas | |
 
## Decisões técnicas
 
- **`dados.json` como ficheiro de persistência:** um só ficheiro com toda a estrutura aninhada, carregado ao abrir e guardado ao fechar.
- **Validação depois de importar:** `Validations.CheckData` percorre a estrutura toda e diz exatamente onde está o erro. Só depois de passar é que os dados atuais são substituídos.
- **Partidas por ID:** as partidas referenciam as equipas por Id, o que evita duplicar objetos. Ao mudar o Id de uma equipa, as partidas são atualizadas.
- **`int?` nos resultados:** distingue "ainda não jogada" de "0 - 0".
- **Cópia `dados.json.erro`:** se o `dados.json` estiver inválido, é guardada uma cópia antes de a aplicação o poder substituir ao fechar.
- **Importação de resultados com reversão:** se uma partida do ficheiro falhar, todas as anteriores são desfeitas.
- **Proteção no XML:** o leitor bloqueia DTDs (`DtdProcessing.Prohibit`).
- **Separação interface/lógica:** os formulários não têm regras de negócio, só chamam os `Services`.
- **Classificação por nome de equipa:** as linhas agrupam-se pelo nome, por isso equipas com o mesmo nome em vários torneios juntam-se no filtro "Todos os torneios".
## Divisão de tarefas
 
> Preencher com os nomes e números do grupo.
 
| Elemento | Tarefas |
|---|---|
| Aluno 1 | |
| Aluno 2 | |
| Aluno 3 | |
| Aluno 4 | |
 
## Problemas conhecidos
 
- A classificação dá 1 ponto por empate, além de vitória = 3 e derrota = 0.
- Importar um XML ou JSON de campeonatos substitui todos os dados atuais, depois de pedir confirmação.
- Os dados são guardados ao fechar a janela principal. Se a aplicação for terminada à força, perdem-se as alterações feitas desde a última vez que abriu.
## Autores
 
Grupo: _nomes dos elementos_ · Turma: _turma_ · Professor: _nome_ · Ano letivo: 2026/2027
 
