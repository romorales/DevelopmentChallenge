using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    internal class Trapecio : FormaGeometrica
    {
        public Trapecio(decimal ancho) : base(ancho)
        {
            Tipo = Enum.TipoFormaGeometrica.Trapecio;
        }

        public override decimal CalcularArea()
        {
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        }

        public override decimal CalcularPerimetro()
        {
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        }
    }
}
