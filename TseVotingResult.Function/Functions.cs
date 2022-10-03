namespace TseVotingResult.Function;

public class Functions
{
    private readonly ITseVotingResultService _tseVotingResultService;

    public Functions(ITseVotingResultService tseVotingResultService)
        => _tseVotingResultService = tseVotingResultService;

    [FunctionName("Ingestion")]
    public async Task RunAsync(
        [TimerTrigger("*/5 * * * * *")] TimerInfo timerInfo,
        ILogger logger,
        CancellationToken requestCancellationToken)
    {
        logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

        var votingResult = await _tseVotingResultService
            .FetchAsync(requestCancellationToken);

        logger.LogInformation("Resultados de votação recuperados do TSE: {votingResult}", votingResult.ToString());
    }
}
