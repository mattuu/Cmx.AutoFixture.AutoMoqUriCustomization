using RestSharp;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Console
{
    public class RestClientFactory : IRestClientFactory
    {
        public IRestClient Create()
        {
            return new RestClient("http://server.com");
        }
    }
}