using CleaArchitecture.Domain.Abstractions;

namespace CleaArchitecture.Domain.Alquileres.Events;


public sealed record AlquilerCompletadoDomainEvent(Guid AlquilerId) : IDomainEvent;