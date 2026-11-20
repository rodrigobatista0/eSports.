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
            List<StandingRow> rows = new List<StandingRow>();
            List<int> rounds = new List<int>();

            foreach (Torneio tournament in tournaments)
            {
                foreach (Equipa team in tournament.Equipas)
                {
                    StandingRow row = rows.FirstOrDefault(r => r.Team == team.Nome);

                    if (row == null)
                    {
                        row = new StandingRow();
                        row.Team = team.Nome;
                        rows.Add(row);
                        rounds.Add(0);
                    }

                    List<Partida> played = tournament.Partidas.Where(p => p.ResultadoA != null && p.ResultadoB != null &&
                        (p.IdEquipaA == team.Id || p.IdEquipaB == team.Id)).ToList();

                    row.Played += played.Count;
                    row.Wins += played.Count(p => Scored(p, team.Id) > Conceded(p, team.Id));
                    row.Losses += played.Count(p => Scored(p, team.Id) < Conceded(p, team.Id));
                    rounds[rows.IndexOf(row)] += played.Sum(p => Scored(p, team.Id));
                }
            }

            for (int i = 0; i < rows.Count; i++)
            {
                rows[i].Points = rows[i].Wins * 3;

                if (rows[i].Played > 0)
                    rows[i].Average = (double)rounds[i] / rows[i].Played;
            }

            rows = rows.OrderByDescending(r => r.Points).ToList();

            for (int i = 0; i < rows.Count; i++)
                rows[i].Position = i + 1;

            return rows;
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
