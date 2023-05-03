using DevelopmentChallenge.Data.Enum;
using DevelopmentChallenge.Data.Resources;
using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormasGeometricasPorTipo
    {
        List<FormaGeometrica> listaTipoFormaGeotrica = new List<FormaGeometrica>();
        TipoFormaGeometrica tipo;

        public FormasGeometricasPorTipo(List<FormaGeometrica> lista, TipoFormaGeometrica tipo)
        {
           this.tipo = tipo;
           listaTipoFormaGeotrica = lista.FindAll(c => c.Tipo == tipo);
        }

        private int cantidad
        {
            get
            {
                return listaTipoFormaGeotrica.Count();
            }
        }

        private decimal ObtenerTotalArea()
        {
            decimal totalArea = 0;
            listaTipoFormaGeotrica.ForEach(c => { totalArea += c.CalcularArea(); });
            return totalArea;
        }

        private decimal ObtenerTotalPerimetro()
        {
            decimal totalPerimetro = 0;
            listaTipoFormaGeotrica.ForEach(c => { totalPerimetro += c.CalcularPerimetro(); });
            return totalPerimetro;
        }

        public string ObtenerLinea()
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma() } | { Diccionario.Area }  {ObtenerTotalArea():#.##} |  { Diccionario.Perimeter } {ObtenerTotalPerimetro():#.##} <br/>";
            }

            return string.Empty;
        }

        public string TraducirForma()
        {
            switch (tipo)
            {
                case TipoFormaGeometrica.Cuadrado:
                    return cantidad == 1 ? Diccionario.Square : Diccionario.Squares;
                case TipoFormaGeometrica.Circulo:
                    return cantidad == 1 ? Diccionario.Circle : Diccionario.Circles;
                case TipoFormaGeometrica.TrianguloEquilatero:
                    return cantidad == 1 ? Diccionario.Triangle : Diccionario.Triangles;
                case TipoFormaGeometrica.Rectangulo:
                    return cantidad == 1 ? Diccionario.Rectangule : Diccionario.Rectangule;
                case TipoFormaGeometrica.Trapecio:
                    return cantidad == 1 ? Diccionario.Triangle : Diccionario.Triangles;
            }

            return string.Empty;
        }
    }
}
