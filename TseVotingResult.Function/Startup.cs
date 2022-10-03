[assembly: FunctionsStartup(typeof(Startup))]
namespace TseVotingResult.Function;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        _ = builder.Services
            .AddOptions<TseApiConfig>()
                .Configure<IConfiguration>((settings, configuration)
                    => configuration.GetSection("TseApiConfig").Bind(settings)).Services
            .AddHttpClient<ITseVotingResultService, TseVotingResultService>((provider, client) =>
            {
                var tseApiConfig = provider.GetRequiredService<IOptions<TseApiConfig>>();
                ArgumentNullException.ThrowIfNull(tseApiConfig);

                client.BaseAddress = new Uri(tseApiConfig.Value.BaseUrl);
            });
    }
}
