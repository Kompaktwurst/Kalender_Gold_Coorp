using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kalender_Gold_Coorp
{
    public partial class Krankheitstage : Form
    {
        Konto k1;
        bool Selected = false;
        List<DateTime> Krankheitstage_Liste;
        public Krankheitstage(Konto k1_)
        {
            k1 = k1_;
            InitializeComponent();
            Krankheitstage_Liste = new List<DateTime>();
            Krankheitstage_Laden();
        }
        private void Krankheitstage_Laden()
        {
            Krankheitstage_Liste = k1.GetKrankheitstage();
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    listBox1.Items.Add(Krankheitstage_Liste[i].ToShortDateString());
                }
                catch (Exception) { }
            }

        }
        private void Löschen_Click(object sender, EventArgs e)
        {
            if (Selected == true)
            {
                string temp = SelectedDatum.Text;
                int day = Convert.ToInt32(temp[0] + "" + temp[1]);
                int month = Convert.ToInt32(temp[3] + "" + temp[4]);
                int year = Convert.ToInt32(temp[6] + "" + temp[7] + "" + temp[8] + "" + temp[9]);
                DateTime temp1 = new DateTime(year, month, day);

                if (temp1.CompareTo(DateTime.Today) == 1)
                {

                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    Krankheitstage_Liste.Remove(temp1);
                    SelectedDatum.Text = "";
                    Selected = false;
                }
                else
                {
                    if (temp1.CompareTo(DateTime.Today) == 0)
                    {
                        MessageBox.Show("Man kann den Krankheitstag von heute nicht zurückziehen");
                    }
                    else
                    {
                        MessageBox.Show("Man kann den Krankheitstag der bereits verstrichen ist nicht zurückziehen");
                    }

                }
            }
            else
            {
                MessageBox.Show("Kein Tag ausgewählt");

            }

        } //Ausgewählten Tag Löschen
        private void Krankheitstage_FormClosing(object sender, FormClosingEventArgs e)
        {
            k1.SetKrankheitstage(Krankheitstage_Liste);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedDatum.Text = listBox1.SelectedItem.ToString();
                Selected = true;
            }
            catch (Exception)
            {

            }
        }
    }
}
