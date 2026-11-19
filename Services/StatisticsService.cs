using eSports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Services
{
    public static class StatisticsService
    {
        // rondas ganhas e perdidas de uma equipa numa partida
        private class TeamResult
        {
            public string Team;
            public int Scored;
            public int Conceded;
        }

        #region Standings

        // Vitoria = 3 pontos, derrota = 0
        public static List<StandingRow> GetStandings(List<Torneio> tournaments)
        {
            List<TeamResult> results = new List<TeamResult>();

            foreach (Torneio tournament in tournaments)
            {
                // so as partidas que ja tem resultado
                foreach (Partida match in tournament.Partidas.Where(p => p.ResultadoA != null && p.ResultadoB != null))
                {
                    Equipa teamA = tournament.Equipas.Find(e => e.Id == match.IdEquipaA);
                    Equipa teamB = tournament.Equipas.Find(e => e.Id == match.IdEquipaB);

                    if (teamA == null || teamB == null)
                        continue;

                    TeamResult resultA = new TeamResult();
                    resultA.Team = teamA.Nome;
                    resultA.Scored = match.ResultadoA.Value;
                    resultA.Conceded = match.ResultadoB.Value;
                    results.Add(resultA);

                    TeamResult resultB = new TeamResult();
                    resultB.Team = teamB.Nome;
                    resultB.Scored = match.ResultadoB.Value;
                    resultB.Conceded = match.ResultadoA.Value;
                    results.Add(resultB);
                }
            }

            // todas as equipas, mesmo as que ainda nao jogaram
            List<string> teamNames = tournaments.SelectMany(t => t.Equipas).Select(e => e.Nome).Distinct().ToList();

            List<StandingRow> rows = teamNames.Select(name =>
            {
                List<TeamResult> own = results.Where(r => r.Team == name).ToList();

                StandingRow row = new StandingRow();
                row.Team = name;
                row.Played = own.Count;
                row.Wins = own.Count(r => r.Scored > r.Conceded);
                row.Losses = own.Count(r => r.Scored < r.Conceded);
                row.Points = row.Wins * 3;

                if (own.Count > 0)
                    row.Average = own.Average(r => r.Scored);

                return row;
            })
            .OrderByDescending(r => r.Points)
            .ThenByDescending(r => r.Average)
            .ThenBy(r => r.Team)
            .ToList();

            for (int i = 0; i < rows.Count; i++)
                rows[i].Position = i + 1;

            return rows;
        }

        #endregion

        #region Players

        public static List<PlayerRow> GetAllPlayers(List<Torneio> tournaments)
        {
            List<PlayerRow> players = new List<PlayerRow>();

            foreach (Torneio tournament in tournaments)
            {
                foreach (Equipa team in tournament.Equipas)
                {
                    foreach (Jogador player in team.Jogadores)
                    {
                        PlayerRow row = new PlayerRow();
                        row.Nickname = player.Nickname;
                        row.Name = player.Nome;
                        row.Age = player.Idade;
                        row.Team = team.Nome;
                        row.Tournament = tournament.Nome;
                        row.ScoreCount = player.Pontuacoes.Count;
                        row.Total = player.Pontuacoes.Sum();

                        if (player.Pontuacoes.Count > 0)
                            row.Average = player.Pontuacoes.Average();

                        players.Add(row);
                    }
                }
            }

            return players;
        }

        public static List<PlayerRow> GetTop3(List<Torneio> tournaments)
        {
            List<PlayerRow> top = GetAllPlayers(tournaments)
                .Where(p => p.ScoreCount > 0)
                .OrderByDescending(p => p.Average)
                .ThenByDescending(p => p.Total)
                .Take(3)
                .ToList();

            for (int i = 0; i < top.Count; i++)
                top[i].Position = i + 1;

            return top;
        }

        public static double OverallAverage(List<Torneio> tournaments)
        {
            List<int> scores = tournaments
                .SelectMany(t => t.Equipas)
                .SelectMany(e => e.Jogadores)
                .SelectMany(j => j.Pontuacoes)
                .ToList();

            if (scores.Count == 0)
                return 0;

            return scores.Average();
        }

        public static int PlayersCount(List<Torneio> tournaments)
        {
            return tournaments.SelectMany(t => t.Equipas).Sum(e => e.Jogadores.Count);
        }

        public static List<PlayerRow> SearchByNickname(List<Torneio> tournaments, string text)
        {
            string search = text.Trim().ToLower();

            return GetAllPlayers(tournaments)
                .Where(p => p.Nickname.ToLower().Contains(search))
                .OrderBy(p => p.Nickname)
                .ToList();
        }

        #endregion
    }
}