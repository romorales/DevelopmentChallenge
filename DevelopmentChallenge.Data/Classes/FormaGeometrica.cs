using DevelopmentChallenge.Data.Enum;
namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica: IFormaGeometrica
    {
        public decimal _lado { get; set; }
        public TipoFormaGeometrica Tipo { get; set; }

        public FormaGeometrica(decimal ancho) { 
            _lado = ancho; 
        }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

    }
}
