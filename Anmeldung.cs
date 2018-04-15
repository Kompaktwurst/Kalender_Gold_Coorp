using System;
using System.Windows.Forms;


namespace Kalender_Gold_Coorp
{
    [Serializable]
    public partial class Anmeldung : Form
    {

        int mov, movX, movy;
        KontoSpeicher k2;
        Verwaltung_ verwaltung1;
        public Anmeldung(Verwaltung_ verwaltung)
        {
            verwaltung1 = verwaltung;
            InitializeComponent();
            k2 = verwaltung.GetKontoSpeicher();

        }
        public string GetBenutzername()
        {
            return textBox1.Text;
        }
        public string GetPasswort()
        {
            return textBox2.Text;
        }
        private void Anmelden_button_Click(object sender, EventArgs e)
        {
            Anmelden();
        }
        private void Anmelden()
        {
            bool temp = false;
            for (int i = 0; i < k2.GetListenLänge(); i++)
                if (k2.GetKonto(i).Einloggen(GetBenutzername(), GetPasswort()))
                {
                    Visible = false;
                    ShowInTaskbar = false;
                    temp = true;
                    Kalender n = new Kalender(k2.GetKonto(i),verwaltung1);
                    n.Show();
                }
            if (temp == false) MessageBox.Show("Benutzername oder Passwort Falsch");

        }
        private void Registrieren()
        {
            Konto k1 = new Konto();
            k1.setBenutzername(textBox1.Text);
            k1.setPasswort(textBox2.Text);
            Registrierung v = new Registrierung(k1, k2);
            v.Show();
        }

        private void Registrieren_button_Click(object sender, EventArgs e)
        {
            Registrieren();
        }

        private void Anmeldung_FormClosing(object sender, FormClosingEventArgs e)
        {
            k2.Speichern(Verwaltung_.GetPath());

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Credits c = new Credits();
            c.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void _MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        } //Maus Zeiger änderung
        private void _MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        } //Maus Zeiger änderung

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ihr Passwort wird zu Ihrer Sicherheit mit MD5 gehasht");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                Anmelden();
            }
        }

        private void Information_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programm Version: 1.2.8.0 ");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Registrieren();
        }
        private void panel_MouseMove(object sender, MouseEventArgs e) //Move ermöglichen
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movy);
            }
        }

        private void Beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
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