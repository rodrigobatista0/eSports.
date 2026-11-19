using eSports.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Services
{
    public class DataService
    {
        private Dados m_data = new Dados();
        private string m_path;

        public Dados Data { get { return m_data; } }

        public string FilePath { get { return m_path; } }

        public DataService()
        {
            m_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.json");
        }

        #region Files

        // Devolve false se o dados.json ainda nao existe
        public bool Load()
        {
            if (!File.Exists(m_path))
                return false;

            try
            {
                Dados loaded = JsonService.Load(m_path);
                Validations.CheckData(loaded);
                m_data = loaded;
            }
            catch (Exception)
            {
                // guarda uma copia para o ficheiro nao se perder quando a aplicacao guardar por cima
                try
                {
                    File.Copy(m_path, m_path + ".erro", true);
                }
                catch (IOException)
                {
                }
                throw;
            }

            return true;
        }

        public void Save()
        {
            JsonService.Save(m_data, m_path);
        }

        public void ImportXml(string path)
        {
            Replace(XmlService.Load(path));
        }

        public void ImportJson(string path)
        {
            Replace(JsonService.Load(path));
        }

        public void ExportXml(string path)
        {
            XmlService.Save(m_data, path);
        }

        public void ExportJson(string path)
        {
            JsonService.Save(m_data, path);
        }

        public void ConvertXmlToJson(string xmlPath, string jsonPath)
        {
            Dados data = XmlService.Load(xmlPath);
            Validations.CheckData(data);
            JsonService.Save(data, jsonPath);
        }

        public void ConvertJsonToXml(string jsonPath, string xmlPath)
        {
            Dados data = JsonService.Load(jsonPath);
            Validations.CheckData(data);
            XmlService.Save(data, xmlPath);
        }

        private void Replace(Dados data)
        {
            Validations.CheckData(data);
            m_data = data;
        }

        #endregion

        #region Queries

        public List<Torneio> AllTournaments()
        {
            return m_data.Campeonatos.SelectMany(c => c.Torneios).ToList();
        }

        public int TotalTournaments()
        {
            return m_data.Campeonatos.Sum(c => c.Torneios.Count);
        }

        public int TotalTeams()
        {
            return AllTournaments().Sum(t => t.Equipas.Count);
        }

        public int TotalPlayers()
        {
            return AllTournaments().SelectMany(t => t.Equipas).Sum(e => e.Jogadores.Count);
        }

        public int TotalMatches()
        {
            return AllTournaments().Sum(t => t.Partidas.Count);
        }

        public int TotalScores()
        {
            return AllTournaments().SelectMany(t => t.Equipas).SelectMany(e => e.Jogadores).Sum(j => j.Pontuacoes.Count);
        }

        public int NextChampionshipId()
        {
            return NextId(m_data.Campeonatos.Select(c => c.Id));
        }

        public int NextTournamentId(Campeonato championship)
        {
            if (championship == null)
                return 1;

            return NextId(championship.Torneios.Select(t => t.Id));
        }

        public int NextTeamId(Torneio tournament)
        {
            if (tournament == null)
                return 1;

            return NextId(tournament.Equipas.Select(e => e.Id));
        }

        public int NextPlayerId(Equipa team)
        {
            if (team == null)
                return 1;

            return NextId(team.Jogadores.Select(j => j.Id));
        }

        public int NextMatchId(Torneio tournament)
        {
            if (tournament == null)
                return 1;

            return NextId(tournament.Partidas.Select(p => p.Id));
        }

        private int NextId(IEnumerable<int> ids)
        {
            if (!ids.Any())
                return 1;

            return ids.Max() + 1;
        }

        public string TeamName(Torneio tournament, int teamId)
        {
            Equipa team = tournament.Equipas.Find(e => e.Id == teamId);

            if (team == null)
                return "?";

            return team.Nome;
        }

        public bool TeamHasMatches(Torneio tournament, Equipa team)
        {
            return tournament.Partidas.Any(p => p.IdEquipaA == team.Id || p.IdEquipaB == team.Id);
        }

        public string ResultText(Partida match)
        {
            if (match.ResultadoA == null || match.ResultadoB == null)
                return "-";

            return match.ResultadoA.Value + " - " + match.ResultadoB.Value;
        }

        public string WinnerName(Torneio tournament, Partida match)
        {
            if (match.ResultadoA == null || match.ResultadoB == null)
                return "-";

            if (match.ResultadoA.Value > match.ResultadoB.Value)
                return TeamName(tournament, match.IdEquipaA);

            if (match.ResultadoB.Value > match.ResultadoA.Value)
                return TeamName(tournament, match.IdEquipaB);

            return "Empate";
        }

        #endregion

        #region Championships

        public void AddChampionship(int id, string name, int year)
        {
            CheckChampionship(null, id, name, year);

            Campeonato championship = new Campeonato();
            championship.Id = id;
            championship.Nome = name.Trim();
            championship.Ano = year;
            m_data.Campeonatos.Add(championship);
        }

        public void EditChampionship(Campeonato championship, int id, string name, int year)
        {
            if (championship == null)
                throw new ArgumentException("Escolha um campeonato na grelha.");

            CheckChampionship(championship, id, name, year);

            championship.Id = id;
            championship.Nome = name.Trim();
            championship.Ano = year;
        }

        public void RemoveChampionship(Campeonato championship)
        {
            if (championship == null)
                throw new ArgumentException("Escolha um campeonato na grelha.");

            m_data.Campeonatos.Remove(championship);
        }

        private void CheckChampionship(Campeonato current, int id, string name, int year)
        {
            Validations.CheckId(id);
            Validations.CheckText(name, "Nome");
            Validations.CheckYear(year);

            if (m_data.Campeonatos.Any(c => c != current && c.Id == id))
                throw new ArgumentException("Já existe um campeonato com o Id " + id + ".");
        }

        #endregion

        #region Tournaments

        public void AddTournament(Campeonato championship, int id, string name, string game)
        {
            if (championship == null)
                throw new ArgumentException("Escolha um campeonato.");

            CheckTournament(championship, null, id, name, game);

            Torneio tournament = new Torneio();
            tournament.Id = id;
            tournament.Nome = name.Trim();
            tournament.Jogo = game.Trim();
            championship.Torneios.Add(tournament);
        }

        public void EditTournament(Campeonato championship, Torneio tournament, int id, string name, string game)
        {
            if (championship == null)
                throw new ArgumentException("Escolha um campeonato.");

            if (tournament == null)
                throw new ArgumentException("Escolha um torneio na grelha.");

            CheckTournament(championship, tournament, id, name, game);

            tournament.Id = id;
            tournament.Nome = name.Trim();
            tournament.Jogo = game.Trim();
        }

        public void RemoveTournament(Campeonato championship, Torneio tournament)
        {
            if (championship == null)
                throw new ArgumentException("Escolha um campeonato.");

            if (tournament == null)
                throw new ArgumentException("Escolha um torneio na grelha.");

            championship.Torneios.Remove(tournament);
        }

        private void CheckTournament(Campeonato championship, Torneio current, int id, string name, string game)
        {
            Validations.CheckId(id);
            Validations.CheckText(name, "Nome");
            Validations.CheckText(game, "Jogo");

            if (championship.Torneios.Any(t => t != current && t.Id == id))
                throw new ArgumentException("Já existe um torneio com o Id " + id + " neste campeonato.");
        }

        #endregion

        #region Teams

        // Adicionar uma equipa ao torneio e inscreve-la nele
        public void AddTeam(Torneio tournament, int id, string name, string country)
        {
            if (tournament == null)
                throw new ArgumentException("Escolha um torneio.");

            CheckTeam(tournament, null, id, name);

            Equipa team = new Equipa();
            team.Id = id;
            team.Nome = name.Trim();
            team.Pais = (country == null) ? "" : country.Trim();
            tournament.Equipas.Add(team);
        }

        public void EditTeam(Torneio tournament, Equipa team, int id, string name, string country)
        {
            if (tournament == null)
                throw new ArgumentException("Escolha um torneio.");

            if (team == null)
                throw new ArgumentException("Escolha uma equipa na grelha.");

            CheckTeam(tournament, team, id, name);

            int oldId = team.Id;
            team.Id = id;
            team.Nome = name.Trim();
            team.Pais = (country == null) ? "" : country.Trim();

            // as partidas guardam so o Id da equipa, por isso tem de acompanhar a mudanca
            foreach (Partida match in tournament.Partidas)
            {
                if (match.IdEquipaA == oldId)
                    match.IdEquipaA = id;

                if (match.IdEquipaB == oldId)
                    match.IdEquipaB = id;
            }
        }

        public void RemoveTeam(Torneio tournament, Equipa team)
        {
            if (tournament == null)
                throw new ArgumentException("Escolha um torneio.");

            if (team == null)
                throw new ArgumentException("Escolha uma equipa na grelha.");

            if (TeamHasMatches(tournament, team))
                throw new InvalidOperationException("A equipa " + team.Nome + " tem partidas registadas e não pode ser removida.");

            tournament.Equipas.Remove(team);
        }

        private void CheckTeam(Torneio tournament, Equipa current, int id, string name)
        {
            Validations.CheckId(id);
            Validations.CheckText(name, "Nome");

            if (tournament.Equipas.Any(e => e != current && e.Id == id))
                throw new ArgumentException("Já existe uma equipa com o Id " + id + " neste torneio.");
        }

        #endregion

        #region Players

        public void AddPlayer(Equipa team, int id, string name, string nickname, int age, List<int> scores)
        {
            if (team == null)
                throw new ArgumentException("Escolha uma equipa.");

            CheckPlayer(team, null, id, name, nickname, age, scores);

            Jogador player = new Jogador();
            player.Id = id;
            player.Nome = name.Trim();
            player.Nickname = nickname.Trim();
            player.Idade = age;
            player.Pontuacoes = new List<int>(scores);
            team.Jogadores.Add(player);
        }

        public void EditPlayer(Equipa team, Jogador player, int id, string name, string nickname, int age, List<int> scores)
        {
            if (team == null)
                throw new ArgumentException("Escolha uma equipa.");

            if (player == null)
                throw new ArgumentException("Escolha um jogador na grelha.");

            CheckPlayer(team, player, id, name, nickname, age, scores);

            player.Id = id;
            player.Nome = name.Trim();
            player.Nickname = nickname.Trim();
            player.Idade = age;
            player.Pontuacoes = new List<int>(scores);
        }

        public void RemovePlayer(Equipa team, Jogador player)
        {
            if (team == null)
                throw new ArgumentException("Escolha uma equipa.");

            if (player == null)
                throw new ArgumentException("Escolha um jogador na grelha.");

            team.Jogadores.Remove(player);
        }

        private void CheckPlayer(Equipa team, Jogador current, int id, string name, string nickname, int age, List<int> scores)
        {
            Validations.CheckId(id);
            Validations.CheckText(name, "Nome");
            Validations.CheckText(nickname, "Nickname");
            Validations.CheckAge(age);

            foreach (int score in scores)
                Validations.CheckScore(score);

            if (team.Jogadores.Any(j => j != current && j.Id == id))
                throw new ArgumentException("Já existe um jogador com o Id " + id + " nesta equipa.");
        }

        #endregion

        #region Matches

        public void ScheduleMatch(Torneio tournament, int id, DateTime date, Equipa teamA, Equipa teamB)
        {
            if (tournament == null)
                throw new ArgumentException("Escolha um torneio.");

            Validations.CheckId(id);

            if (tournament.Partidas.Any(p => p.Id == id))
                throw new ArgumentException("Já existe uma partida com o Id " + id + " neste torneio.");

            if (tournament.Equipas.Count < Validations.MinTeams)
                throw new InvalidOperationException("O torneio precisa de pelo menos " + Validations.MinTeams + " equipas inscritas para agendar partidas (tem " + tournament.Equipas.Count + ").");

            if (teamA == null || teamB == null)
                throw new ArgumentException("Escolha as duas equipas.");

            if (teamA == teamB)
                throw new ArgumentException("Uma equipa não pode jogar contra si própria.");

            if (!tournament.Equipas.Contains(teamA) || !tournament.Equipas.Contains(teamB))
                throw new ArgumentException("Só podem jogar equipas inscritas no torneio.");

            Partida match = new Partida();
            match.Id = id;
            match.Data = date.Date;
            match.IdEquipaA = teamA.Id;
            match.IdEquipaB = teamB.Id;
            tournament.Partidas.Add(match);
        }

        public void RemoveMatch(Torneio tournament, Partida match)
        {
            if (tournament == null)
                throw new ArgumentException("Escolha um torneio.");

            if (match == null)
                throw new ArgumentException("Escolha uma partida na grelha.");

            tournament.Partidas.Remove(match);
        }

        public void SaveResult(Partida match, int scoreA, int scoreB)
        {
            if (match == null)
                throw new ArgumentException("Escolha uma partida na grelha.");

            Validations.CheckResult(scoreA);
            Validations.CheckResult(scoreB);

            if (scoreA == scoreB)
                throw new ArgumentException("Não pode haver empates. Uma das equipas tem de ter mais rondas.");

            match.ResultadoA = scoreA;
            match.ResultadoB = scoreB;
        }

        #endregion

        #region Sample data

        // So para a aplicacao nao abrir vazia da primeira vez
        public void CreateSampleData()
        {
            Dados data = new Dados();

            Campeonato championship = new Campeonato();
            championship.Id = 1;
            championship.Nome = "Liga Portuguesa de eSports";
            championship.Ano = 2026;

            Torneio tournament = new Torneio();
            tournament.Id = 1;
            tournament.Nome = "Open de Lisboa";
            tournament.Jogo = "Counter-Strike 2";

            Equipa wolves = CreateSampleTeam(1, "Lisboa Wolves", "Portugal");
            AddSamplePlayer(wolves, 1, "Rui Santos", "Wolfie", 21, 78, 85, 92);
            AddSamplePlayer(wolves, 2, "Miguel Costa", "Blaze", 19, 64, 70, 72);

            Equipa dragons = CreateSampleTeam(2, "Porto Dragons", "Portugal");
            AddSamplePlayer(dragons, 1, "Nuno Reis", "Drako", 23, 88, 90, 81);
            AddSamplePlayer(dragons, 2, "André Pinto", "Fenix", 20, 55, 61, 58);

            Equipa kings = CreateSampleTeam(3, "Madrid Kings", "Espanha");
            AddSamplePlayer(kings, 1, "Carlos Ruiz", "ElRey", 24, 70, 74, 69);
            AddSamplePlayer(kings, 2, "Pablo Vega", "Toro", 22, 66, 59, 73);

            Equipa phoenix = CreateSampleTeam(4, "Paris Phoenix", "França");
            AddSamplePlayer(phoenix, 1, "Louis Martin", "Ashes", 25, 91, 87, 95);
            AddSamplePlayer(phoenix, 2, "Hugo Petit", "Spark", 18, 48, 52, 60);

            tournament.Equipas.Add(wolves);
            tournament.Equipas.Add(dragons);
            tournament.Equipas.Add(kings);
            tournament.Equipas.Add(phoenix);

            tournament.Partidas.Add(CreateSampleMatch(1, new DateTime(2026, 3, 14), 1, 2, 16, 12));
            tournament.Partidas.Add(CreateSampleMatch(2, new DateTime(2026, 3, 14), 3, 4, 13, 16));
            tournament.Partidas.Add(CreateSampleMatch(3, new DateTime(2026, 3, 21), 1, 3, null, null));

            championship.Torneios.Add(tournament);
            data.Campeonatos.Add(championship);

            m_data = data;
        }

        private Equipa CreateSampleTeam(int id, string name, string country)
        {
            Equipa team = new Equipa();
            team.Id = id;
            team.Nome = name;
            team.Pais = country;
            return team;
        }

        private void AddSamplePlayer(Equipa team, int id, string name, string nickname, int age, params int[] scores)
        {
            Jogador player = new Jogador();
            player.Id = id;
            player.Nome = name;
            player.Nickname = nickname;
            player.Idade = age;
            player.Pontuacoes = new List<int>(scores);
            team.Jogadores.Add(player);
        }

        private Partida CreateSampleMatch(int id, DateTime date, int teamA, int teamB, int? scoreA, int? scoreB)
        {
            Partida match = new Partida();
            match.Id = id;
            match.Data = date;
            match.IdEquipaA = teamA;
            match.IdEquipaB = teamB;
            match.ResultadoA = scoreA;
            match.ResultadoB = scoreB;
            return match;
        }

        #endregion
    }
}