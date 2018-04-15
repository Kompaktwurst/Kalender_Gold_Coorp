using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Kalender_Gold_Coorp
{
    public partial class Verwaltung_ : Form
    {
        KontoSpeicher k1;
        bool a = true;
        int acc;
     
        public Verwaltung_()
        {       
                InitializeComponent();
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                
            if (!File.Exists(GetPath()))
            {
                (new KontoSpeicher()).Leeren(GetPath());
                (new KontoSpeicher()).Speichern(GetPath());
            }
                
            if(a)
            {
                k1 = (new KontoSpeicher()).Laden(GetPath());
                Anmeldung m = new Anmeldung(this);
                m.ShowDialog();
                acc = k1.GetListenLänge();
                a = false;
            }

            

        }
        public Konto GetKonto(int index)
        {
            return k1.GetKonto(index);
        }

        public static string GetPath()
        {
            string path = Directory.GetCurrentDirectory() + @"\KontenTN.txt";
            return path;
        }
        private void Verwaltung__FormClosing(object sender, FormClosingEventArgs e)
        {
            k1.Speichern(GetPath());
        }

        //public void SetEvent(List<DateTime>Eventtag_,List<string> Eventtagname_)
        //{
        //    Eventtage = Eventtag_;
        //    EventtageName = Eventtagname_;
        //}
        //public List<DateTime> GetEventtag() => Eventtage;
        //public List<string> GetEventtagname() => EventtageName;
        
        public KontoSpeicher GetKontoSpeicher() => k1;
        public int GetAccAnzahl() => acc;
    }
}
