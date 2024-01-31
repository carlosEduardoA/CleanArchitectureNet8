using CleaArchitecture.Domain.Abstractions;

namespace CleaArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerCanceladoDomainEvent(Guid AlquilerId) : IDomainEvent;