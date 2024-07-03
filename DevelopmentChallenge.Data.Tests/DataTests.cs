using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.FormasGeometricas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var reporte = new ReporteFormasGeometricas(new Castellano());

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                reporte.Imprimir());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var reporte = new ReporteFormasGeometricas(new Ingles());

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                reporte.Imprimir());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            var reporte = new ReporteFormasGeometricas(new Italiano());

            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                reporte.Imprimir());
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var reporte = new ReporteFormasGeometricas(new Castellano());
            reporte.FormasGeometricas.Add(new Cuadrado(5));

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var reporte = new ReporteFormasGeometricas(new Ingles());
            reporte.FormasGeometricas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = reporte.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var reporte = new ReporteFormasGeometricas(new Ingles());

            reporte.FormasGeometricas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = reporte.Imprimir();

            Assert.AreEqual(
                $"<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area {13.01} | Perimeter {18.06} <br/>3 Triangles | Area {49.64} | Perimeter {51.6} <br/>TOTAL:<br/>7 shapes Perimeter {97.66} Area {91.65}",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var reporte = new ReporteFormasGeometricas(new Castellano());

            reporte.FormasGeometricas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = reporte.Imprimir();

            Assert.AreEqual(
                $"<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area {13.01} | Perimetro {18.06} <br/>3 Triángulos | Area {49.64} | Perimetro {51.6} <br/>TOTAL:<br/>7 formas Perimetro {97.66} Area {91.65}",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var reporte = new ReporteFormasGeometricas(new Italiano());

            reporte.FormasGeometricas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = reporte.Imprimir();

            Assert.AreEqual(
                $"<h1>Elenco di Forme</h1>2 Cuadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area {13.01} | Perimetro {18.06} <br/>3 Triangoli | Area {49.64} | Perimetro {51.6} <br/>TOTAL:<br/>7 forme Perimetro {97.66} Area {91.65}",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapeciosEnItaliano()
        {
            var reporte = new ReporteFormasGeometricas(new Italiano());

            reporte.FormasGeometricas = new List<IFormaGeometrica>
            {
                new Cuadrado(3),
                new TrapecioRectangulo(9, 6, 4, 5),
                new TrapecioRectangulo(20, 14, 8, 10)
            };

            var resumen = reporte.Imprimir();

            Assert.AreEqual($"<h1>Elenco di Forme</h1>1 Cuadrato | Area {9} | Perimetro {12} <br/>2 Trapezi | Area {166} | Perimetro {76} <br/>TOTAL:<br/>3 forme Perimetro {88} Area {175}", resumen);
        }

        [TestCase]
        public void TestAreaCuadrado()
        {
            var cuadrado = new Cuadrado(5);
            var area = cuadrado.CalcularArea();
            Assert.AreEqual(25, area);
        }

        [TestCase]
        public void TestAreaCirculo()
        {
            var circulo = new Circulo(6);
            var area = circulo.CalcularArea();
            Assert.AreEqual(28.27, Math.Round(area, 2));
        }

        [TestCase]
        public void TestAreaTrapecioRectangulo()
        {
            var trapecioRectangulo = new TrapecioRectangulo(9, 6, 4, 5);
            var area = trapecioRectangulo.CalcularArea();
            Assert.AreEqual(30, area);
        }

        [TestCase]
        public void TestAreaTrianguloEquilatero()
        {
            var triangulo = new TrianguloEquilatero(4);
            var area = triangulo.CalcularArea();
            Assert.AreEqual(6.93, Math.Round(area, 2));
        }

        [TestCase]
        public void TestPerimetroCuadrado()
        {
            var cuadrado = new Cuadrado(5);
            var perimetro = cuadrado.CalcularPerimetro();
            Assert.AreEqual(20, perimetro);
        }

        [TestCase]
        public void TestPerimetroCirculo()
        {
            var circulo = new Circulo(6);
            var perimetro = circulo.CalcularPerimetro();
            Assert.AreEqual(18.85, Math.Round(perimetro, 2));
        }

        [TestCase]
        public void TestPerimetroTrapecioRectangulo()
        {
            var trapecio = new TrapecioRectangulo(9, 6, 4, 5);
            var perimetro = trapecio.CalcularPerimetro();
            Assert.AreEqual(24, perimetro);
        }

        [TestCase]
        public void TestPerimetroTrianguloEquilatero()
        {
            var triangulo = new TrianguloEquilatero(4);
            var perimetro = triangulo.CalcularPerimetro();
            Assert.AreEqual(12, perimetro);
        }
    }
}
