
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Kalender_Gold_Coorp
{

    [Serializable]
    public partial class Kalender : Form
    {
         
        // Farben: Auswahl Blau, Urlaub Grün, Krankheit Rot, Feiertag Gelb,
        private Konto k1;
        Verwaltung_ verwaltung;
        private string s = null;
        private TimeandDate TimeandDate_;
        private int counter = 0;
        private Label[] _Labels = new Label[10];
        private Label[] LabelsKalender = new Label[31];
        private Panel[] _Panels = new Panel[31];
        private List<DateTime> FehltageListe;
        private List<DateTime> KrankheitstageListe;
        private List<DateTime> Feiertage;
        private List<string> FeiertageNamen;
        int mov, movX, movy;
      
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }       //Items für Combobox 
        public Kalender(Konto k1_,Verwaltung_ verwaltung_)
        {
            InitializeComponent();
            TimeandDate_ = new TimeandDate();
            FehltageListe = new List<DateTime>();
            KrankheitstageListe = new List<DateTime>();
            Feiertage = new List<DateTime>();
            FeiertageNamen = new List<string>();
            k1 = k1_;
            verwaltung = verwaltung_;
            Init(); InitFehltage();
            Refresh_Form();
            
        } //Constructor
        private void Init()
        {
            label46.Text = DateTime.Now.ToShortDateString();
            TimeandDate_.SetMyValue(DateTime.Today);
            label35.Text = k1.GetBenutzername();
            comboBox1.Items.Add(new Item("Januar", 1));
            comboBox1.Items.Add(new Item("Februar", 2));
            comboBox1.Items.Add(new Item("März", 3));
            comboBox1.Items.Add(new Item("April", 4));
            comboBox1.Items.Add(new Item("Mai", 5));
            comboBox1.Items.Add(new Item("Juni", 6));
            comboBox1.Items.Add(new Item("Juli", 7));
            comboBox1.Items.Add(new Item("August", 8));
            comboBox1.Items.Add(new Item("September", 9));
            comboBox1.Items.Add(new Item("Oktober", 10));
            comboBox1.Items.Add(new Item("November", 11));
            comboBox1.Items.Add(new Item("Dezember", 12));
            comboBox1.SelectedIndex = DateTime.Today.Month - 1;
            comboBox2.Items.Add(new Item("2018", 2018));
            comboBox2.Items.Add(new Item("2019", 2019));
            comboBox2.Items.Add(new Item("2020", 2020));
            comboBox2.Items.Add(new Item("2021", 2021));
            comboBox2.SelectedIndex = DateTime.Today.Year - 2018;
            label1.Text = "1"; _Panels[0] = panel1; LabelsKalender[0] = label1;
            label2.Text = "2"; _Panels[1] = panel2; LabelsKalender[1] = label2;
            label3.Text = "3"; _Panels[2] = panel3; LabelsKalender[2] = label3;
            label4.Text = "4"; _Panels[3] = panel4; LabelsKalender[3] = label4;
            label5.Text = "5"; _Panels[4] = panel5; LabelsKalender[4] = label5;
            label6.Text = "6"; _Panels[5] = panel6; LabelsKalender[5] = label6;
            label7.Text = "7"; _Panels[6] = panel7; LabelsKalender[6] = label7;
            label8.Text = "8"; _Panels[7] = panel8; LabelsKalender[7] = label8;
            label9.Text = "9"; _Panels[8] = panel9; LabelsKalender[8] = label9;
            label10.Text = "10"; _Panels[9] = panel10; LabelsKalender[9] = label10;
            label11.Text = "11"; _Panels[10] = panel11; LabelsKalender[10] = label11;
            label12.Text = "12"; _Panels[11] = panel12; LabelsKalender[11] = label12;
            label13.Text = "13"; _Panels[12] = panel13; LabelsKalender[12] = label13;
            label14.Text = "14"; _Panels[13] = panel14; LabelsKalender[13] = label14;
            label15.Text = "15"; _Panels[14] = panel15; LabelsKalender[14] = label15;
            label16.Text = "16"; _Panels[15] = panel16; LabelsKalender[15] = label16;
            label17.Text = "17"; _Panels[16] = panel17; LabelsKalender[16] = label17;
            label18.Text = "18"; _Panels[17] = panel18; LabelsKalender[17] = label18;
            label19.Text = "19"; _Panels[18] = panel19; LabelsKalender[18] = label19;
            label20.Text = "20"; _Panels[19] = panel20; LabelsKalender[19] = label20;
            label21.Text = "21"; _Panels[20] = panel21; LabelsKalender[20] = label21;
            label22.Text = "22"; _Panels[21] = panel22; LabelsKalender[21] = label22;
            label23.Text = "23"; _Panels[22] = panel23; LabelsKalender[22] = label23;
            label24.Text = "24"; _Panels[23] = panel24; LabelsKalender[23] = label24;
            label25.Text = "25"; _Panels[24] = panel25; LabelsKalender[24] = label25;
            label26.Text = "26"; _Panels[25] = panel26; LabelsKalender[25] = label26;
            label27.Text = "27"; _Panels[26] = panel27; LabelsKalender[26] = label27;
            label28.Text = "28"; _Panels[27] = panel28; LabelsKalender[27] = label28;
            label29.Text = "29"; _Panels[28] = panel29; LabelsKalender[28] = label29;
            label30.Text = "30"; _Panels[29] = panel30; LabelsKalender[29] = label30;
            label31.Text = "31"; _Panels[30] = panel31; LabelsKalender[30] = label31;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Text = DateTime.Today.ToShortDateString();
            FehltageListe = k1.GetUrlaubstage();
            KrankheitstageListe = k1.GetKrankheitstage();
            FreieUrlaubstageRefresh();
            comboBox3.Items.Add(new Item("Urlaub", 0));
            comboBox3.Items.Add(new Item("Krankheit", 1));
            Profilbild_refresh();
            InitFehltage();
            AnzahlAccounts();


        }       //Initialisierung der Kalender Labels und des Gesamten Layouts
        private void InitFehltage()
        {
            comboBox3.SelectedIndex = 0;
            _Labels[0] = Freier_Tag1; _Labels[0].Text = "";
            _Labels[1] = Freier_Tag2; _Labels[1].Text = "";
            _Labels[2] = Freier_Tag3; _Labels[2].Text = "";
            _Labels[3] = Freier_Tag4; _Labels[3].Text = "";
            _Labels[4] = Freier_Tag5; _Labels[4].Text = "";
            _Labels[5] = Freier_Tag6; _Labels[5].Text = "";
            _Labels[6] = Freier_Tag7; _Labels[6].Text = "";
            _Labels[7] = Freier_Tag8; _Labels[7].Text = "";
            _Labels[8] = Freier_Tag9; _Labels[8].Text = "";
            _Labels[9] = Freier_Tag10; _Labels[9].Text = "";
            counter = 0;


        } //Fehltage init

        private int TageImMonat()
        {
            int value = TimeandDate_.Value_Month_days();
            if (value == 31)
            {
                label29.Visible = true;
                label30.Visible = true;
                label31.Visible = true;
            }
            if (value == 30)
            {
                label29.Visible = true;
                label30.Visible = true;
                label31.Visible = false;
            }
            if (value == 29)
            {
                label29.Visible = true;
                label30.Visible = false;
                label31.Visible = false;
            }
            if (value == 28)
            {
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
            }
            return value;
        }    //Ausgabe anzahl Tage im Monat 
        private void Label_Click(object sender, EventArgs e)
        {
            Text_reset();
            int p = 10;
            if (k1.GetFreiUrlaubstage() > 0)
            {
                if (k1.GetFreiUrlaubstage() < 10)
                {
                    p = k1.GetFreiUrlaubstage();
                }
                DateTime t;
                Label clickedLabel = sender as Label;
                string tmp = sender.ToString();
                s = tmp.Substring(tmp.Length - 2);
                t = Datum_anpassung();
                if(t.Year>DateTime.Today.Year)
                {
                    return;
                }
                if(t.DayOfWeek.ToString()=="Sunday"|| t.DayOfWeek.ToString() == "Saturday")
                {
                    return;
                }
                if (clickedLabel.BackColor==Color.Transparent&&_Panels[t.Day-1].BackColor==Color.Transparent)
                {
                    if (_Labels[counter].Text == "")
                    {
                        clickedLabel.BackColor = Color.DodgerBlue;
                        _Panels[t.Day - 1].BackColor = Color.DodgerBlue;
                        _Labels[counter].Text = t.ToShortDateString();
                        counter++;
                    }
                    if (counter == p)
                    {
                        DialogResult result = MessageBox.Show("Auswahl bestätigen [OK] oder Auswahl zurücksetzen [Cancel]",
                        "Auswahl Bestätigen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                            Urlaub_akzeptieren();
                        else
                            InitFehltage();
                        return;
                    }
                }
                else
                {
                    if(clickedLabel.BackColor==Color.Red|| _Panels[t.Day - 1].BackColor == Color.Red)
                    {
                        
                    }
                    if(clickedLabel.BackColor==Color.Green|| _Panels[t.Day - 1].BackColor == Color.Green)
                    {
                          
                    }
                    if (clickedLabel.BackColor == Color.Yellow || _Panels[t.Day - 1].BackColor == Color.Yellow)
                    {
                        string[] text = new string[10];
                        for(int i=0;i<9;i++)
                        {
                            text[i] = textBox1.Lines[i];
                        }
                        for (int i = 0; i < Feiertage.Count; i++)
                        {
                            if (Feiertage[i] == t)
                            {
                                int index = Feiertage.IndexOf(t);
                                text[9] = "Feiertag: "+FeiertageNamen[index].ToString();
                            }
                        }
                        textBox1.Lines = text;




                    }
                    if (clickedLabel.BackColor == Color.DodgerBlue || _Panels[t.Day - 1].BackColor == Color.DodgerBlue)
                    {
                        clickedLabel.BackColor = Color.Transparent;
                        _Panels[t.Day - 1].BackColor = Color.Transparent;
                        for (int i = 0; i <= 9; i++)
                        {
                            if (_Labels[i].Text == t.ToShortDateString())
                            {
                                _Labels[i].Text = "";
                                counter--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Urlaubstage aufgebraucht schauen Sie in die Urlaubstage Liste!");
            }
            s = null;
         
        } // Event: Klick auf die KalenderLabels

        private void Panel_reset()
        {
            for (int i = 0; i <= 30; i++)
            {
                _Panels[i].BackColor = Color.Transparent;
            }
        } //Farben der Panels clearen
        private void Label_reset()
        {
            for (int i = 0; i < 30; i++)
                LabelsKalender[i].BackColor = Color.Transparent;
        } //Farben der Labels clearen 
        private void Text_reset()
        {
            string[] text = new string[10];
            for (int i = 0; i < 9; i++)
            {
                text[i] = textBox1.Lines[i];
            }
            textBox1.Lines = text;
        } //Textbox auf standard setzen

        private void Wochentage_Anpassen(DateTime temp)
        {
            Wochentag1.BackColor = Color.Transparent;
            Wochentag2.BackColor = Color.Transparent;
            Wochentag3.BackColor = Color.Transparent;
            Wochentag4.BackColor = Color.Transparent;
            Wochentag5.BackColor = Color.Transparent;
            Wochentag6.BackColor = Color.Transparent;
            Wochentag7.BackColor = Color.Transparent;
            string l=new DateTime(temp.Year,temp.Month,1).DayOfWeek.ToString();
           switch(l)
            {
                default: break;
                case "Monday":
                    Wochentag1.Text = "Mo";
                    Wochentag2.Text = "Di";
                    Wochentag3.Text = "Mi";
                    Wochentag4.Text = "Do";
                    Wochentag5.Text = "Fr";
                    Wochentag6.Text = "Sa";
                    Wochentag7.Text = "So";
                    Wochentag6.BackColor = Color.LightGray;
                    Wochentag7.BackColor = Color.LightGray;
                    break;
                case "Tuesday":
                    Wochentag1.Text = "Di";
                    Wochentag2.Text = "Mi";
                    Wochentag3.Text = "Do";
                    Wochentag4.Text = "Fr";
                    Wochentag5.Text = "Sa";
                    Wochentag6.Text = "So";
                    Wochentag7.Text = "Mo";
                    Wochentag5.BackColor = Color.LightGray;
                    Wochentag6.BackColor = Color.LightGray;
                    break;
                case "Wednesday":
                    Wochentag1.Text = "Mi";
                    Wochentag2.Text = "Do";
                    Wochentag3.Text = "Fr";
                    Wochentag4.Text = "Sa";
                    Wochentag5.Text = "So";
                    Wochentag6.Text = "Mo";
                    Wochentag7.Text = "Di";
                    Wochentag5.BackColor = Color.LightGray;
                    Wochentag4.BackColor = Color.LightGray;
                    break;    
                case "Thursday":
                    Wochentag1.Text = "Do";
                    Wochentag2.Text = "Fr";
                    Wochentag3.Text = "Sa";
                    Wochentag4.Text = "So";
                    Wochentag5.Text = "Mo";
                    Wochentag6.Text = "Di";
                    Wochentag7.Text = "Mi";
                    Wochentag4.BackColor = Color.LightGray;
                    Wochentag3.BackColor = Color.LightGray;
                    break;
                case "Friday":
                    Wochentag1.Text = "Fr";
                    Wochentag2.Text = "Sa";
                    Wochentag3.Text = "So";
                    Wochentag4.Text = "Mo";
                    Wochentag5.Text = "Di";
                    Wochentag6.Text = "Mi";
                    Wochentag7.Text = "Do";
                    Wochentag3.BackColor = Color.LightGray;
                    Wochentag2.BackColor = Color.LightGray;
                    break;
                case "Saturday":
                    Wochentag1.Text = "Sa";
                    Wochentag2.Text = "So";
                    Wochentag3.Text = "Mo";
                    Wochentag4.Text = "Di";
                    Wochentag5.Text = "Mi";
                    Wochentag6.Text = "Do";
                    Wochentag7.Text = "Fr";
                    Wochentag2.BackColor = Color.LightGray;
                    Wochentag1.BackColor = Color.LightGray;
                    break;
                case "Sunday":
                    Wochentag1.Text = "So";
                    Wochentag2.Text = "Mo";
                    Wochentag3.Text = "Di";
                    Wochentag4.Text = "Mi";
                    Wochentag5.Text = "Do";
                    Wochentag6.Text = "Fr";
                    Wochentag7.Text = "Sa";
                    Wochentag1.BackColor = Color.LightGray;
                    Wochentag7.BackColor = Color.LightGray;
                    break;
            }
        } //Wochentag nach 1. im Monat anpassen
        private void Profilbild_refresh()
        {
            Profilbild.Image = k1.GetProfilbild();
        }
        private void AnzahlAccounts()
        {
            if(verwaltung.GetAccAnzahl()!=0)
            label43.Text = verwaltung.GetAccAnzahl().ToString();
            else
            {
                label43.Text = "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        
            if (comboBox1.SelectedIndex == 11 && comboBox2.SelectedIndex == 3)
            {
                MessageBox.Show("Weiter vor ist nicht möglich wenden Sie sich an einen Admin");
            }
            if (comboBox1.SelectedIndex < 11)
            {
                TimeandDate_.Value_Month(1);
                comboBox1.SelectedIndex += +1;
                Datum_anpassung();
                TageImMonat();
                Label_reset();
                Panel_reset();
                Text_reset();
                Urlaubstage_Färben();
                Krankheitstage_Färben();
                Feiertage_Färben();
            }



        }//Vor 1 MONAT
        private void Button1_Click(object sender, EventArgs e)
        {
        
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                MessageBox.Show("Weiter zurück ist nicht möglich wenden Sie sich an einen Admin");
            }
            if (comboBox1.SelectedIndex > 0)
            {
                TimeandDate_.Value_Month(-1);
                comboBox1.SelectedIndex += -1;
                Datum_anpassung();
                TageImMonat();
                Label_reset();
                Panel_reset();
                Text_reset();
                Urlaubstage_Färben();
                Krankheitstage_Färben();
                Feiertage_Färben();

            }




        }//Zurück 1 MONAT

        private DateTime Datum_anpassung()
        {
            int day;
            if (s == null)
            {
                day = DateTime.Today.Day;
            }
            else
            {
                day = Convert.ToInt32(s);
            }
            int year = Convert.ToInt32(comboBox2.Text);
            int month = Convert.ToInt32(comboBox1.SelectedIndex + 1);
            DateTime Datumanpassung = new DateTime(year, month, day);
            TimeandDate_.SetMyValue(Datumanpassung);
            label32.Text = Datumanpassung.ToShortDateString();
            Wochentage_Anpassen(Datumanpassung);
            FreieUrlaubstageRefresh();
            Urlaubstage_Färben();
            Krankheitstage_Färben();
            Feiertage_Färben();
            return Datumanpassung;
        }    //Datums anzeige korrigieren
        private void Refresh_Form()
        {
            Label_reset();
            Panel_reset();
            TageImMonat();
            Datum_anpassung();
        } //Datum refresh falls falsch 

        private void Button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "Urlaub")
            {
                Urlaub_akzeptieren();
            }
            else
            {
                Krankheit_akzeptieren();
            }

        }//Urlaub /Krankheit akzeptieren Button
        private void Urlaub_akzeptieren()
        {
            Fehltage_Speichern();
            SetFehltage();
            FreieUrlaubstageRefresh();
            counter = 0;
            for (int i = 0; i <= 9; i++)
            {
                _Labels[i].Text = "";
            }
            Refresh_Form();
        } //Urlaub Akzeptieren Methode
        private void Krankheit_akzeptieren()
        {
            Krankheit_Speichern();
            SetKrankheitstage();
            FreieUrlaubstageRefresh();
            counter = 0;
            for (int i = 0; i <= 9; i++)
            {
                _Labels[i].Text = "";
            }
            Refresh_Form();
        } //Krankheit Akzeptieren Methode
        private void Fehltage_Speichern()
        {

            string temp, temp1;
            for (int i = 0; i < 9; i++)
            {
                if (_Labels[i].Text != "")
                {
                    temp = _Labels[i].Text;
                    int day, month, year;
                    temp1 = temp[0] + "" + temp[1];
                    day = Convert.ToInt32(temp1);
                    temp1 = temp[3] + "" + temp[4];
                    month = Convert.ToInt32(temp1);
                    temp1 = temp[6] + "" + temp[7] + "" + temp[8] + "" + temp[9];
                    year = Convert.ToInt32(temp1);
                    DateTime Fehltag = new DateTime(year, month, day);
                    if (FehltageListe.Contains(Fehltag) == false)
                    {
                        FehltageListe.Add(Fehltag);
                    }
                }
            }
        } //Fehltage in Kalender Liste speichern
        private void Krankheit_Speichern()
        {
            string temp, temp1;
            for (int i = 0; i < 9; i++)
            {
                if (_Labels[i].Text != "")
                {
                    temp = _Labels[i].Text;
                    int day, month, year;
                    temp1 = temp[0] + "" + temp[1];
                    day = Convert.ToInt32(temp1);
                    temp1 = temp[3] + "" + temp[4];
                    month = Convert.ToInt32(temp1);
                    temp1 = temp[6] + "" + temp[7] + "" + temp[8] + "" + temp[9];
                    year = Convert.ToInt32(temp1);
                    DateTime Krankheitstag = new DateTime(year, month, day);
                    if (KrankheitstageListe.Contains(Krankheitstag) == false)
                    {
                        KrankheitstageListe.Add(Krankheitstag);
                    }
                }
            }
        } //Krankheit in Kalender Liste speichern
        public void SetFehltage()
        {
            k1.SetUrlaubstage(FehltageListe);
        } //Fehltage-Liste in Konto übertragen
        public void SetKrankheitstage()
        {
            k1.SetKrankheitstage(KrankheitstageListe);
        } //Krankheitstag-Liste in Konto übertragen

        private void _MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        } //Maus Zeiger änderung
        private void _MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        } //Maus Zeiger änderung

        private void Urlaubstage_Färben()
        {

            if (FehltageListe.Count == 0) return;
            for (int i = 0; i < FehltageListe.Count; i++)
            {
                if (FehltageListe[i].Year.ToString() == comboBox2.SelectedItem.ToString() && FehltageListe[i].Month == comboBox1.SelectedIndex + 1)
                {

                    int j = FehltageListe[i].Day;
                    _Panels[j - 1].BackColor = Color.Green;
                    
                }
            }
        } // Urlaubstage werden Grün angemalt
        private void Krankheitstage_Färben()
        {
            if (KrankheitstageListe.Count == 0) return;
            for (int i = 0; i < KrankheitstageListe.Count; i++)
            {
                if (KrankheitstageListe[i].Year.ToString() == comboBox2.SelectedItem.ToString() && KrankheitstageListe[i].Month == comboBox1.SelectedIndex + 1)
                {
                    int j = KrankheitstageListe[i].Day;
                    _Panels[j - 1].BackColor = Color.Red;
                    
                }
            }
        } // Krankheitstage werden rot angemalt
        private void Feiertage_Färben()
        {
                Feiertage_einstellen();
                if (Feiertage.Count == 0) return;
                for (int i = 0; i < Feiertage.Count; i++)
                {
                    if (Feiertage[i].Year.ToString() == comboBox2.SelectedItem.ToString() && Feiertage[i].Month == comboBox1.SelectedIndex + 1)
                    {
                        int j = Feiertage[i].Day;
                        if (_Panels[j - 1].BackColor != Color.Green && _Panels[j - 1].BackColor != Color.Red && LabelsKalender[j - 1].BackColor != Color.Red && LabelsKalender[j - 1].BackColor != Color.Green)
                        {
                            _Panels[j - 1].BackColor = Color.Yellow;
                            
                        }

                    }
                }
            
            

        } // Feiertage werden Gelb angemalt
        private void Feiertage_einstellen()
        {
            if (Feiertage.Count == 0)
            {
                for (int i = 2018; i < 2022; i++)
                {
                    Feiertage.Add(new DateTime(i, 1, 1)); //Neujahr
                    FeiertageNamen.Add("Neujahr");
                    Feiertage.Add(new DateTime(i, 3, 8)); //Intern. Frauentag
                    FeiertageNamen.Add("Weltfrauentag");
                    Feiertage.Add(new DateTime(i, 5, 1)); //Tag der Arbeit
                    FeiertageNamen.Add("Tag der Arbeit");
                    Feiertage.Add(new DateTime(i, 8, 15));// Maria Himmelfahrt
                    FeiertageNamen.Add("Maria Himmelfahrt");
                    Feiertage.Add(new DateTime(i, 10, 3)); // Tag der Deutschen Einheit
                    FeiertageNamen.Add("Tag der Deutschen Einheit");
                    Feiertage.Add(new DateTime(i, 12, 24)); //Heilig Abend
                    FeiertageNamen.Add("Heilig Abend");
                    Feiertage.Add(new DateTime(i, 12, 25)); //1. Weihnachtsfeiertag
                    FeiertageNamen.Add("1.Weihnachtsfeiertag");
                    Feiertage.Add(new DateTime(i, 12, 26)); // 2. Weihnachtsfeiertag
                    FeiertageNamen.Add("2.Weihnachtsfeiertag");
                    Feiertage.Add(new DateTime(i, 12, 31)); //Silvester
                    FeiertageNamen.Add("Silvester");

                }
            }
        } //Feiertage Hier hinzufügen

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label36.Text = comboBox1.SelectedItem.ToString();
            
        }  //Monats Index Change
        private void FreieUrlaubstageRefresh()
        {
            label39.Text = k1.GetFreiUrlaubstage().ToString();
            
        } //Wieviele Urlaubstage man noch hat
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label37.Text = comboBox2.SelectedItem.ToString();
         
        }   //Jahres Index Change

        private void Profil_Bearbeiten_Button_Click(object sender, EventArgs e)
        {
            Profil_Bearbeitung b = new Profil_Bearbeitung(k1);
            b.ShowDialog();
            Profilbild_refresh();
        } //Profil bearbeiten Form öffnen
        private void Krankheitstage_Button_Click(object sender, EventArgs e)
        {
          
                Krankheitstage z = new Krankheitstage(k1);
                z.ShowDialog();
                Refresh_Form();
        } //Krankheitstage Form öffnen
        private void Urlaubstage_Button_Click(object sender, EventArgs e)
        {
            
                Urlaubstage u = new Urlaubstage(k1);
                u.ShowDialog();
                Refresh_Form();
        } //Urlaubstage Form öffnen
        private void Anfrage_an_Admin_Button_Click(object sender, EventArgs e) 
        {
           
                Administration a = new Administration(verwaltung);
                a.ShowDialog();
            
        }//Entweder Nachricht an Admin oder Administrator Fenster öffnen
        private void Tagesplan_Button_Click(object sender, EventArgs e)
        {
            string temp = label32.Text;
            int day, month, year;
            day = Convert.ToInt32(temp[0] + "" + temp[1]);
            month = Convert.ToInt32(temp[3] + "" + temp[4]);
            year = Convert.ToInt32(temp[6] + "" + temp[7] + "" + temp[8] + "" + temp[9]);

            Tagesplan r = new Tagesplan(k1, new DateTime(year, month, day));
            r.ShowDialog();
            InitFehltage();
            Refresh_Form();
        } //Tagesplan Form öffnen
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //Beenden
        private void Reload_Form_Click(object sender, EventArgs e)
        {
            Refresh_Form();
        } //Form Reload
        private void Homepage_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bsgg.net");   
        } //Webseite öffnen
        private void Profilbild_Click(object sender, EventArgs e)
        {
            Profil_Bearbeitung b = new Profil_Bearbeitung(k1);
            b.ShowDialog();
            Profilbild_refresh();
        }//Profil bearbeiten Form öffnen
        private void panel33_Click(object sender, EventArgs e)
        {
            Profil_Bearbeitung b = new Profil_Bearbeitung(k1);
            b.ShowDialog();
            Profilbild_refresh();
        }//Profil bearbeiten Form öffnen

        private void panel32_MouseMove(object sender, MouseEventArgs e) //Move ermöglichen
        {
            if(mov==1)
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