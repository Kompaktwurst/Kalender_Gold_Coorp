using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kalender_Gold_Coorp
{
    public partial class Administration : Form
    {
        int mov, movX, movy;
        private List<DateTime> Eventtage;
        private List<string> EventtageName;
        Verwaltung_ verwaltung;
        public Administration(Verwaltung_ verwaltung_)
        {
         
            InitializeComponent();  
            Eventtage = new List<DateTime>();
            EventtageName = new List<string>();
            verwaltung = verwaltung_;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        } //Mitarbeiter Auswahl

        private void Urlaub_Anzeige_Btn_Click(object sender, EventArgs e)
        {

        } //Urlaubstage des Ausgewählten Mitarbeiters anzeigen

        private void Krankheit_anzeigen_Btn_Click(object sender, EventArgs e)
        {

        } //Krankheitstage des Ausgewählten Mitarbeiters anzeigen

        private void Passwort_ändern_Btn_Click(object sender, EventArgs e)
        {

        }   //Passwort des Ausgewählten Mitarbeiters ändern

        private void Events_Complete_clear()
        {
            Eventtage.Clear();
            EventtageName.Clear();
        }                           //Events Löschen

        private void Beenden_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Event_Erstellen_Button_Click(object sender, EventArgs e)
        {
            string Eventname = textBox1.Text;
            DateTime test = dateTimePicker1.Value;
            MessageBox.Show("" + Eventname + ": " + test);
            Eventtage.Add(test);
            if (textBox1.Text != "Eventname")
            {
                EventtageName.Add(Eventname);
            }
            else
            {
                EventtageName.Add("unbenanntes Event");
            }
        }

        private void Verwalten_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wirklich alle Events löschen?",
                      "Events_Löschen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Events_Complete_clear();
            }
            else { }
            return;
        }

        private void Postfach_Button_Click(object sender, EventArgs e)
        {

        }
        private void panel32_MouseMove(object sender, MouseEventArgs e) //Move ermöglichen
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movy);
            }
        }

        private void panel32_MouseDown(object sender, MouseEventArgs e) //Move ermöglichen
        {
            mov = 1;
            movX = e.X;
            movy = e.Y;
        }

        private void panel32_MouseUp(object sender, MouseEventArgs e) //Move ermöglichen
        {
            mov = 0;
        }
    }
}
