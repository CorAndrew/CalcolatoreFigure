using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace CalcolatoreFigure
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CmbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LblMisura1 == null || LblMisura2 == null || TxtMisura2 == null)
            {
                return;
            }

            int indice = CmbFigura.SelectedIndex;

            if (indice == 0) // Rettangolo
            {
                LblMisura1.Text = "Base:";
                LblMisura2.Text = "Altezza:";
                LblMisura2.IsVisible = true;
                TxtMisura2.IsVisible = true;
            }
            else if (indice == 1) // Quadrato
            {
                LblMisura1.Text = "Lato:";
                LblMisura2.IsVisible = false;
                TxtMisura2.IsVisible = false;
            }
            else if (indice == 2) // Cerchio
            {
                LblMisura1.Text = "Raggio:";
                LblMisura2.IsVisible = false;
                TxtMisura2.IsVisible = false;
            }
        }

        public void BtnCalcola_Click(object sender, RoutedEventArgs e)
        {
            int indice = CmbFigura.SelectedIndex;
            float misura1;
            float misura2 = 0f;

            if (!float.TryParse(TxtMisura1.Text, out misura1) || misura1 <= 0)
            {
                TxtRisultato.Text = "Errore: Inserisci un valore numerico valido e maggiore di zero";
                return;
            }

            if (indice == 0)
            {
                if (!float.TryParse(TxtMisura2.Text, out misura2) || misura2 <= 0)
                {
                    TxtRisultato.Text = "Errore: Inserisci un valore numerico valido per l'altezza";
                    return;
                }
            }

            Figura figuraScelta = null;

            if (indice == 0)
            {
                figuraScelta = new Rettangolo("Rettangolo1", misura1, misura2);
            }
            else if (indice == 1)
            {
                figuraScelta = new Quadrato("Quadrato1", misura1);
            }
            else if (indice == 2)
            {
                figuraScelta = new Cerchio("Cerchio1", misura1);
            }

            if (figuraScelta != null)
            {
                TxtRisultato.Text = figuraScelta.Descrizione();
            }
        }
    }
}