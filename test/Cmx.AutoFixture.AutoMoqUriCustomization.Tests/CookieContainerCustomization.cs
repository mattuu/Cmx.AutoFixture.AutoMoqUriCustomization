using System.Net;
using System.Reflection;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Tests
{
    public class CookieContainerCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            //fixture.Customize<CookieContainer>(cc => cc.FromFactory(() => new CookieContainer(1, 1, 10000)));

            fixture.Customizations.Add(new CookieContainerSpecimenBuilder());
        }
    }

    public class CookieContainerSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var pi = request as PropertyInfo;
            if (pi != null && pi.PropertyType == typeof(CookieContainer))
            {
                return new CookieContainer(1, 1, 10000);
            }

            return new NoSpecimen();
        }
    }
}