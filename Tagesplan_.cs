using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalender_Gold_Coorp
{
    public partial class Tagesplan : Form
    {
        private Konto k1;
        private DateTime Datum;
        private Panel[] _Panels = new Panel[24];
        private Label[] _Labels = new Label[24];
        private List<string[]> Tagesplanliste;
        public Tagesplan(Konto k1_,DateTime Datum_)
        {
            InitializeComponent();
            k1 = k1_;
            Datum = Datum_;
            Auswahldatum.Text = Datum.ToShortDateString();
            Tagesplanliste = new List<string[]>();
            Tagesplanliste = k1.GetTagesplan();
            Form_init();
            Label_reset();
           
        }
        private void Panel_init()
        {
            _Panels[0] = panel1;
            _Panels[1] = panel2;
            _Panels[2] = panel3;
            _Panels[3] = panel4;
            _Panels[4] = panel5;
            _Panels[5] = panel6;
            _Panels[6] = panel7;
            _Panels[7] = panel8;
            _Panels[8] = panel9;
            _Panels[9] = panel10;
            _Panels[10] = panel11;
            _Panels[11] = panel12;
            _Panels[12] = panel13;
            _Panels[13] = panel14;
            _Panels[14] = panel15;
            _Panels[15] = panel16;
            _Panels[16] = panel17;
            _Panels[17] = panel18;
            _Panels[18] = panel19;
            _Panels[19] = panel20;
            _Panels[20] = panel21;
            _Panels[21] = panel22;
            _Panels[22] = panel23;
            _Panels[23] = panel24;


        }
        private void Panel_reset()
        {
            for (int i = 0; i < 24; i++)
            {
                _Panels[i].BackColor = Color.Transparent;

            }
            //Array in denen alle Labels drin sind fertig
            //Labels mit Labelreset ="" fertig
        }
        private void Label_init()
        {
            _Labels[0] = label1;
            _Labels[1] = label2;
            _Labels[2] = label3;
            _Labels[3] = label4;
            _Labels[4] = label5;
            _Labels[5] = label6;
            _Labels[6] = label7;
            _Labels[7] = label8;
            _Labels[8] = label9;
            _Labels[9] = label10;
            _Labels[10] = label11;
            _Labels[11] = label12;
            _Labels[12] = label13;
            _Labels[13] = label14;
            _Labels[14] = label15;
            _Labels[15] = label16;
            _Labels[16] = label17;
            _Labels[17] = label18;
            _Labels[18] = label19;
            _Labels[19] = label20;
            _Labels[20] = label21;
            _Labels[21] = label22;
            _Labels[22] = label23;
            _Labels[23] = label24;
        }
        private void Label_reset()
        {
            for (int i = 0; i < 24; i++)
            {
                _Labels[i].Text = "";
            }
        }
        private void Form_init()
        {
            Panel_init();
            Label_init(); 
        }

        private void Panel_Click(object sender, EventArgs e) //Alle Panels reagieren auf dieses Ereignis
        {
            Panel clickedPanel = sender as Panel;
            clickedPanel.BackColor = Color.DimGray; 
        }

        private void Profil_Bearbeiten_Button_Click(object sender, EventArgs e)
        {

        }

        private void Löschen_Button_Click(object sender, EventArgs e)
        {

        }

        private void Beenden_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Label_reset();
            Panel_reset();
        }
    }
}
