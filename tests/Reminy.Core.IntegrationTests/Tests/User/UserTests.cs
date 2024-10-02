﻿using AutoFixture;
using NUnit.Framework;
using Reminy.Core.Host.Contracts;

namespace Reminy.Core.IntegrationTests.Tests.User;

public sealed class UserTests
{
    private IFixture Fixture { get; } = new Fixture();

    [Test]
    public async Task RegisterValidUserTest()
    {
        var request = new RegisterUserRequestDto
        {
            Email = Fixture.Create<string>(),
            FirstName = Fixture.Create<string>(),
            LastName = Fixture.Create<string>(),
            Password = Fixture.Create<string>()
        };

        await SetUpGlobal.Client.RegisterUser(request);
    }
}