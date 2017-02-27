using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Xunit2;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Tests
{
    public class AutoMoqUriDataAttribute : AutoDataAttribute
    {
        public AutoMoqUriDataAttribute()
            : base(new Fixture().Customize(new AutoMoqUriCustomization()))
        {
        }
    }
}