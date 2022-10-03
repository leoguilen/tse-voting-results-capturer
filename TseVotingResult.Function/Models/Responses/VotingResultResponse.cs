using System.Text;

namespace TseVotingResult.Function.Models.Responses;

public record VotingResultResponse
{
    [JsonPropertyName("dt")]
    public string Date { get; init; }

    [JsonPropertyName("ht")]
    public string Time { get; init; }

    [JsonPropertyName("cand")]
    public CandidateResponse[] Candidates { get; init; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb
            .Append("Última atualização: ")
            .Append(Date)
            .Append(' ')
            .AppendLine(Time);

        foreach (var c in Candidates)
        {
            sb
                .Append("Candidato: ")
                .Append(c.Name)
                .Append("\tNúmero: ")
                .Append(c.Number)
                .Append("\tPartido: ")
                .Append(c.PoliticalParty)
                .Append("\tMédia de votos: ")
                .AppendLine(c.AverageVotes);
        }

        return sb.ToString();
    }
}