using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public interface IFormaGeometrica
    {
        decimal CalcularArea();

        decimal CalcularPerimetro();

        string ObtenerNombreSingular(IIdioma idioma);

        string ObtenerNombrePlural(IIdioma idioma);
    }
}
