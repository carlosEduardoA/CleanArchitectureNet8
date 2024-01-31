using CleaArchitecture.Domain.Abstractions;
using MediatR;

namespace CleaArchitecture.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
    
}