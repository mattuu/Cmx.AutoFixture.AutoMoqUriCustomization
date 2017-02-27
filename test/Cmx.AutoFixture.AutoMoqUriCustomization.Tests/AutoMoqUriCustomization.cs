﻿using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Tests
{
    public class AutoMoqUriCustomization : CompositeCustomization
    {
        public AutoMoqUriCustomization()
            : base(new AutoConfiguredMoqCustomization(),
                new UriCustomization(),
                new CookieContainerCustomization())
        {
        }
    }
}