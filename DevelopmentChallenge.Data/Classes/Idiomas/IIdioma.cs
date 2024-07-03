using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public interface IIdioma
    {
        string TituloListaVacia {  get; }
        string TituloHayFormas { get; }
        string Formas { get; }
        string Area { get; }
        string Perimetro { get; }
        string CuadradoSingular { get; }
        string CuadradoPlural { get; }
        string TrianguloSingular { get; }
        string TrianguloPlural { get; }
        string CirculoSingular { get; }
        string CirculoPlural { get; }
        string TrapecioSingular { get; }
        string TrapeciosPlural { get; }
    }
}
