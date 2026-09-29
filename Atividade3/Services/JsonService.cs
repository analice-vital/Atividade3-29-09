using System.IO;
using Newtonsoft.Json;
using FitManager.Classes;

namespace FitManager.Services
{
    public static class JsonService
    {
        public static void Salvar(Academia academia, string caminho)
        {
            string json = JsonConvert.SerializeObject(
                academia,
                Formatting.Indented
            );

            File.WriteAllText(caminho, json);
        }

        public static Academia Carregar(string caminho)
        {
            if (!File.Exists(caminho))
            {
                return new Academia("Power Fit Academia");
            }

            string json = File.ReadAllText(caminho);

            Academia academia =
                JsonConvert.DeserializeObject<Academia>(json);

            return academia ?? new Academia("Power Fit Academia");
        }
    }
}