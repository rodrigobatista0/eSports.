using eSports.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Services
{
    public static class Validations
    {
        public const int MinAge = 15;
        public const int MaxAge = 45;
        public const int MinScore = 0;
        public const int MaxScore = 100;
        public const int MinTeams = 4;

        #region Simple checks

        public static void CheckText(string text, string field)
        {
            if (text == null || text.Trim() == "")
                throw new ArgumentException("O campo " + field + " é obrigatório.");
        }

        public static void CheckId(int id)
        {
            if (id < 1)
                throw new ArgumentException("O Id tem de ser maior que 0.");
        }

        public static void CheckYear(int year)
        {
            if (year < 2000 || year > 2100)
                throw new ArgumentException("O ano tem de estar entre 2000 e 2100.");
        }

        public static void CheckAge(int age)
        {
            if (age < MinAge || age > MaxAge)
                throw new ArgumentException("A idade tem de estar entre " + MinAge + " e " + MaxAge + ".");
        }

        public static void CheckScore(int score)
        {
            if (score < MinScore || score > MaxScore)
                throw new ArgumentException("As pontuações têm de estar entre " + MinScore + " e " + MaxScore + ".");
        }

        public static void CheckResult(int result)
        {
            if (result < 0 || result > 99)
                throw new ArgumentException("O resultado tem de estar entre 0 e 99.");
        }

        #endregion

        #region Check a whole file

        // Usado depois de importar um ficheiro (ou ao abrir o dados.json).
        // Se alguma coisa estiver mal lança uma excecao com a mensagem do erro.
        public static void CheckData(Dados data)
        {
            if (data == null)
                throw new InvalidDataException("O ficheiro está vazio.");

            CheckList(data.Campeonatos, "Campeonatos");

            foreach (Campeonato championship in data.Campeonatos)
            {
                string place = "Campeonato " + championship.Id;

                CheckInside(place, () => { CheckId(championship.Id); CheckText(championship.Nome, "Nome"); CheckYear(championship.Ano); });
                CheckList(championship.Torneios, place + ": Torneios");

                if (data.Campeonatos.Count(c => c.Id == championship.Id) > 1)
                    throw new InvalidDataException(place + ": o Id está repetido.");

                foreach (Torneio tournament in championship.Torneios)
                    CheckTournament(tournament, place + " > Torneio " + tournament.Id, championship);
            }
        }

        private static void CheckTournament(Torneio tournament, string place, Campeonato championship)
        {
            CheckInside(place, () => { CheckId(tournament.Id); CheckText(tournament.Nome, "Nome"); });
            CheckList(tournament.Equipas, place + ": Equipas");
            CheckList(tournament.Partidas, place + ": Partidas");

            if (championship.Torneios.Count(t => t.Id == tournament.Id) > 1)
                throw new InvalidDataException(place + ": o Id está repetido.");

            foreach (Equipa team in tournament.Equipas)
            {
                string teamWhere = place + " > Equipa " + team.Id;

                CheckInside(teamWhere, () => { CheckId(team.Id); CheckText(team.Nome, "Nome"); });
                CheckList(team.Jogadores, teamWhere + ": Jogadores");

                if (tournament.Equipas.Count(e => e.Id == team.Id) > 1)
                    throw new InvalidDataException(teamWhere + ": o Id está repetido.");

                foreach (Jogador player in team.Jogadores)
                {
                    string playerWhere = teamWhere + " > Jogador " + player.Id;

                    CheckInside(playerWhere, () => { CheckId(player.Id); CheckText(player.Nome, "Nome"); CheckText(player.Nickname, "Nickname"); CheckAge(player.Idade); });

                    if (player.Pontuacoes == null)
                        throw new InvalidDataException(playerWhere + ": faltam as pontuações.");

                    foreach (int score in player.Pontuacoes)
                        CheckInside(playerWhere, () => CheckScore(score));

                    if (team.Jogadores.Count(j => j.Id == player.Id) > 1)
                        throw new InvalidDataException(playerWhere + ": o Id está repetido.");
                }
            }

            foreach (Partida match in tournament.Partidas)
            {
                string matchWhere = place + " > Partida " + match.Id;

                CheckInside(matchWhere, () => CheckId(match.Id));

                if (tournament.Partidas.Count(p => p.Id == match.Id) > 1)
                    throw new InvalidDataException(matchWhere + ": o Id está repetido.");

                if (match.IdEquipaA == match.IdEquipaB)
                    throw new InvalidDataException(matchWhere + ": uma equipa não pode jogar contra si própria.");

                if (!tournament.Equipas.Any(e => e.Id == match.IdEquipaA) || !tournament.Equipas.Any(e => e.Id == match.IdEquipaB))
                    throw new InvalidDataException(matchWhere + ": só podem jogar equipas inscritas no torneio.");

                if ((match.ResultadoA == null) != (match.ResultadoB == null))
                    throw new InvalidDataException(matchWhere + ": falta um dos resultados.");

                if (match.ResultadoA != null)
                    CheckInside(matchWhere, () => { CheckResult(match.ResultadoA.Value); CheckResult(match.ResultadoB.Value); });
            }
        }

        private static void CheckList<T>(List<T> list, string place) where T : class
        {
            if (list == null)
                throw new InvalidDataException(place + ": falta a lista.");

            if (list.Contains(null))
                throw new InvalidDataException(place + ": a lista tem um item vazio.");
        }

        // corre uma validacao e mete o sitio do erro na mensagem
        private static void CheckInside(string place, Action check)
        {
            try
            {
                check();
            }
            catch (ArgumentException ex)
            {
                throw new InvalidDataException(place + ": " + ex.Message);
            }
        }

        #endregion
    }
}