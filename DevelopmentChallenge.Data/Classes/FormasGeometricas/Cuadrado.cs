using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public string ObtenerNombrePlural(IIdioma idioma)
        {
            return idioma.CuadradoPlural;
        }

        public string ObtenerNombreSingular(IIdioma idioma)
        {
            return idioma.CuadradoSingular;
        }
    }
}
