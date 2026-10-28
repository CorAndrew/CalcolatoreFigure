using System;

namespace CalcolatoreFigure
{
    public class Quadrato : Rettangolo
    {
        public Quadrato(string nome, float lato) : base(nome, lato, lato)
        {
        }

        public override string Descrizione()
        {
            return "Area: " + Area() + " | Perimetro: " + Perimetro();
        }
    }
}