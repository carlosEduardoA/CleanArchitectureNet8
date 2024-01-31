using CleaArchitecture.Domain.Abstractions;

namespace CleaArchitecture.Domain.Alquileres.Events;


public sealed record AlquilerReservadoDomainEvent(Guid AlquilerId) : IDomainEvent;