using System.Text.Json.Serialization;

namespace backend.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MeasureUnit
    {
        Kg,
        G,
        Dag,
        L,
        Dal,
        ML
    }
}
