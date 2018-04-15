using System;
using System.Windows.Forms;

namespace Kalender_Gold_Coorp
{
    public partial class Registrierung : Form
    {
        Konto k1;
        KontoSpeicher k2;
        public Registrierung(Konto k1_, KontoSpeicher k2_)
        {
            InitializeComponent();
            k1 = k1_;
            k2 = k2_;
            label4.Text = k1.GetBenutzername();
        }

        private void button1_Click(object sender, EventArgs e) //OK click
        {
            k1.SetGeburtstag(textBox1.Text);
            k1.SetAbteilung(textBox2.Text);
            k1.SetBeruf(textBox3.Text);
            k2.AddKonto(k1);
            Close();
        }
    }
}
