using System.Text.Json.Serialization;

public record Root(
    [property: JsonPropertyName("apiVersion")] string apiVersion,
    [property: JsonPropertyName("documentationUrl")] string documentationUrl,
    [property: JsonPropertyName("friendlyNotice")] string friendlyNotice,
    [property: JsonPropertyName("jobCount")] int jobCount,
    [property: JsonPropertyName("xRayHash")] string xRayHash,
    [property: JsonPropertyName("clientKey")] string clientKey,
    [property: JsonPropertyName("lastUpdate")] string lastUpdate,
    [property: JsonPropertyName("jobs")] IReadOnlyList<Job> jobs
);

