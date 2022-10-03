namespace TseVotingResult.Function.Services.Impl;

internal class TseVotingResultService : ITseVotingResultService
{
    private readonly string _dataSourcePath;
    private readonly HttpClient _httpClient;

    public TseVotingResultService(
        IOptions<TseApiConfig> tseApiConfig,
        HttpClient httpClient)
    {
        _dataSourcePath = tseApiConfig.Value.DataSourcePath;
        _httpClient = httpClient;
    }

    public async Task<VotingResultResponse> FetchAsync(CancellationToken cancellationToken = default)
        => await _httpClient
            .GetFromJsonAsync<VotingResultResponse>(_dataSourcePath, cancellationToken);
}
