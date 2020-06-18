using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Content.Pipeline.MedataProcessing.AzureFunction.Startup))]
namespace Content.Pipeline.MedataProcessing.AzureFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
        }
    }
}
