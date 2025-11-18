using System.Text.Json;
using System.Text.Json.Serialization;
using BdfEditor.Models.Entities.Settings;

namespace BdfEditor.Models.Entities;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true)]
[JsonSerializable(typeof(AppSettings))]
internal partial class SourceGenerationJsonSerializerContext : JsonSerializerContext;

internal static class EntityConvert
{
    public static string JsonSerialize<TValue>(TValue value) => JsonSerializer.Serialize(value, typeof(TValue), SourceGenerationJsonSerializerContext.Default);

    public static TValue? JsonDeserialize<TValue>(string json) => (TValue?)JsonSerializer.Deserialize(json, typeof(TValue), SourceGenerationJsonSerializerContext.Default);
}
