namespace TseVotingResult.Function.Models.Responses;

public record CandidateResponse
{
    [JsonPropertyName("seq")]
    public int Sequence { get; init; }

    [JsonPropertyName("n")]
    public int Number { get; init; }

    [JsonPropertyName("nm")]
    public string Name { get; init; }

    [JsonPropertyName("cc")]
    public string PoliticalParty { get; init; }

    [JsonPropertyName("nv")]
    public string ViceName { get; init; }

    [JsonPropertyName("pvap")]
    public string AverageVotes { get; init; }
}