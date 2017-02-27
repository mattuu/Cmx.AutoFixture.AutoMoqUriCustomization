using RestSharp;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Console
{
    public interface IRestClientFactory
    {
        IRestClient Create();
    }
}