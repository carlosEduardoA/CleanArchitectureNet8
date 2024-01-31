using CleaArchitecture.Domain.Abstractions;

namespace CleaArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerRechazadoDomainEvent(Guid Id) : IDomainEvent;