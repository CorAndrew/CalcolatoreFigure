using System;

namespace CalcolatoreFigure
{
    public class Rettangolo : Figura
    {
        public float Base { get; set; }
        public float Altezza { get; set; }

        public Rettangolo(string nome, float baseRettangolo, float altezza) : base(nome)
        {
            Base = baseRettangolo;
            Altezza = altezza;
        }

        public override double Area()
        {
            return Base * Altezza;
        }

        public override double Perimetro()
        {
            return (Base + Altezza) * 2;
        }

        public override string Descrizione()
        {
            return "Area: " + Area() + " | Perimetro: " + Perimetro();
        }
    }
}