using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAB__Cognitive_Amplitude_Battery
{
    public class Class_DigitSpan
    {
        private readonly Random rng = new Random();
        private readonly string audioPfad;                     // Fester Pfad zu /Assets/Audio
        private Dictionary<int, SoundPlayer> audioFiles;       // Cache für Audio
        private int[] aktuelleSequenz;                         // Aktuelle Zahlensequenz

        public int rohpunkte { get; private set; }             // Gesamte Rohpunkte

        public Class_DigitSpan()
        {
            // AUDIOPFAD FEST VERDRAHTET
            audioPfad = Path.Combine(Application.StartupPath, "Assets", "Audio");

            LadeAudio();
        }

        // Audio-Dateien 1.wav - 9.wav laden
        private void LadeAudio()
        {
            audioFiles = new Dictionary<int, SoundPlayer>();

            for (int i = 1; i <= 9; i++)
            {
                string datei = Path.Combine(audioPfad, i + ".wav");
                if (!File.Exists(datei))
                    MessageBox.Show($"Datei nicht gefunden: {datei}");
            }

        }

        // Neue Sequenz erzeugen
        public void GeneriereNeueSequenz(int länge)
        {
            aktuelleSequenz = new int[länge];

            for (int i = 0; i < länge; i++)
            {
                aktuelleSequenz[i] = rng.Next(1, 10); // 1–9
            }
        }

        // Sequenz abspielen
        public async Task SpieleSequenzAbAsync()
        {
            foreach (int zahl in aktuelleSequenz)
            {
                if (audioFiles.ContainsKey(zahl))
                {
                    audioFiles[zahl].Play();
                    await Task.Delay(1000); // 1 Sekunde zwischen den Zahlen
                }
            }
        }

        // Prüfen der Eingabe
        public bool PruefeEingabe(int[] eingabe)
        {
            if (eingabe.Length != aktuelleSequenz.Length)
                return false;

            for (int i = 0; i < eingabe.Length; i++)
            {
                if (eingabe[i] != aktuelleSequenz[i])
                    return false;
            }

            rohpunkte++;   // Richtige Sequenz = 1 Rohpunkt
            return true;
        }
    }
}
