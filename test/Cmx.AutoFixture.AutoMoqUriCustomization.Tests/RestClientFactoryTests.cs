using Cmx.AutoFixture.AutoMoqUriCustomization.Console;
using Shouldly;
using Xunit;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Tests
{
    public class RestClientFactoryTests
    {
        [Theory, AutoMoqUriData]
        public void Create_ShouldReturnCorrectResult(RestClientFactory sut)
        {
            // act..
            var actual = sut.Create();

            // assert..
            actual.BaseUrl.AbsoluteUri.ShouldBe("http://server.com/");
        }
    }
}