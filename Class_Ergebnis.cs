using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB__Cognitive_Amplitude_Battery
{
    class Ergebnis 
    {
       public string Name { get; set; }
        public Dictionary<string,int>WertpunkteProSubtest { get; set; }
        public Ergebnis(string name)
        {
            Name = name;
            WertpunkteProSubtest = new Dictionary<string, int>();
        }
        public void SetzeWertpunkte(string subtestName, int rohpunktzahl,Dictionary<string,Dictionary<int,int>>mappings) {
            if(mappings.TryGetValue(subtestName, out var mapping))
            {
                if(mapping.TryGetValue(rohpunktzahl, out var wertpunkte)) {
                    WertpunkteProSubtest[subtestName] = wertpunkte;
                }
                else
                {
                    WertpunkteProSubtest[subtestName] = -1; 
                }
            }
            else
            {
                WertpunkteProSubtest[subtestName] = -1; 
            }

        }
        public int BerechneGesamtwertpunkte()
        {
            if (WertpunkteProSubtest.Count == 0)
                return 0;

            return WertpunkteProSubtest.Values.Sum();
        }
    }

    }

