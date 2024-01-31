using CleaArchitecture.Domain.Abstractions;
using MediatR;

namespace CleaArchitecture.Application.Abstractions.Messaging;


public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
where TCommand : ICommand
{

}

public interface ICommandHandler<TCommand, TResponse> 
: IRequestHandler<TCommand, Result<TResponse>>
where TCommand : ICommand<TResponse>
{
    
}