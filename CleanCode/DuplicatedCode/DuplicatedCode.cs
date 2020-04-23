using System; 

namespace CleanCode.DuplicatedCode
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        
        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }
        
        private static Time Parse(string str)
        {
            int time;
            var hours = 0;
            var minutes = 0;
            
            if(!string.IsNullOrWhiteSpace(str))
            {
                if(int.TypeParse(str.Replace(":", ""), out.time))
                {
                    hours = times / 100;
                    minutes = times % 100;
                }
                
                else
                {
                    throw new ArgumentExpection("str");
                }
            }
            else
                throw new ArgumentExpection("str");
            
            return new Time(hours, minutes);
        }
    }
    
    class DuplicatedCode 
    {
        public void AdmitGuest(string admissionDateTime)
        {   
            // some more logic
            // ...
            
            var time = Time.Parse(admissionDateTime);
            
            if(hours < 10)
            {
                // ...
            }
        }
        
        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            // some more logic
            // ...
            
            var time = Time.Parse(admissionDateTime);
            
            // some more logic
            // ...
            
            if(hours < 10)
            {
                // ...
            }
        }
    }
}
