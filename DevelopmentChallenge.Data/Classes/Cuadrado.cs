using DevelopmentChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal ancho) : base(ancho)
        {
            Tipo = Enum.TipoFormaGeometrica.Cuadrado;
        }
        //public int Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
