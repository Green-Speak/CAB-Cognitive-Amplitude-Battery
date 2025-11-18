// SymbolenSuche.cs
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CAB__Cognitive_Amplitude_Battery
{
    public partial class SymbolenSuche : Form
    {
        private Class_SymbolenSuche logik = new Class_SymbolenSuche();
        private string zielSymbol;
        private string linksSymbol;
        private string rechtsSymbol;
        public string Ordnerpfad = Path.Combine(Application.StartupPath,"Assets", "Symbole");
        private Timer timer;

        public SymbolenSuche()
        {
            InitializeComponent();

            Suche_Nach.SizeMode = PictureBoxSizeMode.Zoom;
            Symbol_Links.SizeMode = PictureBoxSizeMode.Zoom;
            Symbol_Rechts.SizeMode = PictureBoxSizeMode.Zoom;

            timer = new Timer();
            timer.Interval = 120000; // 2 Minuten 120000; 120 zum Testen
            timer.Tick += Timer_Tick;
        }

        private void SymbolenSuche_Load(object sender, EventArgs e)
        {
            if (!logik.Ladesymbole(Ordnerpfad))
            {
                MessageBox.Show("Ordner 'Symbole' nicht gefunden!");
                Close();
                return;
            }

            LadeNeuenVersuch();
            timer.Start();
        }

        private void LadeNeuenVersuch()
        {
            zielSymbol = logik.LadeZielSymbol();
            Suche_Nach.Image = logik.HoleImage(zielSymbol);

            Random rng = new Random();
            int pos = rng.Next(3);

            if (pos == 0)
            {
                linksSymbol = zielSymbol;
                rechtsSymbol = logik.LadeZufallssymbolAußer(zielSymbol);
            }
            else if (pos == 1)
            {
                rechtsSymbol = zielSymbol;
                linksSymbol = logik.LadeZufallssymbolAußer(zielSymbol);
            }
            else
            {
                linksSymbol = logik.LadeZufallssymbolAußer(zielSymbol);
                rechtsSymbol = logik.LadeZufallssymbolAußer(zielSymbol, linksSymbol);
            }

            Symbol_Links.Image = logik.HoleImage(linksSymbol);
            Symbol_Rechts.Image = logik.HoleImage(rechtsSymbol);
        }

        private void Suche_Links_Click(object sender, EventArgs e)
        {
            int ergebnis = logik.PrüfeButton(zielSymbol, linksSymbol);
            logik.rohpunkte = logik.rohpunkte + ergebnis;
            LadeNeuenVersuch();
        }

        private void Suche_Rechts_Click(object sender, EventArgs e)
        {
            int ergebnis = logik.PrüfeButton(zielSymbol, rechtsSymbol);
            logik.rohpunkte = logik.rohpunkte + ergebnis;
            LadeNeuenVersuch();
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            bool vorhanden = false;
            if (zielSymbol == linksSymbol || zielSymbol == rechtsSymbol)
                vorhanden = true;

            int ergebnis;
            if (vorhanden == true)
                ergebnis = -1;
            else
                ergebnis = 1;

            logik.rohpunkte = logik.rohpunkte + ergebnis;
            LadeNeuenVersuch();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            // Rohpunkte anzeigen
            MessageBox.Show(
                $"Rohpunkte: {logik.rohpunkte}",
                "Ergebnis Symbolensuche",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


            // Nächste Test-Form öffnen
            var nächsteForm = new DigitSpan();
            nächsteForm.Show();
            this.Close();
        }

    }
}
