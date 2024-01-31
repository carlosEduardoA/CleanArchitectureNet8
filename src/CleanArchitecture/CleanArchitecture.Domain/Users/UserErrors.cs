
using CleaArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Users
{
    public static class UserErrors
    {
        public static Error NotFound = new(
            "User.Found",
            "El usuario con el Id especificado no fue encontrado"
        );

        public static Error InvalidCredentials = new(
            "User.InvalidCredentials",
            "Las credenciales son incorrectas"
        );
    }
}
