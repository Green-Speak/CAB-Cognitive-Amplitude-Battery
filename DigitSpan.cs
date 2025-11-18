using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAB__Cognitive_Amplitude_Battery
{
    public partial class DigitSpan : Form
    {
        private readonly Random rng = new Random();
        private List<int> currentSequence = new List<int>();

        private int sequenceLength = 2;      // Startlänge
        private int trialCount = 0;          // Durchgänge (Forward oder Backward)
        private int consecutiveWrong = 0;    // Für Discontinue
        private bool isBackwardMode = false; // Forward = false, Backward = true

        private int rohpunkteForward = 0;
        private int rohpunkteBackward = 0;

        public DigitSpan()
        {
            InitializeComponent();

            // Events sauber entkoppeln + neu binden
            btnStart.Click -= btnStart_Click;
            btnStart.Click += btnStart_Click;

            Pruefe_Button.Click -= Pruefe_Button_Click;
            Pruefe_Button.Click += Pruefe_Button_Click;

            // Anfangszustand der UI
            Pruefe_Button.Enabled = false;
            btnStart.Enabled = true;
            DigitSpan_Eingabe.Clear();
            lblInfo.Text = "Drücke Weiter...";

            // Rohpunktelabels verstecken
            Rohpunkte_Forwards.Visible = false;
            Rohpunkte_Backwards.Visible = false;
        }


        // ---------------------------------------------------------------
        // START-BUTTON: Sequenz generieren und vorspielen
        // ---------------------------------------------------------------
        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Pruefe_Button.Enabled = false;
            DigitSpan_Eingabe.Clear();
            currentSequence.Clear();

            try
            {
                // Neue Zufallssequenz erzeugen
                for (int i = 0; i < sequenceLength; i++)
                    currentSequence.Add(rng.Next(1, 10));

                lblInfo.Text = "Spiele Sequenz...";

                // Audio-Sequenz abspielen
                foreach (int num in currentSequence)
                {
                    string audioFilePath = Path.Combine(Application.StartupPath, "Assets","Audio", num + ".wav");
                    if (!File.Exists(audioFilePath))
                    {
                        lblInfo.Text = "Datei nicht gefunden: " + num + ".wav";
                        return;
                    }

                    using (var player = new SoundPlayer(audioFilePath))
                    {
                        player.Load();
                        await Task.Run(() => player.PlaySync());
                    }

                    await Task.Delay(500);
                }

                lblInfo.Text = "Bitte wiederhole:";
                DigitSpan_Eingabe.Focus();
                Pruefe_Button.Enabled = true;
            }
            catch
            {
                lblInfo.Text = "Fehler beim Abspielen!";
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }


        // ---------------------------------------------------------------
        // PRÜFEN-BUTTON: Eingabe prüfen + Forward/Backward + Discontinue
        // ---------------------------------------------------------------
        private void Pruefe_Button_Click(object sender, EventArgs e)
        {
            string answer = new string(DigitSpan_Eingabe.Text.Where(char.IsDigit).ToArray());
            string expected;

            // Forward oder Rückwärts?
            if (isBackwardMode)
            {
                expected = string.Join("", currentSequence.AsEnumerable().Reverse());
            }
            else
            {
                expected = string.Join("", currentSequence);
            }

            bool isCorrect = (answer == expected);

            // Rohpunkte erfassen
            if (isCorrect)
            {
                if (!isBackwardMode)
                    rohpunkteForward++;
                else
                    rohpunkteBackward++;

                consecutiveWrong = 0;
            }
            else
            {
                consecutiveWrong++;
            }

            trialCount++;

            // Nach jedem zweiten Trial die Sequenz verlängern
            if (trialCount % 2 == 0)
            {
                sequenceLength++;
            }

            // -----------------------------------------------------------
            // DISCONTINUE-LOGIK
            // -----------------------------------------------------------
            if (consecutiveWrong >= 2)
            {
                if (!isBackwardMode)
                {
                    // Wechsel in Rückwärts-Modus
                    isBackwardMode = true;
                    consecutiveWrong = 0;
                    sequenceLength = 2;
                    lblInfo.Text = "Rückwärtstest beginnt!";
                    DigitSpan_Eingabe.Clear();
                    Pruefe_Button.Enabled = false;

                    // Rückwärts-Test automatisch starten
                    Task.Run(async () =>
                    {
                        await Task.Delay(2000);
                        Invoke(new Action(() => btnStart_Click(null, null)));
                    });

                    return;
                }
                else
                {
                    // ---------------------------------------------------
                    // END OF SUBTEST → Rohpunkte anzeigen
                    // ---------------------------------------------------
                    Rohpunkte_Forwards.Text = "Forward Rohpunkte: " + rohpunkteForward;
                    Rohpunkte_Backwards.Text = "Backward Rohpunkte: " + rohpunkteBackward;

                    Rohpunkte_Forwards.Visible = true;
                    Rohpunkte_Backwards.Visible = true;

                    lblInfo.Text = "Subtest abgeschlossen!";
                    Pruefe_Button.Enabled = false;
                    btnStart.Enabled = false;
                    return;
                }
            }

            // Nächster Trial
            lblInfo.Text = "Drücke Weiter...";
            Pruefe_Button.Enabled = false;
            btnStart.Enabled = true;
        }

        
    }
}
