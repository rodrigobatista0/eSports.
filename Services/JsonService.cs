using eSports.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace eSports.Services
{
    // Precisa do pacote NuGet System.Text.Json
    public static class JsonService
    {
        private static JsonSerializerOptions CreateOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;
            options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping; // para os acentos ficarem normais
            return options;
        }

        public static Dados Load(string path)
        {
            string text = File.ReadAllText(path);
            Dados data = JsonSerializer.Deserialize<Dados>(text, CreateOptions());

            if (data == null)
                throw new InvalidDataException("O ficheiro JSON está vazio.");

            return data;
        }

        // Le o resultados.json. Aceita uma lista de partidas, ou um objeto com "partidas",
        // ou um objeto com "torneios" onde cada torneio tem as suas "partidas".
        // Devolve pares (Id do torneio, partida). Id do torneio 0 = o ficheiro nao diz.
        public static List<KeyValuePair<int, Partida>> LoadResults(string path)
        {
            string text = File.ReadAllText(path);
            List<KeyValuePair<int, Partida>> results = new List<KeyValuePair<int, Partida>>();

            using (JsonDocument document = JsonDocument.Parse(text))
            {
                JsonElement root = document.RootElement;

                if (root.ValueKind == JsonValueKind.Array)
                {
                    ReadMatches(root, 0, results);
                }
                else if (root.ValueKind == JsonValueKind.Object)
                {
                    JsonElement list;
                    bool found = false;

                    if (FindProperty(root, out list, "partidas", "resultados"))
                    {
                        ReadMatches(list, 0, results);
                        found = true;
                    }

                    if (FindProperty(root, out list, "torneios"))
                    {
                        foreach (JsonElement tournament in list.EnumerateArray())
                        {
                            JsonElement matches;
                            JsonElement id;
                            int tournamentId = 0;

                            if (FindProperty(tournament, out id, "id", "idTorneio", "torneioId"))
                                tournamentId = ReadInt(id, "id do torneio");

                            if (FindProperty(tournament, out matches, "partidas", "resultados"))
                                ReadMatches(matches, tournamentId, results);
                        }

                        found = true;
                    }

                    if (found == false)
                        throw new InvalidDataException("O ficheiro de resultados não tem a lista \"partidas\".");
                }
                else
                {
                    throw new InvalidDataException("O ficheiro de resultados não tem o formato esperado.");
                }
            }

            if (results.Count == 0)
                throw new InvalidDataException("O ficheiro de resultados não tem partidas.");

            return results;
        }

        private static void ReadMatches(JsonElement list, int tournamentId, List<KeyValuePair<int, Partida>> results)
        {
            if (list.ValueKind != JsonValueKind.Array)
                throw new InvalidDataException("A lista de partidas está mal escrita.");

            foreach (JsonElement item in list.EnumerateArray())
            {
                if (item.ValueKind != JsonValueKind.Object)
                    throw new InvalidDataException("Uma das partidas está mal escrita.");

                JsonElement value;
                Partida match = new Partida();
                int id = tournamentId;

                if (FindProperty(item, out value, "idTorneio", "torneioId"))
                    id = ReadInt(value, "idTorneio");

                if (FindProperty(item, out value, "id", "idPartida"))
                    match.Id = ReadInt(value, "id da partida");

                if (FindProperty(item, out value, "data"))
                    match.Data = ReadDate(value);

                if (FindProperty(item, out value, "idEquipaA", "equipaA"))
                    match.IdEquipaA = ReadInt(value, "idEquipaA");

                if (FindProperty(item, out value, "idEquipaB", "equipaB"))
                    match.IdEquipaB = ReadInt(value, "idEquipaB");

                if (FindProperty(item, out value, "resultadoA") && value.ValueKind != JsonValueKind.Null)
                    match.ResultadoA = ReadInt(value, "resultadoA");

                if (FindProperty(item, out value, "resultadoB") && value.ValueKind != JsonValueKind.Null)
                    match.ResultadoB = ReadInt(value, "resultadoB");

                results.Add(new KeyValuePair<int, Partida>(id, match));
            }
        }

        // procura uma propriedade pelo nome (sem ligar a maiusculas)
        private static bool FindProperty(JsonElement element, out JsonElement value, params string[] names)
        {
            value = new JsonElement();

            if (element.ValueKind != JsonValueKind.Object)
                return false;

            foreach (JsonProperty property in element.EnumerateObject())
            {
                foreach (string name in names)
                {
                    if (string.Equals(property.Name, name, StringComparison.OrdinalIgnoreCase))
                    {
                        value = property.Value;
                        return true;
                    }
                }
            }

            return false;
        }

        private static int ReadInt(JsonElement value, string field)
        {
            int number;

            if (value.ValueKind == JsonValueKind.Number && value.TryGetInt32(out number))
                return number;

            throw new InvalidDataException("O campo " + field + " tem de ser um número inteiro.");
        }

        private static DateTime ReadDate(JsonElement value)
        {
            DateTime date;

            if (value.ValueKind == JsonValueKind.String)
            {
                string text = value.GetString();

                if (DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    return date;

                if (DateTime.TryParse(text, new CultureInfo("pt-PT"), DateTimeStyles.None, out date))
                    return date;
            }

            throw new InvalidDataException("A data de uma partida está mal escrita.");
        }

        public static void Save(Dados data, string path)
        {
            string text = JsonSerializer.Serialize(data, CreateOptions());
            File.WriteAllText(path, text);
        }
    }
}