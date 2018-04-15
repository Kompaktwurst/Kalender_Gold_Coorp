using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kalender_Gold_Coorp
{
    public partial class Profil_Bearbeitung : Form
    {   Konto k1;
        int mov, movX, movy;
        public Profil_Bearbeitung(Konto k1_)
        {
            InitializeComponent();
            k1 = k1_;
            Init();
            if(k1.GetStatus()!="")
            textBox1.Text = k1.GetStatus();
        }
        private void Init()
        {
            label5.Text = k1.GetBenutzername();
            label7.Text = k1.GetAbteilung();
            label8.Text = k1.GetBeruf();
            Name_überschrift_Label.Text = k1.GetBenutzername() + "´s Profil";
            pictureBox1.Image = k1.GetProfilbild();
        }
       

      

        private void Avatare_Close(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = k1.GetProfilbild();
           
        }

        private void Avatar_Button_Click(object sender, EventArgs e)
        {
            Avatare c = new Avatare(k1);

            c.FormClosed += Avatare_Close;

            c.ShowDialog();
        }

        private void Daten_Button_Click(object sender, EventArgs e)
        {

        }

        private void Status_Button_Click(object sender, EventArgs e)
        {
            k1.SetStatus(textBox1.Text);
        }

        private void Beenden_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                k1.SetStatus(textBox1.Text);
            }
        }
        private void panel_MouseMove(object sender, MouseEventArgs e) //Move ermöglichen
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movy);
            }
        }
        private void panel_MouseDown(object sender, MouseEventArgs e) //Move ermöglichen
        {
            mov = 1;
            movX = e.X;
            movy = e.Y;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e) //Move ermöglichen
        {
            mov = 0;
        }
    }
}
