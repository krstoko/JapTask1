using System.Text.Json.Serialization;

namespace backend.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MeasureUnit
    {
        Kilogram,
        Gram,
        Decigram,
        Liter,
        Deciliter,
        Mililiter
    }
}
