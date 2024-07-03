using DevelopmentChallenge.Data.Classes.Idiomas;
using System;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _diametro;

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }

        public string ObtenerNombrePlural(IIdioma idioma)
        {
            return idioma.CirculoPlural;
        }

        public string ObtenerNombreSingular(IIdioma idioma)
        {
            return idioma.CirculoSingular;
        }
    }
}
