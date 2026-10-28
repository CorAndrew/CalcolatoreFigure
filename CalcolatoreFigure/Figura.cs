using System;

namespace CalcolatoreFigure
{
    public abstract class Figura
    {
        public string Nome { get; set; }

        public Figura(string nome)
        {
            Nome = nome;
        }

        public abstract double Area();
        public abstract double Perimetro();

        public virtual string Descrizione()
        {
            return "Figura: " + Nome;
        }
    }
}