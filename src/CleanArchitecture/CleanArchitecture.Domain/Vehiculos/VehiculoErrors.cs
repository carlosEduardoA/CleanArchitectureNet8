using CleaArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Vehiculos
{
    public static class VehiculoErrors
    {
        public static Error NotFound = new(
            "Vehiculo.Found",
            "El vehiculo con el Id especificado no fue encontrado"
        );
    }
}
