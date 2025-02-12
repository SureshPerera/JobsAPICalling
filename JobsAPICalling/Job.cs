using System.Text.Json.Serialization;

public record Job(
        [property: JsonPropertyName("id")] int id,
        [property: JsonPropertyName("url")] string url,
        [property: JsonPropertyName("jobSlug")] string jobSlug,
        [property: JsonPropertyName("jobTitle")] string jobTitle,
        [property: JsonPropertyName("companyName")] string companyName,
        [property: JsonPropertyName("companyLogo")] string companyLogo,
        [property: JsonPropertyName("jobIndustry")] IReadOnlyList<string> jobIndustry,
        [property: JsonPropertyName("jobType")] IReadOnlyList<string> jobType,
        [property: JsonPropertyName("jobGeo")] string jobGeo,
        [property: JsonPropertyName("jobLevel")] string jobLevel,
        [property: JsonPropertyName("jobExcerpt")] string jobExcerpt,
        [property: JsonPropertyName("jobDescription")] string jobDescription,
        [property: JsonPropertyName("pubDate")] string pubDate,
        [property: JsonPropertyName("annualSalaryMin")] int annualSalaryMin,
        [property: JsonPropertyName("annualSalaryMax")] int annualSalaryMax,
        [property: JsonPropertyName("salaryCurrency")] string salaryCurrency
    );

