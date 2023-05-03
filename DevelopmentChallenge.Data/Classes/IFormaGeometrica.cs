using DevelopmentChallenge.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public interface IFormaGeometrica
    {
        decimal _lado { get; set; }

        TipoFormaGeometrica Tipo { get; set; }

        decimal CalcularArea();

        decimal CalcularPerimetro();
    }
}
