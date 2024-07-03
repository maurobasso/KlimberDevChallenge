using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Italiano : IIdioma
    {
        public string TituloListaVacia => "<h1>Elenco vuoto di forme!</h1>";

        public string TituloHayFormas => "<h1>Elenco di Forme</h1>";

        public string Formas => "Forme";

        public string Area => "Area";

        public string Perimetro => "Perimetro";

        public string CuadradoSingular => "Cuadrato";

        public string CuadradoPlural => "Cuadrati";

        public string TrianguloSingular => "Triangolo";

        public string TrianguloPlural => "Triangoli";

        public string CirculoSingular => "Cerchio";

        public string CirculoPlural => "Cerchi";

        public string TrapecioSingular => "Trapezio";

        public string TrapeciosPlural => "Trapezi";
    }
}
