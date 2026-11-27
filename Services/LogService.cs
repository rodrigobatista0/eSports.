using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSports.Models;

namespace eSports.Services
{
    // Guarda e le os logs no ficheiro logs.txt (fica ao lado do .exe)
    // Cada linha: 2026-11-20 15:30:00|Acao|Detalhes
    public class LogService
    {
        private const char Separator = '|';
        private const string DateFormat = "yyyy-MM-dd HH:mm:ss";

        private string m_path;

        public string FilePath { get { return m_path; } }

        public LogService()
        {
            m_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");
        }

        #region Write

        // Escreve uma linha no fim do ficheiro.
        // Um erro nos logs nunca pode estragar o resto do programa, por isso nao rebenta.
        public void Write(string action, string details)
        {
            try
            {
                string line = DateTime.Now.ToString(DateFormat, CultureInfo.InvariantCulture)
                    + Separator + Clean(action)
                    + Separator + Clean(details);

                File.AppendAllText(m_path, line + Environment.NewLine, Encoding.UTF8);
            }
            catch (IOException)
            {
            }
            catch (UnauthorizedAccessException)
            {
            }
        }

        // Tira o separador e as mudancas de linha para nao partirem o ficheiro
        private string Clean(string text)
        {
            if (text == null)
                return "";

            return text.Replace(Separator, '/').Replace("\r", " ").Replace("\n", " ").Trim();
        }

        #endregion

        #region Read

        // Devolve os logs entre as duas datas (os dois dias contam inteiros), do mais recente para o mais antigo
        public List<LogEntry> GetBetween(DateTime from, DateTime to)
        {
            if (from.Date > to.Date)
                throw new ArgumentException("A data inicial não pode ser depois da data final.");

            List<LogEntry> result = new List<LogEntry>();

            if (!File.Exists(m_path))
                return result;

            DateTime start = from.Date;
            DateTime end = to.Date.AddDays(1);

            foreach (string line in File.ReadAllLines(m_path, Encoding.UTF8))
            {
                LogEntry entry = ReadLine(line);

                // linhas estragadas sao ignoradas
                if (entry == null)
                    continue;

                if (entry.Date >= start && entry.Date < end)
                    result.Add(entry);
            }

            result.Reverse();
            return result;
        }

        // Transforma uma linha do ficheiro num LogEntry (null se a linha for invalida)
        private LogEntry ReadLine(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return null;

            string[] parts = line.Split(new char[] { Separator }, 3);

            if (parts.Length < 3)
                return null;

            DateTime date;

            if (!DateTime.TryParseExact(parts[0], DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                return null;

            LogEntry entry = new LogEntry();
            entry.Date = date;
            entry.Action = parts[1];
            entry.Details = parts[2];
            return entry;
        }

        #endregion
    }
}
