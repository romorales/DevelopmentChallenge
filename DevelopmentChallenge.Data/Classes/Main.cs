using DevelopmentChallenge.Data.Enum;
using DevelopmentChallenge.Data.Resources;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

namespace DevelopmentChallenge.Data.Classes
{
    public class Main
    {
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            string idiomaCulture = IdiomasEnum.GetString(idioma);

            Thread.CurrentThread.CurrentCulture = new CultureInfo(idiomaCulture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idiomaCulture);

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append("<h1>" + Diccionario.EmptyList + "</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append("<h1>" + Diccionario.ShapesReport +"</h1>");

                FormasGeometricasPorTipo listasCuadrados = new FormasGeometricasPorTipo(formas, TipoFormaGeometrica.Cuadrado);
                FormasGeometricasPorTipo listaCirculos = new FormasGeometricasPorTipo(formas, TipoFormaGeometrica.Circulo);
                FormasGeometricasPorTipo listaTriangulos = new FormasGeometricasPorTipo(formas, TipoFormaGeometrica.TrianguloEquilatero);
                FormasGeometricasPorTipo listaTrapecios = new FormasGeometricasPorTipo(formas, TipoFormaGeometrica.Trapecio);
                FormasGeometricasPorTipo listaRectangulos = new FormasGeometricasPorTipo(formas, TipoFormaGeometrica.Rectangulo);


                sb.Append(listasCuadrados.ObtenerLinea());
                sb.Append(listaCirculos.ObtenerLinea());
                sb.Append(listaTriangulos.ObtenerLinea());
                sb.Append(listaTrapecios.ObtenerLinea());
                sb.Append(listaRectangulos.ObtenerLinea());

                var totalPerimetro = 0m;
                formas.ForEach(c => { totalPerimetro += c.CalcularPerimetro(); });

                var totalArea = 0m;
                formas.ForEach(c => { totalArea += c.CalcularArea(); });

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(formas.Count() + " " + Diccionario.Shapes + " ");
                sb.Append(Diccionario.Perimeter + " " + (totalPerimetro).ToString("#.##") + " ");
                sb.Append(Diccionario.Area + " " + (totalArea).ToString("#.##"));
            }

            return sb.ToString();
        }
      
    }
}
