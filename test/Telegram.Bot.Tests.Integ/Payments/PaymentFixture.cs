﻿using System;
using Telegram.Bot.Tests.Integ.Framework;
using Telegram.Bot.Tests.Integ.Framework.Fixtures;

namespace Telegram.Bot.Tests.Integ.Payments
{
    public class PaymentFixture : PrivateChatFixture
    {
        public string PaymentProviderToken { get; }

        public PaymentFixture(TestsFixture testsFixture)
            : base(testsFixture, Constants.TestCollections.Payment)
        {
            PaymentProviderToken = ConfigurationProvider.TestConfigurations.PaymentProviderToken;
            if (PaymentProviderToken is default)
            {
                throw new ArgumentNullException(nameof(PaymentProviderToken), "Payment provider token is not set");
            }
            else if (PaymentProviderToken.Length < 5)
            {
                throw new ArgumentNullException(nameof(PaymentProviderToken), "Payment provider token is invalid");
            }
        }
    }
}
