﻿using MediatR;
using Reminy.Core.DomainServices.User.Commands.Register.Contracts;

namespace Reminy.Core.DomainServices.User.Commands.Register;

internal sealed class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Unit>
{
    public Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        // todo

        return Task.FromResult(Unit.Value);
    }
}