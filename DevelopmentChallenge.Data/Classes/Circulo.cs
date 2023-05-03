﻿using DevelopmentChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal ancho) : base(ancho)
        {
            Tipo = Enum.TipoFormaGeometrica.Circulo;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
