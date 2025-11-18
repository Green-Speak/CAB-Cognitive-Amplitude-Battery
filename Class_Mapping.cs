using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace CAB__Cognitive_Amplitude_Battery
{
    public class Class_Mapping
    {
        private Dictionary<string, Dictionary<int, int>> Mappings;
        public Class_Mapping(string dateipfad)
        {
            if(!File.Exists(dateipfad))
            { MessageBox.Show("Ergebnise könnten nicht ermittelt werden \n" + dateipfad, "Wurde nicht gefunden"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mappings = new Dictionary<string, Dictionary<int, int>>();
                return;
            }
            string json = File.ReadAllText(dateipfad);
            var mapping = JsonSerializer.Deserialize<Dictionary<string, Dictionary<int, int>>>(json);
            if(mapping==null)
            {
                MessageBox.Show("Fehler mit Mapping Datei\n","Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mappings = new Dictionary<string, Dictionary<int, int>>();
                return;
            }
            Mappings = mapping;

        }
        public int Mappe(string subtestName,int rohpunkte)
        {
            if(!Mappings.TryGetValue(subtestName, out var mapping))
            {
                MessageBox.Show("Subtest nicht im Mapping gefunden","Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return -1;

            }
            if(!mapping.TryGetValue(rohpunkte,out var wertpunkt))
            {
                MessageBox.Show("Wertpunke nicht im Mapping gefunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return wertpunkt;
        }
     }
    
}
