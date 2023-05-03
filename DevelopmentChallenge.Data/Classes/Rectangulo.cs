using DevelopmentChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public Rectangulo(decimal ancho) : base(ancho)
        {
            Tipo = Enum.TipoFormaGeometrica.Rectangulo;
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
