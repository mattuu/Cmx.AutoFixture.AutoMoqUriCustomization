using Cmx.AutoFixture.AutoMoqUriCustomization.Console;
using Moq;
using Ploeh.AutoFixture.Idioms;
using Ploeh.AutoFixture.Xunit2;
using RestSharp;
using Xunit;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Tests
{
    public class ServiceTests
    {
        [Theory, AutoMoqData]
        public void Ctor_ShouldThrowExceptionOnAnyDependencyNull(GuardClauseAssertion assertion)
        {
            assertion.Verify(typeof(Service).GetConstructors());
        }

        [Theory, AutoMoqData]
        public void Run_ShouldCall_Create_On_IRestClientFactory([Frozen] Mock<IRestClientFactory> restClientFactoryMock,
            Service sut)
        {
            // act..
            sut.Run();

            // assert..
            restClientFactoryMock.Verify(m => m.Create(), Times.Once());
        }

        [Theory, AutoMoqData]
        public void Run_ShouldCall_Log_On_ILoggingService_WithCorrectArgs([Frozen] Mock<IRestClientFactory> restClientFactoryMock,
            [Frozen] Mock<ILoggingService> loggingServiceMock,
            IRestClient restClient,
           Service sut)
        {
            // arrange..
            restClientFactoryMock.Setup(m => m.Create()).Returns(restClient);        

            // act..
            sut.Run();

            // assert..
            loggingServiceMock.Verify(m => m.Log(It.Is<string>(s => s == $"RestClientFactory.Create() returned Uri: {restClient.BaseUrl.AbsoluteUri}")), Times.Once());
        }
    }
}