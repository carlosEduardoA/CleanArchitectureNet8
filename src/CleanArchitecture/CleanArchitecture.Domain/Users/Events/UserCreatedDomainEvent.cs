using CleaArchitecture.Domain.Abstractions;

namespace CleaArchitecture.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;