using System;

namespace CalcolatoreFigure
{
    public class Cerchio : Figura
    {
        public float Raggio { get; set; }

        public Cerchio(string nome, float raggio) : base(nome)
        {
            Raggio = raggio;
        }

        public override double Area()
        {
            return 3.14 * Raggio * Raggio;
        }

        public override double Perimetro()
        {
            return 2 * 3.14 * Raggio;
        }

        public override string Descrizione()
        {
            return "Area: " + Area() + " | Perimetro: " + Perimetro();
        }
    }
}