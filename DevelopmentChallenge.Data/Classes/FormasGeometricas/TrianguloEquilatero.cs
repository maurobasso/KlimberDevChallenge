using DevelopmentChallenge.Data.Classes.Idiomas;
using System;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public string ObtenerNombrePlural(IIdioma idioma)
        {
            return idioma.TrianguloPlural;
        }

        public string ObtenerNombreSingular(IIdioma idioma)
        {
            return idioma.TrianguloSingular;
        }
    }
}
