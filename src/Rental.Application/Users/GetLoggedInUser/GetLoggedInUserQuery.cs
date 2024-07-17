using Rental.Application.Abstractions.Messaging;

namespace Rental.Application.Users.GetLoggedInUser;
public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;
