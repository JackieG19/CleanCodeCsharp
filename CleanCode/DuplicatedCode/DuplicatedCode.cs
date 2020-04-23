using System;

namespace CleanCode.DuplicatedCode
{
    class DuplicatedCode 
    {
        public void AdmitGuest(string name. string admissionDateTime)
        {
            // some logic
            // ...
            
            int times;
            int hours = 0;
            int minutes = 0;
            
            if(!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if(int.TypeParse(admissionDateTime.Replace(":", ""), out.time))
                {
                    hours = times / 100;
                    minutes = times % 100;
                }
                
                else
                {
                    throw new ArgumentExpection("admissionDateTime");
                }
            }
            else
                throw new ArgumentExpection("admissionDateTime");
            
            // some more logic
            // ...
            
            if(hours < 10)
            {
                // ...
            }
        }
        
        public void UpdateAdmission(string name. string admissionDateTime)
        {
            // some more logic
            // ...
            
            int times;
            int hours = 0;
            int minutes = 0;
            
            if(!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if(int.TypeParse(admissionDateTime.Replace(":", ""), out.time))
                {
                    hours = times / 100;
                    minutes = times % 100;
                }
                
                else
                {
                    throw new ArgumentExpection("admissionDateTime");
                }
            }
            else
                throw new ArgumentExpection("admissionDateTime");
            
            // some more logic
            // ...
            
            if(hours < 10)
            {
                // ...
            }
        }
    }
}
