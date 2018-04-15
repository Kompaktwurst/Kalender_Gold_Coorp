using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender_Gold_Coorp
{
    [Serializable]
    public class TimeandDate
    {

        private DateTime MyValue;
        public TimeandDate()
        { 
            
        }
        
        public DateTime GetMyValue()
        {       
                return MyValue;
        }
        public void SetMyValue(DateTime MyValue_)
        {
                MyValue = MyValue_;
        }
        public string Value_Month(int add)
        { 
                MyValue = MyValue.AddMonths(add);
                return MyValue.ToShortDateString();
        }
        public string Value_Year(int add)
        {
                MyValue = MyValue.AddYears(add);
                return MyValue.ToShortDateString();
        }
        public int Value_Month_days()
        {
                int TageImMonat=DateTime.DaysInMonth(Convert.ToInt32(MyValue.Year), Convert.ToInt32(MyValue.Month));
                return TageImMonat;
        }
        

    }
    
}
