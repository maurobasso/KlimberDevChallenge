using DevelopmentChallenge.Data.Classes.Idiomas;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class TrapecioRectangulo : IFormaGeometrica
    {
        private decimal _baseMayor;
        private decimal _baseMenor;
        private decimal _altura;
        private decimal _cateto;

        public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura, decimal cateto)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _cateto = cateto;
        }

        public decimal CalcularArea()
        {
            return _altura * ((_baseMayor + _baseMenor) / 2);
        }

        public decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _altura + _cateto;
        }

        public string ObtenerNombrePlural(IIdioma idioma)
        {
            return idioma.TrapeciosPlural;
        }

        public string ObtenerNombreSingular(IIdioma idioma)
        {
            return idioma.TrapecioSingular;
        }
    }
}
