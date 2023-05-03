using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Enum
{
    public enum TipoFormaGeometrica
    {
        Circulo,
        Cuadrado,
        Rectangulo,
        Trapecio,
        TrianguloEquilatero
    }

    public enum Idioma
    {
        Castellano,
        Ingles,
        Italiano
    }

    public static class IdiomasEnum
    {
        public static string GetString(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "es";
                case Idioma.Ingles:
                    return "en-US";
                case Idioma.Italiano:
                    return "it";
                default:
                    return "en-USN";
            }
        }
    }
}
