using System;
using System.Windows.Forms;

namespace Kalender_Gold_Coorp
{
    public partial class Avatare : Form
    {
        Konto k1;
        public Avatare(Konto k1_)
        {
            InitializeComponent();
            k1 = k1_;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //avatar
             k1.SetProfilbild((sender as PictureBox).Image);
            Close();
        }
    }
}
