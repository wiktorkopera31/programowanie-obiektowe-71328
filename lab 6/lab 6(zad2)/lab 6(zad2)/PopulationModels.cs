using System.Text.Json.Serialization;

namespace ProjektPopulacja
{
    public class PopulationData
    {
        [JsonPropertyName("indicator")]
        public ItemInfo Indicator { get; set; }

        [JsonPropertyName("country")]
        public ItemInfo Country { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        // Właściwość pomocnicza do pobierania populacji jako liczby
        public long? PopulationValue => long.TryParse(Value, out long val) ? val : (long?)null;
    }

    public class ItemInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}