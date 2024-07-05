﻿using Rental.Application.Abstractions.Messaging;

namespace Rental.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;