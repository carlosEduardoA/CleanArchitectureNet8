using CleaArchitecture.Domain.Abstractions;
using MediatR;

namespace CleaArchitecture.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>, IBaseCommand
{

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{

}

public interface IBaseCommand
{}