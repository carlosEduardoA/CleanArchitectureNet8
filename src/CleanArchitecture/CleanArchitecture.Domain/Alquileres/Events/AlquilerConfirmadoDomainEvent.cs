using CleaArchitecture.Domain.Abstractions;

namespace CleaArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerConfirmadoDomainEvent(Guid AlquilerId) : IDomainEvent;