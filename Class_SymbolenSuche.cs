// Class_SymbolenSuche.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;

namespace CAB__Cognitive_Amplitude_Battery
{
    public class Class_SymbolenSuche
    {
        private Random rng = new Random();
        private List<string> symbolDateien;
        private Dictionary<string, Image> symbolImages;

        public int rohpunkte { get; set; }

        // Symbole laden und im Speicher halten
        public bool Ladesymbole(string ordnerpfad)
        {
            if (!Directory.Exists(ordnerpfad))
                return false;

            symbolDateien = Directory.GetFiles(ordnerpfad, "*.png").ToList();
            if (symbolDateien.Count == 0)
                return false;

            symbolImages = new Dictionary<string, Image>();
            foreach (var file in symbolDateien)
            {
                symbolImages[file] = Image.FromFile(file);
            }
            return true;
        }

        // Zufällig ein Symbol auswählen
        public string LadeZielSymbol()
        {
            return symbolDateien[rng.Next(symbolDateien.Count)];
        }

        // Zufallssymbol auswählen, ausgeschlossene Symbole optional
        public string LadeZufallssymbolAußer(params string[] ausgeschlossen)
        {
            var möglich = symbolDateien.Where(s => !ausgeschlossen.Contains(s)).ToList();
            if (möglich.Count == 0)
                return symbolDateien[0]; // Fallback
            return möglich[rng.Next(möglich.Count)];
        }

        // Image aus Dictionary zurückgeben
        public Image HoleImage(string symbolDatei)
        {
            if (symbolImages.ContainsKey(symbolDatei))
                return symbolImages[symbolDatei];
            return null;
        }

        // Prüfen, ob Button richtig gedrückt
        public int PrüfeButton(string zielsymbol, string nutzersymbol)
        {
            if (zielsymbol == nutzersymbol)
                return 1;
            else
                return -1;
        }
    }
}
