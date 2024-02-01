using CleanArchitecture.Application.Abstractions.Data;
using CleanArchitecture.Application.Abstractions.Messaging;
using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Application.Alquileres.GetAlquiler
{
    internal sealed class GetAlquilerQueryHandler : IQueryHandler<GetAlquilerQuery, AlquilerResponse>
    {
        private readonly ISqlConnectionFactory _sqlconnectionFactory;

        public GetAlquilerQueryHandler(ISqlConnectionFactory sqlconnectionFactory)
        {
            _sqlconnectionFactory = sqlconnectionFactory;
        }

        public Task<Result<AlquilerResponse>> Handle(GetAlquilerQuery request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }
    }
}
