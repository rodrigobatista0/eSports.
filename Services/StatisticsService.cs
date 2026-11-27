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
        #region Classificação

        public static List<StandingRow> GetStandings(List<Torneio> tournaments)
        {
            List<StandingRow> rows = tournaments
                .SelectMany(t => t.Equipas.Select(e => new KeyValuePair<Torneio, Equipa>(t, e)))
                .GroupBy(pair => pair.Value.Nome)
                .Select(group => BuildRow(group.Key, group.ToList()))
                .OrderByDescending(r => r.Points)
                .ThenByDescending(r => r.Wins)
                .ThenByDescending(r => r.Average)
                .ToList();

            for (int i = 0; i < rows.Count; i++)
                rows[i].Position = i + 1;

            return rows;
        }

        private static StandingRow BuildRow(string teamName, List<KeyValuePair<Torneio, Equipa>> teams)
        {
            StandingRow row = new StandingRow();
            row.Team = teamName;
            int rounds = 0;

            foreach (KeyValuePair<Torneio, Equipa> pair in teams)
            {
                int id = pair.Value.Id;

                List<Partida> played = pair.Key.Partidas.Where(p => p.ResultadoA != null && p.ResultadoB != null &&
                    (p.IdEquipaA == id || p.IdEquipaB == id)).ToList();

                row.Played += played.Count;
                row.Wins += played.Count(p => Scored(p, id) > Conceded(p, id));
                row.Draws += played.Count(p => Scored(p, id) == Conceded(p, id));
                row.Losses += played.Count(p => Scored(p, id) < Conceded(p, id));
                rounds += played.Sum(p => Scored(p, id));
            }

            row.Points = row.Wins * 3 + row.Draws;

            if (row.Played > 0)
                row.Average = (double)rounds / row.Played;

            return row;
        }

        private static int Scored(Partida match, int teamId)
        {
            if (match.IdEquipaA == teamId)
                return (int)match.ResultadoA;

            return (int)match.ResultadoB;
        }

        private static int Conceded(Partida match, int teamId)
        {
            if (match.IdEquipaA == teamId)
                return (int)match.ResultadoB;

            return (int)match.ResultadoA;
        }

        #endregion

        #region Jogadores

        public static List<PlayerRow> GetPlayers(List<Torneio> tournaments)
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
                        row.Total = player.Pontuacoes.Sum(n => n);

                        if (player.Pontuacoes.Count > 0)
                            row.Average = player.Pontuacoes.Average(n => n);

                        players.Add(row);
                    }
                }
            }

            return players;
        }

        public static List<PlayerRow> GetTop3(List<Torneio> tournaments)
        {
            List<PlayerRow> ordered = GetPlayers(tournaments).Where(p => p.ScoreCount > 0)
                .OrderByDescending(p => p.Average).ToList();
            List<PlayerRow> top = new List<PlayerRow>();

            for (int i = 0; i < ordered.Count && i < 3; i++)
            {
                ordered[i].Position = i + 1;
                top.Add(ordered[i]);
            }

            return top;
        }

        public static double OverallAverage(List<Torneio> tournaments)
        {
            List<int> scores = new List<int>();

            foreach (Torneio tournament in tournaments)
            {
                foreach (Equipa team in tournament.Equipas)
                {
                    foreach (Jogador player in team.Jogadores)
                        scores.AddRange(player.Pontuacoes);
                }
            }

            if (scores.Count == 0)
                return 0;

            return scores.Average(n => n);
        }

        public static List<PlayerRow> SearchNickname(List<Torneio> tournaments, string text)
        {
            string search = text.Trim().ToLower();

            return GetPlayers(tournaments).Where(p => p.Nickname.ToLower().Contains(search)).ToList();
        }

        #endregion
    }
}