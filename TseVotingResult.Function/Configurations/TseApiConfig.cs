namespace TseVotingResult.Function.Configurations;

public record TseApiConfig
{
    public string BaseUrl { get; init; }

    public string DataSourcePath { get; init; }
}
