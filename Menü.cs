using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAB__Cognitive_Amplitude_Battery
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }
        
        
        SymbolenSuche symbolenSuche = new SymbolenSuche();
        private void menu_Start_Click(object sender, EventArgs e)
        {
            
            symbolenSuche.Show();
            this.Hide();
            
        }
    }
}
