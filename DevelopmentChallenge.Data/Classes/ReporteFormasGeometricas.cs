using DevelopmentChallenge.Data.Classes.FormasGeometricas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReporteFormasGeometricas
    {
        private readonly IIdioma _idioma;
        public List<IFormaGeometrica> FormasGeometricas;

        public ReporteFormasGeometricas(IIdioma idioma)
        {
            FormasGeometricas = new List<IFormaGeometrica>();
            _idioma = idioma;
        }

        public string Imprimir()
        {
            var sb = new StringBuilder();

            if (!FormasGeometricas.Any())
            {
                sb.Append(_idioma.TituloListaVacia);
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(_idioma.TituloHayFormas);

                // BODY
                var formasSumarizadas = FormasGeometricas.GroupBy(f => f.GetType()).
                    Select(g => new {
                        Forma = g.Count() == 1 ? g.First().ObtenerNombreSingular(_idioma) : g.First().ObtenerNombrePlural(_idioma),
                        Cantidad = g.Count(),
                        Perimetro = g.Sum(f => f.CalcularPerimetro()),
                        Area = g.Sum(f => f.CalcularArea())
                    })
                    .ToList();

                foreach (var item in formasSumarizadas)
                {
                    sb.Append($"{item.Cantidad} {item.Forma} | {_idioma.Area} {item.Area:#.##} | {_idioma.Perimetro} {item.Perimetro:#.##} <br/>");
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                var cantidadTotal = formasSumarizadas.Sum(fs => fs.Cantidad);
                var perimetroTotal = formasSumarizadas.Sum(fs => fs.Perimetro);
                var areaTotal = formasSumarizadas.Sum(fs => fs.Area);
                sb.Append($"{cantidadTotal} {_idioma.Formas.ToLower()} ");
                sb.Append($"{_idioma.Perimetro} {perimetroTotal:#.##} ");
                sb.Append($"{_idioma.Area} {areaTotal:#.##}");
            }

            return sb.ToString();
        }
    }
}
