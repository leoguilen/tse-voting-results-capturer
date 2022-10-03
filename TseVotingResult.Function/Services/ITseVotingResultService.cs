namespace TseVotingResult.Function.Services;

public interface ITseVotingResultService
{
    Task<VotingResultResponse> FetchAsync(CancellationToken cancellationToken = default);
}
