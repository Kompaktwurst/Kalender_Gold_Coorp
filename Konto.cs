using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Kalender_Gold_Coorp
{
    [Serializable]

    public class Konto
    {

      
        private string Benutzername,Geburtsdatum,Abteilung,Beruf,Status;    //Attribute...
        private int FreieUrlaubstage=30;
        
        private Image Profilbild;
        private byte[] HashedPassword;
        private List<DateTime> Urlaubstage;
        private List<DateTime> Krankheitstage;
        private List<string[]> Tagesplanliste;
        


        //Attribute...
        public Konto()
        {
            Profilbild = Properties.Resources.user;
            Urlaubstage= new List<DateTime>();
            Krankheitstage = new List<DateTime>();
            Tagesplanliste = new List<string[]>();

        }
        public bool Einloggen(string name, string passwort)
        {
            
            if (Benutzername != name) return false;
                    
                for (int i = 0; i < HashedPassword.Length; i++)
                    if (HashedPassword[i] != GetMD5Hash(passwort)[i])
                        return false;
                return true;
            
        }
        public string GetHashedPassword()
        {
            return HashedPassword.ToString();
        }                                   //Getter
        private byte[] GetMD5Hash(string TextToHash)
        {
           
            //Prüfen ob Daten übergeben wurden.
            if ((TextToHash == null) || (TextToHash.Length == 0)) return null;
            
            MD5 md5 = new MD5CryptoServiceProvider();                                   
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);
            return result;
        }
        public string GetKonto() => Benutzername + ", " + HashedPassword;
        public string GetBenutzername() => Benutzername;
        public string GetGeburtstag() => Geburtsdatum;
        public string GetAbteilung() => Abteilung;
        public string GetBeruf() => Beruf;
        public List<DateTime> GetUrlaubstage() => Urlaubstage;
        public string GetStatus() => Status;
        public int GetFreiUrlaubstage() => FreieUrlaubstage;
        public Image GetProfilbild() => Profilbild;
        public List<DateTime> GetKrankheitstage() => Krankheitstage;
        public List<string[]> GetTagesplan() => Tagesplanliste;
    
        

        public void SetGeburtstag(string eingabe) { Geburtsdatum = eingabe; }       //Setter
        public void SetAbteilung(string eingabe) { Abteilung = eingabe; }
        public void SetBeruf(string eingabe) { Beruf = eingabe; }
        public void SetProfilbild(Image profilbild_) { Profilbild = profilbild_; }
        public void SetUrlaubstage(List<DateTime> Urlaubstage_)
        {
            Urlaubstage = Urlaubstage_;
            FreieUrlaubstage = 30- Urlaubstage.Count;
        }   
        public void SetKrankheitstage(List<DateTime> Krankheitstage_)
        {
            Krankheitstage = Krankheitstage_;
        }
        public void SetStatus(string status_){Status = status_;}
        public void setPasswort(string text){ HashedPassword = GetMD5Hash(text);}
        public void setBenutzername(string name) { Benutzername = name; }
        public void setTagesplan(List<string[]>Tagesplanliste_)
        {
            Tagesplanliste = Tagesplanliste_;
        }
       
 


    }
}