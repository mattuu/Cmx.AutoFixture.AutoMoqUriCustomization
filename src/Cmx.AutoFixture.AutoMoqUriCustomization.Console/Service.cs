using System;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Console
{
    public class Service
    {
        private readonly ILoggingService _loggingService;
        private readonly IRestClientFactory _restClientFactory;

        public Service(IRestClientFactory restClientFactory, ILoggingService loggingService)
        {
            if (restClientFactory == null) throw new ArgumentNullException(nameof(restClientFactory));
            if (loggingService == null) throw new ArgumentNullException(nameof(loggingService));
            _restClientFactory = restClientFactory;
            _loggingService = loggingService;
        }

        public void Run()
        {
            var restClient = _restClientFactory.Create();

            _loggingService.Log($"RestClientFactory.Create() returned Uri: {restClient.BaseUrl.AbsoluteUri}");
        }
    }
}