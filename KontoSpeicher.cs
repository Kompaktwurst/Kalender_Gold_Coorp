using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kalender_Gold_Coorp
{
    [Serializable]
   public class KontoSpeicher
    {
        private List<Konto> k1;
        public KontoSpeicher()=>k1=new List<Konto>();
        public int GetListenLänge() => k1.Count;
        public void AddKonto(Konto k1_)
        {
            k1.Add(k1_);
        }
        public void Speichern(string path)
        {
            Leeren(path);
            FileStream FS = new FileStream(path, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, this);
            FS.Dispose();
        }
        public KontoSpeicher Laden(string path)
        {
            KontoSpeicher erg;
            FileStream FS = new FileStream(path, FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            erg = (KontoSpeicher)BF.Deserialize(FS);
            FS.Dispose();
            return erg;
        }
        public void Leeren(string path)
        {
            File.Delete(path);
            FileStream FS = new FileStream(path, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, new Konto());
            FS.Dispose();
            
        }
       
        public Konto GetKonto(int index) => k1[index];
    }
  
}

//HUNG HILFT 2.0
//public void speichern(string path)
//{
//    leeren(path);
//    FileStream FS = new FileStream(path, FileMode.Create);
//    BinaryFormatter BF = new BinaryFormatter();
//    BF.Serialize(FS, this);
//    FS.Dispose();
//}
//public Firma laden(string path)
//{
//    Firma erg = new Firma();
//    FileStream FS = new FileStream(path, FileMode.Open);
//    BinaryFormatter BF = new BinaryFormatter();
//    erg = (Firma)BF.Deserialize(FS);
//    FS.Dispose();
//    return erg;
//}
//public void leeren(string path)
//{
//    File.Delete(path);
//    FileStream FS = new FileStream(path, FileMode.Create);
//    BinaryFormatter BF = new BinaryFormatter();
//    BF.Serialize(FS, new Firma());
//    FS.Dispose();
//}
