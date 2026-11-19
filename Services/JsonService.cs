using eSports.Models;
using System;
using System.Collections.Generic;
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

        public static void Save(Dados data, string path)
        {
            string text = JsonSerializer.Serialize(data, CreateOptions());
            File.WriteAllText(path, text);
        }
    }
}