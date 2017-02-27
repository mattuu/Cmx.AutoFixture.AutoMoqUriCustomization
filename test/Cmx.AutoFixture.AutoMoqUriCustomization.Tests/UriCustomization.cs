using System;
using Ploeh.AutoFixture;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Tests
{
    public class UriCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<Uri>(cc => cc.FromFactory(() => new Uri("http://server.com")));
        }
    }
}